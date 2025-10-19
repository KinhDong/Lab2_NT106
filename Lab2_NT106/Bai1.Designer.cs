namespace Lab2_NT106
{
    partial class Bai1
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
            btn_Read = new Button();
            btn_Write = new Button();
            rtb_fileContent = new RichTextBox();
            SuspendLayout();
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(54, 58);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(202, 83);
            btn_Read.TabIndex = 0;
            btn_Read.Text = "Đọc file";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Write
            // 
            btn_Write.Location = new Point(54, 199);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(202, 90);
            btn_Write.TabIndex = 1;
            btn_Write.Text = "Ghi file";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // rtb_fileContent
            // 
            rtb_fileContent.Location = new Point(345, 58);
            rtb_fileContent.Name = "rtb_fileContent";
            rtb_fileContent.Size = new Size(396, 231);
            rtb_fileContent.TabIndex = 2;
            rtb_fileContent.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(rtb_fileContent);
            Controls.Add(btn_Write);
            Controls.Add(btn_Read);
            Name = "Bai1";
            Text = "Bai1_24520303_BuiCongDinh";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Read;
        private Button btn_Write;
        private RichTextBox rtb_fileContent;
    }
}