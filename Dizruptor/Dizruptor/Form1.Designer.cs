namespace Dizruptor
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
            this.allWords_lstbx = new System.Windows.Forms.ListBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.ToBadWords_btn = new System.Windows.Forms.Button();
            this.badWords_lstBx = new System.Windows.Forms.ListBox();
            this.book_fd = new System.Windows.Forms.OpenFileDialog();
            this.findFile_btn = new System.Windows.Forms.Button();
            this.pathToBook_txtBx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PathToWordFile_txtbx = new System.Windows.Forms.TextBox();
            this.PathToWordFile_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetWords_lstBx = new System.Windows.Forms.ListBox();
            this.ToTarget_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.word_FD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // allWords_lstbx
            // 
            this.allWords_lstbx.FormattingEnabled = true;
            this.allWords_lstbx.Location = new System.Drawing.Point(12, 70);
            this.allWords_lstbx.Name = "allWords_lstbx";
            this.allWords_lstbx.Size = new System.Drawing.Size(201, 368);
            this.allWords_lstbx.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 444);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Scan txt file";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // ToBadWords_btn
            // 
            this.ToBadWords_btn.Location = new System.Drawing.Point(219, 168);
            this.ToBadWords_btn.Name = "ToBadWords_btn";
            this.ToBadWords_btn.Size = new System.Drawing.Size(75, 23);
            this.ToBadWords_btn.TabIndex = 2;
            this.ToBadWords_btn.TabStop = false;
            this.ToBadWords_btn.Text = "To simle";
            this.ToBadWords_btn.UseVisualStyleBackColor = true;
            this.ToBadWords_btn.Click += new System.EventHandler(this.ToBadWords_btn_Click);
            // 
            // badWords_lstBx
            // 
            this.badWords_lstBx.FormattingEnabled = true;
            this.badWords_lstBx.Location = new System.Drawing.Point(300, 70);
            this.badWords_lstBx.Name = "badWords_lstBx";
            this.badWords_lstBx.Size = new System.Drawing.Size(163, 368);
            this.badWords_lstBx.TabIndex = 3;
            // 
            // book_fd
            // 
            this.book_fd.FileName = "openFileDialog1";
            // 
            // findFile_btn
            // 
            this.findFile_btn.Location = new System.Drawing.Point(310, 19);
            this.findFile_btn.Name = "findFile_btn";
            this.findFile_btn.Size = new System.Drawing.Size(25, 20);
            this.findFile_btn.TabIndex = 5;
            this.findFile_btn.Text = "...";
            this.findFile_btn.UseVisualStyleBackColor = true;
            this.findFile_btn.Click += new System.EventHandler(this.findFile_btn_Click);
            // 
            // pathToBook_txtBx
            // 
            this.pathToBook_txtBx.Location = new System.Drawing.Point(12, 19);
            this.pathToBook_txtBx.Name = "pathToBook_txtBx";
            this.pathToBook_txtBx.Size = new System.Drawing.Size(292, 20);
            this.pathToBook_txtBx.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathToWordFile_txtbx
            // 
            this.PathToWordFile_txtbx.Location = new System.Drawing.Point(458, 20);
            this.PathToWordFile_txtbx.Name = "PathToWordFile_txtbx";
            this.PathToWordFile_txtbx.Size = new System.Drawing.Size(290, 20);
            this.PathToWordFile_txtbx.TabIndex = 8;
            // 
            // PathToWordFile_btn
            // 
            this.PathToWordFile_btn.Location = new System.Drawing.Point(754, 20);
            this.PathToWordFile_btn.Name = "PathToWordFile_btn";
            this.PathToWordFile_btn.Size = new System.Drawing.Size(25, 21);
            this.PathToWordFile_btn.TabIndex = 9;
            this.PathToWordFile_btn.Text = "...";
            this.PathToWordFile_btn.UseVisualStyleBackColor = true;
            this.PathToWordFile_btn.Click += new System.EventHandler(this.PathToWordFile_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "All words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Simple words";
            // 
            // TargetWords_lstBx
            // 
            this.TargetWords_lstBx.FormattingEnabled = true;
            this.TargetWords_lstBx.Location = new System.Drawing.Point(522, 70);
            this.TargetWords_lstBx.Name = "TargetWords_lstBx";
            this.TargetWords_lstBx.Size = new System.Drawing.Size(206, 368);
            this.TargetWords_lstBx.TabIndex = 12;
            // 
            // ToTarget_btn
            // 
            this.ToTarget_btn.Location = new System.Drawing.Point(219, 249);
            this.ToTarget_btn.Name = "ToTarget_btn";
            this.ToTarget_btn.Size = new System.Drawing.Size(75, 23);
            this.ToTarget_btn.TabIndex = 13;
            this.ToTarget_btn.Text = "To target";
            this.ToTarget_btn.UseVisualStyleBackColor = true;
            this.ToTarget_btn.Click += new System.EventHandler(this.ToTarget_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Target words";
            // 
            // word_FD
            // 
            this.word_FD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToTarget_btn);
            this.Controls.Add(this.TargetWords_lstBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathToWordFile_btn);
            this.Controls.Add(this.PathToWordFile_txtbx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathToBook_txtBx);
            this.Controls.Add(this.findFile_btn);
            this.Controls.Add(this.badWords_lstBx);
            this.Controls.Add(this.ToBadWords_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.allWords_lstbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allWords_lstbx;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button ToBadWords_btn;
        private System.Windows.Forms.ListBox badWords_lstBx;
        private System.Windows.Forms.OpenFileDialog book_fd;
        private System.Windows.Forms.Button findFile_btn;
        private System.Windows.Forms.TextBox pathToBook_txtBx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PathToWordFile_txtbx;
        private System.Windows.Forms.Button PathToWordFile_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox TargetWords_lstBx;
        private System.Windows.Forms.Button ToTarget_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog word_FD;
    }
}

