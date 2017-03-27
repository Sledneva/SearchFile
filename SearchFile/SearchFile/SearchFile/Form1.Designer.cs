namespace SearchFile
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.findBut = new System.Windows.Forms.Button();
            this.searchFile = new System.Windows.Forms.TextBox();
            this.rezultFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // findBut
            // 
            this.findBut.Location = new System.Drawing.Point(12, 12);
            this.findBut.Name = "findBut";
            this.findBut.Size = new System.Drawing.Size(75, 23);
            this.findBut.TabIndex = 0;
            this.findBut.Text = "Find";
            this.findBut.UseVisualStyleBackColor = true;
            this.findBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchFile
            // 
            this.searchFile.Location = new System.Drawing.Point(170, 12);
            this.searchFile.Name = "searchFile";
            this.searchFile.Size = new System.Drawing.Size(671, 24);
            this.searchFile.TabIndex = 1;
            this.searchFile.Text = "Enter text!";
            // 
            // rezultFile
            // 
            this.rezultFile.Location = new System.Drawing.Point(170, 42);
            this.rezultFile.Multiline = true;
            this.rezultFile.Name = "rezultFile";
            this.rezultFile.Size = new System.Drawing.Size(671, 321);
            this.rezultFile.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 375);
            this.Controls.Add(this.rezultFile);
            this.Controls.Add(this.searchFile);
            this.Controls.Add(this.findBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findBut;
        private System.Windows.Forms.TextBox searchFile;
        private System.Windows.Forms.TextBox rezultFile;
    }
}

