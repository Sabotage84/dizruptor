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
            this.label2 = new System.Windows.Forms.Label();
            this.TargetWords_lstBx = new System.Windows.Forms.ListBox();
            this.ToTarget_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.word_FD = new System.Windows.Forms.OpenFileDialog();
            this.combineWords_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.innerWords_lstbx = new System.Windows.Forms.ListBox();
            this.removeWord_btn = new System.Windows.Forms.Button();
            this.targetListLoad_txtBx = new System.Windows.Forms.TextBox();
            this.targetLoad_btn = new System.Windows.Forms.Button();
            this.targetLoadFile_FD = new System.Windows.Forms.OpenFileDialog();
            this.targetLoadWords_btn = new System.Windows.Forms.Button();
            this.saveTargetToXML = new System.Windows.Forms.Button();
            this.allWords_grpBx = new System.Windows.Forms.GroupBox();
            this.withOutCuntOne_chkBx = new System.Windows.Forms.CheckBox();
            this.allWordsSortByCount_rdBtn = new System.Windows.Forms.RadioButton();
            this.allWordsSortByLength_rdBtn = new System.Windows.Forms.RadioButton();
            this.allWordsSortByName_rdBtn = new System.Windows.Forms.RadioButton();
            this.pageSatart_nmUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.findWord_txtBx = new System.Windows.Forms.TextBox();
            this.allWords_grpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSatart_nmUD)).BeginInit();
            this.SuspendLayout();
            // 
            // allWords_lstbx
            // 
            this.allWords_lstbx.FormattingEnabled = true;
            this.allWords_lstbx.Location = new System.Drawing.Point(12, 119);
            this.allWords_lstbx.Name = "allWords_lstbx";
            this.allWords_lstbx.Size = new System.Drawing.Size(248, 329);
            this.allWords_lstbx.TabIndex = 0;
            this.allWords_lstbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allWords_lstbx_KeyDown);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 480);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(248, 40);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Scan file";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // ToBadWords_btn
            // 
            this.ToBadWords_btn.Location = new System.Drawing.Point(266, 168);
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
            this.badWords_lstBx.Location = new System.Drawing.Point(356, 119);
            this.badWords_lstBx.Name = "badWords_lstBx";
            this.badWords_lstBx.Size = new System.Drawing.Size(163, 355);
            this.badWords_lstBx.TabIndex = 3;
            // 
            // book_fd
            // 
            this.book_fd.FileName = "openFileDialog1";
            // 
            // findFile_btn
            // 
            this.findFile_btn.Location = new System.Drawing.Point(235, 20);
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
            this.pathToBook_txtBx.Size = new System.Drawing.Size(217, 20);
            this.pathToBook_txtBx.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Simple words";
            // 
            // TargetWords_lstBx
            // 
            this.TargetWords_lstBx.FormattingEnabled = true;
            this.TargetWords_lstBx.Location = new System.Drawing.Point(546, 119);
            this.TargetWords_lstBx.Name = "TargetWords_lstBx";
            this.TargetWords_lstBx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.TargetWords_lstBx.Size = new System.Drawing.Size(172, 355);
            this.TargetWords_lstBx.TabIndex = 12;
            this.TargetWords_lstBx.SelectedIndexChanged += new System.EventHandler(this.TargetWords_lstBx_SelectedIndexChanged);
            // 
            // ToTarget_btn
            // 
            this.ToTarget_btn.Location = new System.Drawing.Point(266, 249);
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
            this.label3.Location = new System.Drawing.Point(546, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Target words";
            // 
            // word_FD
            // 
            this.word_FD.FileName = "openFileDialog1";
            // 
            // combineWords_btn
            // 
            this.combineWords_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combineWords_btn.Location = new System.Drawing.Point(724, 342);
            this.combineWords_btn.Name = "combineWords_btn";
            this.combineWords_btn.Size = new System.Drawing.Size(36, 29);
            this.combineWords_btn.TabIndex = 15;
            this.combineWords_btn.Text = "+";
            this.combineWords_btn.UseCompatibleTextRendering = true;
            this.combineWords_btn.UseVisualStyleBackColor = true;
            this.combineWords_btn.Click += new System.EventHandler(this.combineWords_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Make dictionary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // innerWords_lstbx
            // 
            this.innerWords_lstbx.FormattingEnabled = true;
            this.innerWords_lstbx.Location = new System.Drawing.Point(724, 119);
            this.innerWords_lstbx.Name = "innerWords_lstbx";
            this.innerWords_lstbx.Size = new System.Drawing.Size(120, 134);
            this.innerWords_lstbx.TabIndex = 17;
            // 
            // removeWord_btn
            // 
            this.removeWord_btn.Location = new System.Drawing.Point(758, 259);
            this.removeWord_btn.Name = "removeWord_btn";
            this.removeWord_btn.Size = new System.Drawing.Size(86, 23);
            this.removeWord_btn.TabIndex = 18;
            this.removeWord_btn.Text = "Remove word";
            this.removeWord_btn.UseVisualStyleBackColor = true;
            this.removeWord_btn.Click += new System.EventHandler(this.removeWord_btn_Click);
            // 
            // targetListLoad_txtBx
            // 
            this.targetListLoad_txtBx.Location = new System.Drawing.Point(546, 20);
            this.targetListLoad_txtBx.Name = "targetListLoad_txtBx";
            this.targetListLoad_txtBx.Size = new System.Drawing.Size(239, 20);
            this.targetListLoad_txtBx.TabIndex = 19;
            // 
            // targetLoad_btn
            // 
            this.targetLoad_btn.Location = new System.Drawing.Point(782, 19);
            this.targetLoad_btn.Name = "targetLoad_btn";
            this.targetLoad_btn.Size = new System.Drawing.Size(27, 23);
            this.targetLoad_btn.TabIndex = 20;
            this.targetLoad_btn.Text = "...";
            this.targetLoad_btn.UseVisualStyleBackColor = true;
            this.targetLoad_btn.Click += new System.EventHandler(this.targetLoad_btn_Click);
            // 
            // targetLoadFile_FD
            // 
            this.targetLoadFile_FD.FileName = "targetLoadFile_FD";
            // 
            // targetLoadWords_btn
            // 
            this.targetLoadWords_btn.Location = new System.Drawing.Point(815, 20);
            this.targetLoadWords_btn.Name = "targetLoadWords_btn";
            this.targetLoadWords_btn.Size = new System.Drawing.Size(75, 23);
            this.targetLoadWords_btn.TabIndex = 21;
            this.targetLoadWords_btn.Text = "Load target";
            this.targetLoadWords_btn.UseVisualStyleBackColor = true;
            this.targetLoadWords_btn.Click += new System.EventHandler(this.targetLoadWords_btn_Click);
            // 
            // saveTargetToXML
            // 
            this.saveTargetToXML.Location = new System.Drawing.Point(546, 480);
            this.saveTargetToXML.Name = "saveTargetToXML";
            this.saveTargetToXML.Size = new System.Drawing.Size(172, 36);
            this.saveTargetToXML.TabIndex = 22;
            this.saveTargetToXML.Text = "Save to XML";
            this.saveTargetToXML.UseVisualStyleBackColor = true;
            this.saveTargetToXML.Click += new System.EventHandler(this.saveTargetToXML_Click);
            // 
            // allWords_grpBx
            // 
            this.allWords_grpBx.Controls.Add(this.withOutCuntOne_chkBx);
            this.allWords_grpBx.Controls.Add(this.allWordsSortByCount_rdBtn);
            this.allWords_grpBx.Controls.Add(this.allWordsSortByLength_rdBtn);
            this.allWords_grpBx.Controls.Add(this.allWordsSortByName_rdBtn);
            this.allWords_grpBx.Enabled = false;
            this.allWords_grpBx.Location = new System.Drawing.Point(12, 45);
            this.allWords_grpBx.Name = "allWords_grpBx";
            this.allWords_grpBx.Size = new System.Drawing.Size(248, 72);
            this.allWords_grpBx.TabIndex = 23;
            this.allWords_grpBx.TabStop = false;
            this.allWords_grpBx.Text = "All words sort by";
            // 
            // withOutCuntOne_chkBx
            // 
            this.withOutCuntOne_chkBx.AutoSize = true;
            this.withOutCuntOne_chkBx.Location = new System.Drawing.Point(6, 51);
            this.withOutCuntOne_chkBx.Margin = new System.Windows.Forms.Padding(2);
            this.withOutCuntOne_chkBx.Name = "withOutCuntOne_chkBx";
            this.withOutCuntOne_chkBx.Size = new System.Drawing.Size(114, 17);
            this.withOutCuntOne_chkBx.TabIndex = 3;
            this.withOutCuntOne_chkBx.Text = "Without count one";
            this.withOutCuntOne_chkBx.UseVisualStyleBackColor = true;
            this.withOutCuntOne_chkBx.CheckedChanged += new System.EventHandler(this.withOutCuntOne_chkBx_CheckedChanged);
            // 
            // allWordsSortByCount_rdBtn
            // 
            this.allWordsSortByCount_rdBtn.AutoSize = true;
            this.allWordsSortByCount_rdBtn.Location = new System.Drawing.Point(123, 23);
            this.allWordsSortByCount_rdBtn.Name = "allWordsSortByCount_rdBtn";
            this.allWordsSortByCount_rdBtn.Size = new System.Drawing.Size(52, 17);
            this.allWordsSortByCount_rdBtn.TabIndex = 2;
            this.allWordsSortByCount_rdBtn.Text = "count";
            this.allWordsSortByCount_rdBtn.UseVisualStyleBackColor = true;
            this.allWordsSortByCount_rdBtn.CheckedChanged += new System.EventHandler(this.allWordsSortByCount_rdBtn_CheckedChanged);
            this.allWordsSortByCount_rdBtn.Click += new System.EventHandler(this.allWordsSortByCount_rdBtn_Click);
            // 
            // allWordsSortByLength_rdBtn
            // 
            this.allWordsSortByLength_rdBtn.AutoSize = true;
            this.allWordsSortByLength_rdBtn.Location = new System.Drawing.Point(63, 23);
            this.allWordsSortByLength_rdBtn.Name = "allWordsSortByLength_rdBtn";
            this.allWordsSortByLength_rdBtn.Size = new System.Drawing.Size(54, 17);
            this.allWordsSortByLength_rdBtn.TabIndex = 1;
            this.allWordsSortByLength_rdBtn.Text = "length";
            this.allWordsSortByLength_rdBtn.UseVisualStyleBackColor = true;
            this.allWordsSortByLength_rdBtn.CheckedChanged += new System.EventHandler(this.allWordsSortByLength_rdBtn_CheckedChanged);
            this.allWordsSortByLength_rdBtn.Click += new System.EventHandler(this.allWordsSortByLength_rdBtn_Click);
            // 
            // allWordsSortByName_rdBtn
            // 
            this.allWordsSortByName_rdBtn.AutoSize = true;
            this.allWordsSortByName_rdBtn.Checked = true;
            this.allWordsSortByName_rdBtn.Location = new System.Drawing.Point(6, 23);
            this.allWordsSortByName_rdBtn.Name = "allWordsSortByName_rdBtn";
            this.allWordsSortByName_rdBtn.Size = new System.Drawing.Size(51, 17);
            this.allWordsSortByName_rdBtn.TabIndex = 0;
            this.allWordsSortByName_rdBtn.TabStop = true;
            this.allWordsSortByName_rdBtn.Text = "name";
            this.allWordsSortByName_rdBtn.UseVisualStyleBackColor = true;
            this.allWordsSortByName_rdBtn.Click += new System.EventHandler(this.allWordsSortByName_rdBtn_Click);
            // 
            // pageSatart_nmUD
            // 
            this.pageSatart_nmUD.Location = new System.Drawing.Point(728, 442);
            this.pageSatart_nmUD.Name = "pageSatart_nmUD";
            this.pageSatart_nmUD.Size = new System.Drawing.Size(45, 20);
            this.pageSatart_nmUD.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Start with";
            // 
            // findWord_txtBx
            // 
            this.findWord_txtBx.Location = new System.Drawing.Point(12, 454);
            this.findWord_txtBx.Name = "findWord_txtBx";
            this.findWord_txtBx.Size = new System.Drawing.Size(248, 20);
            this.findWord_txtBx.TabIndex = 26;
            this.findWord_txtBx.TextChanged += new System.EventHandler(this.findWord_txtBx_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 554);
            this.Controls.Add(this.findWord_txtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pageSatart_nmUD);
            this.Controls.Add(this.allWords_grpBx);
            this.Controls.Add(this.saveTargetToXML);
            this.Controls.Add(this.targetLoadWords_btn);
            this.Controls.Add(this.targetLoad_btn);
            this.Controls.Add(this.targetListLoad_txtBx);
            this.Controls.Add(this.removeWord_btn);
            this.Controls.Add(this.innerWords_lstbx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.combineWords_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToTarget_btn);
            this.Controls.Add(this.TargetWords_lstBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathToBook_txtBx);
            this.Controls.Add(this.findFile_btn);
            this.Controls.Add(this.badWords_lstBx);
            this.Controls.Add(this.ToBadWords_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.allWords_lstbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.allWords_grpBx.ResumeLayout(false);
            this.allWords_grpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSatart_nmUD)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox TargetWords_lstBx;
        private System.Windows.Forms.Button ToTarget_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog word_FD;
        private System.Windows.Forms.Button combineWords_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox innerWords_lstbx;
        private System.Windows.Forms.Button removeWord_btn;
        private System.Windows.Forms.TextBox targetListLoad_txtBx;
        private System.Windows.Forms.Button targetLoad_btn;
        private System.Windows.Forms.OpenFileDialog targetLoadFile_FD;
        private System.Windows.Forms.Button targetLoadWords_btn;
        private System.Windows.Forms.Button saveTargetToXML;
        private System.Windows.Forms.GroupBox allWords_grpBx;
        private System.Windows.Forms.RadioButton allWordsSortByCount_rdBtn;
        private System.Windows.Forms.RadioButton allWordsSortByLength_rdBtn;
        private System.Windows.Forms.RadioButton allWordsSortByName_rdBtn;
        private System.Windows.Forms.NumericUpDown pageSatart_nmUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox withOutCuntOne_chkBx;
        private System.Windows.Forms.TextBox findWord_txtBx;
    }
}

