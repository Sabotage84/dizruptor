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
            this.SuspendLayout();
            // 
            // allWords_lstbx
            // 
            this.allWords_lstbx.FormattingEnabled = true;
            this.allWords_lstbx.Location = new System.Drawing.Point(12, 52);
            this.allWords_lstbx.Name = "allWords_lstbx";
            this.allWords_lstbx.Size = new System.Drawing.Size(201, 368);
            this.allWords_lstbx.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(595, 440);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // ToBadWords_btn
            // 
            this.ToBadWords_btn.Location = new System.Drawing.Point(219, 178);
            this.ToBadWords_btn.Name = "ToBadWords_btn";
            this.ToBadWords_btn.Size = new System.Drawing.Size(75, 23);
            this.ToBadWords_btn.TabIndex = 2;
            this.ToBadWords_btn.TabStop = false;
            this.ToBadWords_btn.Text = "To bad";
            this.ToBadWords_btn.UseVisualStyleBackColor = true;
            this.ToBadWords_btn.Click += new System.EventHandler(this.ToBadWords_btn_Click);
            // 
            // badWords_lstBx
            // 
            this.badWords_lstBx.FormattingEnabled = true;
            this.badWords_lstBx.Location = new System.Drawing.Point(300, 52);
            this.badWords_lstBx.Name = "badWords_lstBx";
            this.badWords_lstBx.Size = new System.Drawing.Size(163, 368);
            this.badWords_lstBx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.badWords_lstBx);
            this.Controls.Add(this.ToBadWords_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.allWords_lstbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox allWords_lstbx;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button ToBadWords_btn;
        private System.Windows.Forms.ListBox badWords_lstBx;
    }
}

