namespace Lab2_NT106
{
    partial class Bai3
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
            rtb_content = new RichTextBox();
            btn_readFile = new Button();
            btn_caculateAndWrite = new Button();
            SuspendLayout();
            // 
            // rtb_content
            // 
            rtb_content.Location = new Point(278, 12);
            rtb_content.Name = "rtb_content";
            rtb_content.Size = new Size(510, 426);
            rtb_content.TabIndex = 0;
            rtb_content.Text = "";
            // 
            // btn_readFile
            // 
            btn_readFile.Location = new Point(80, 94);
            btn_readFile.Name = "btn_readFile";
            btn_readFile.Size = new Size(112, 34);
            btn_readFile.TabIndex = 1;
            btn_readFile.Text = "Đọc file";
            btn_readFile.UseVisualStyleBackColor = true;
            btn_readFile.Click += btn_readFile_Click;
            // 
            // btn_caculateAndWrite
            // 
            btn_caculateAndWrite.Location = new Point(61, 221);
            btn_caculateAndWrite.Name = "btn_caculateAndWrite";
            btn_caculateAndWrite.Size = new Size(153, 34);
            btn_caculateAndWrite.TabIndex = 2;
            btn_caculateAndWrite.Text = "Tính và ghi file";
            btn_caculateAndWrite.UseVisualStyleBackColor = true;
            btn_caculateAndWrite.Click += btn_caculateAndWrite_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_caculateAndWrite);
            Controls.Add(btn_readFile);
            Controls.Add(rtb_content);
            Name = "Bai3";
            Text = "Bai3_24520303_BuiCongDinh";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_content;
        private Button btn_readFile;
        private Button btn_caculateAndWrite;
    }
}