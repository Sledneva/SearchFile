using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace SearchFile
{
    class Search
    {
        public string rezult = "";
        public List<string> filesList = Directory.GetFiles(@"Files", "*.txt").ToList();
            
        public void FindInFile(string search, string filePath)
        {
            StreamReader sr = new StreamReader(filePath, Encoding.Default);
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                if (str.IndexOf(search) != -1)
                {
                    rezult += filePath + " | ";
                }
            }
        }
        public void Threads(string search)
        {

            List<string> files = filesList;
            List<Thread> threads = new List<Thread>();
            object locker = new object();
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread((param) =>
                {
                    lock (locker)
                    {
                        if (files.Any())
                        {
                            FindInFile(search, files[0]);
                            files.RemoveAt(0);
                        }
                    }
                });
                thread.Name += i;
                threads.Add(thread);
            }
            foreach (Thread thread in threads)
                thread.Start();
        }
    } 
}
