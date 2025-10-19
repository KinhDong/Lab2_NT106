namespace Lab2_NT106
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ReadFile = new Button();
            rtb_FileContent = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_FileName = new TextBox();
            tb_Size = new TextBox();
            tb_URL = new TextBox();
            tb_LinesCount = new TextBox();
            tb_WordsCount = new TextBox();
            tb_CharactersCount = new TextBox();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // btn_ReadFile
            // 
            btn_ReadFile.Location = new Point(51, 34);
            btn_ReadFile.Name = "btn_ReadFile";
            btn_ReadFile.Size = new Size(358, 34);
            btn_ReadFile.TabIndex = 0;
            btn_ReadFile.Text = "Read from file";
            btn_ReadFile.UseVisualStyleBackColor = true;
            btn_ReadFile.Click += btn_ReadFile_Click;
            // 
            // rtb_FileContent
            // 
            rtb_FileContent.BackColor = SystemColors.InactiveCaptionText;
            rtb_FileContent.ForeColor = SystemColors.MenuHighlight;
            rtb_FileContent.Location = new Point(452, 34);
            rtb_FileContent.Name = "rtb_FileContent";
            rtb_FileContent.Size = new Size(571, 483);
            rtb_FileContent.TabIndex = 1;
            rtb_FileContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(51, 107);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "FileName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(51, 163);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 3;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(51, 218);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 4;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(51, 279);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 5;
            label4.Text = "Lines count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(51, 343);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 6;
            label5.Text = "Words count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(51, 411);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 7;
            label6.Text = "Character count";
            // 
            // tb_FileName
            // 
            tb_FileName.Location = new Point(219, 101);
            tb_FileName.Name = "tb_FileName";
            tb_FileName.ReadOnly = true;
            tb_FileName.ScrollBars = ScrollBars.Horizontal;
            tb_FileName.Size = new Size(190, 31);
            tb_FileName.TabIndex = 8;
            // 
            // tb_Size
            // 
            tb_Size.Location = new Point(219, 160);
            tb_Size.Name = "tb_Size";
            tb_Size.ReadOnly = true;
            tb_Size.ScrollBars = ScrollBars.Horizontal;
            tb_Size.Size = new Size(190, 31);
            tb_Size.TabIndex = 9;
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(219, 215);
            tb_URL.Name = "tb_URL";
            tb_URL.ReadOnly = true;
            tb_URL.ScrollBars = ScrollBars.Horizontal;
            tb_URL.Size = new Size(190, 31);
            tb_URL.TabIndex = 10;
            // 
            // tb_LinesCount
            // 
            tb_LinesCount.Location = new Point(219, 276);
            tb_LinesCount.Name = "tb_LinesCount";
            tb_LinesCount.ReadOnly = true;
            tb_LinesCount.ScrollBars = ScrollBars.Horizontal;
            tb_LinesCount.Size = new Size(190, 31);
            tb_LinesCount.TabIndex = 11;
            // 
            // tb_WordsCount
            // 
            tb_WordsCount.Location = new Point(219, 340);
            tb_WordsCount.Name = "tb_WordsCount";
            tb_WordsCount.ReadOnly = true;
            tb_WordsCount.ScrollBars = ScrollBars.Horizontal;
            tb_WordsCount.Size = new Size(190, 31);
            tb_WordsCount.TabIndex = 12;
            // 
            // tb_CharactersCount
            // 
            tb_CharactersCount.Location = new Point(219, 405);
            tb_CharactersCount.Name = "tb_CharactersCount";
            tb_CharactersCount.ReadOnly = true;
            tb_CharactersCount.ScrollBars = ScrollBars.Horizontal;
            tb_CharactersCount.Size = new Size(190, 31);
            tb_CharactersCount.TabIndex = 13;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(166, 483);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(112, 34);
            btn_Exit.TabIndex = 14;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1053, 563);
            Controls.Add(btn_Exit);
            Controls.Add(tb_CharactersCount);
            Controls.Add(tb_WordsCount);
            Controls.Add(tb_LinesCount);
            Controls.Add(tb_URL);
            Controls.Add(tb_Size);
            Controls.Add(tb_FileName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtb_FileContent);
            Controls.Add(btn_ReadFile);
            Name = "Bai2";
            Text = "Bai2_24520303_BuiCongDinh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ReadFile;
        private RichTextBox rtb_FileContent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_FileName;
        private TextBox tb_Size;
        private TextBox tb_URL;
        private TextBox tb_LinesCount;
        private TextBox tb_WordsCount;
        private TextBox tb_CharactersCount;
        private Button btn_Exit;
    }
}