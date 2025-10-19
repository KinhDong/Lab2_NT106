namespace Lab2_NT106
{
    partial class Bai4
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
            btn_write = new Button();
            btn_read = new Button();
            tb_writeName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_writeID = new TextBox();
            label3 = new Label();
            tb_writePhone = new TextBox();
            label4 = new Label();
            tb_writeCourse1 = new TextBox();
            label5 = new Label();
            tb_writeCourse2 = new TextBox();
            label6 = new Label();
            tb_writeCourse3 = new TextBox();
            btn_add = new Button();
            label8 = new Label();
            tb_readAverage = new TextBox();
            label9 = new Label();
            tb_readCourse3 = new TextBox();
            label10 = new Label();
            tb_readCourse2 = new TextBox();
            label11 = new Label();
            tb_readCourse1 = new TextBox();
            label12 = new Label();
            tb_readPhone = new TextBox();
            label13 = new Label();
            tb_readID = new TextBox();
            label14 = new Label();
            tb_readName = new TextBox();
            btn_back = new Button();
            btn_next = new Button();
            tb_index = new TextBox();
            SuspendLayout();
            // 
            // rtb_content
            // 
            rtb_content.Location = new Point(357, 24);
            rtb_content.Name = "rtb_content";
            rtb_content.ReadOnly = true;
            rtb_content.Size = new Size(440, 605);
            rtb_content.TabIndex = 0;
            rtb_content.Text = "";
            // 
            // btn_write
            // 
            btn_write.Location = new Point(100, 24);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(139, 34);
            btn_write.TabIndex = 1;
            btn_write.Text = "Write to a file";
            btn_write.UseVisualStyleBackColor = true;
            btn_write.Click += btn_write_Click;
            // 
            // btn_read
            // 
            btn_read.Location = new Point(938, 22);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(112, 34);
            btn_read.TabIndex = 2;
            btn_read.Text = "Read a file";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // tb_writeName
            // 
            tb_writeName.Location = new Point(26, 90);
            tb_writeName.Name = "tb_writeName";
            tb_writeName.ScrollBars = ScrollBars.Horizontal;
            tb_writeName.Size = new Size(150, 31);
            tb_writeName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 93);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 156);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // tb_writeID
            // 
            tb_writeID.Location = new Point(26, 153);
            tb_writeID.Name = "tb_writeID";
            tb_writeID.ScrollBars = ScrollBars.Horizontal;
            tb_writeID.Size = new Size(150, 31);
            tb_writeID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 229);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // tb_writePhone
            // 
            tb_writePhone.Location = new Point(26, 226);
            tb_writePhone.Name = "tb_writePhone";
            tb_writePhone.ScrollBars = ScrollBars.Horizontal;
            tb_writePhone.Size = new Size(150, 31);
            tb_writePhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 298);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 10;
            label4.Text = "Course 1";
            // 
            // tb_writeCourse1
            // 
            tb_writeCourse1.Location = new Point(26, 295);
            tb_writeCourse1.Name = "tb_writeCourse1";
            tb_writeCourse1.ScrollBars = ScrollBars.Horizontal;
            tb_writeCourse1.Size = new Size(150, 31);
            tb_writeCourse1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(239, 369);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 12;
            label5.Text = "Course 2";
            // 
            // tb_writeCourse2
            // 
            tb_writeCourse2.Location = new Point(26, 366);
            tb_writeCourse2.Name = "tb_writeCourse2";
            tb_writeCourse2.ScrollBars = ScrollBars.Horizontal;
            tb_writeCourse2.Size = new Size(150, 31);
            tb_writeCourse2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 439);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 14;
            label6.Text = "Course3";
            // 
            // tb_writeCourse3
            // 
            tb_writeCourse3.Location = new Point(26, 436);
            tb_writeCourse3.Name = "tb_writeCourse3";
            tb_writeCourse3.ScrollBars = ScrollBars.Horizontal;
            tb_writeCourse3.Size = new Size(150, 31);
            tb_writeCourse3.TabIndex = 13;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(113, 595);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 17;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1067, 517);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 31;
            label8.Text = "Average";
            // 
            // tb_readAverage
            // 
            tb_readAverage.Location = new Point(854, 514);
            tb_readAverage.Name = "tb_readAverage";
            tb_readAverage.ReadOnly = true;
            tb_readAverage.ScrollBars = ScrollBars.Horizontal;
            tb_readAverage.Size = new Size(150, 31);
            tb_readAverage.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1067, 439);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 29;
            label9.Text = "Course3";
            // 
            // tb_readCourse3
            // 
            tb_readCourse3.Location = new Point(854, 436);
            tb_readCourse3.Name = "tb_readCourse3";
            tb_readCourse3.ReadOnly = true;
            tb_readCourse3.ScrollBars = ScrollBars.Horizontal;
            tb_readCourse3.Size = new Size(150, 31);
            tb_readCourse3.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1067, 369);
            label10.Name = "label10";
            label10.Size = new Size(82, 25);
            label10.TabIndex = 27;
            label10.Text = "Course 2";
            // 
            // tb_readCourse2
            // 
            tb_readCourse2.Location = new Point(854, 366);
            tb_readCourse2.Name = "tb_readCourse2";
            tb_readCourse2.ReadOnly = true;
            tb_readCourse2.ScrollBars = ScrollBars.Horizontal;
            tb_readCourse2.Size = new Size(150, 31);
            tb_readCourse2.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1067, 298);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 25;
            label11.Text = "Course 1";
            // 
            // tb_readCourse1
            // 
            tb_readCourse1.Location = new Point(854, 295);
            tb_readCourse1.Name = "tb_readCourse1";
            tb_readCourse1.ReadOnly = true;
            tb_readCourse1.ScrollBars = ScrollBars.Horizontal;
            tb_readCourse1.Size = new Size(150, 31);
            tb_readCourse1.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1067, 229);
            label12.Name = "label12";
            label12.Size = new Size(62, 25);
            label12.TabIndex = 23;
            label12.Text = "Phone";
            // 
            // tb_readPhone
            // 
            tb_readPhone.Location = new Point(854, 226);
            tb_readPhone.Name = "tb_readPhone";
            tb_readPhone.ReadOnly = true;
            tb_readPhone.ScrollBars = ScrollBars.Horizontal;
            tb_readPhone.Size = new Size(150, 31);
            tb_readPhone.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1067, 156);
            label13.Name = "label13";
            label13.Size = new Size(30, 25);
            label13.TabIndex = 21;
            label13.Text = "ID";
            // 
            // tb_readID
            // 
            tb_readID.Location = new Point(854, 153);
            tb_readID.Name = "tb_readID";
            tb_readID.ReadOnly = true;
            tb_readID.ScrollBars = ScrollBars.Horizontal;
            tb_readID.Size = new Size(150, 31);
            tb_readID.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1067, 93);
            label14.Name = "label14";
            label14.Size = new Size(59, 25);
            label14.TabIndex = 19;
            label14.Text = "Name";
            // 
            // tb_readName
            // 
            tb_readName.Location = new Point(854, 90);
            tb_readName.Name = "tb_readName";
            tb_readName.ReadOnly = true;
            tb_readName.ScrollBars = ScrollBars.Horizontal;
            tb_readName.Size = new Size(150, 31);
            tb_readName.TabIndex = 18;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(826, 595);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 34);
            btn_back.TabIndex = 32;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(1054, 595);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(112, 34);
            btn_next.TabIndex = 33;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // tb_index
            // 
            tb_index.Location = new Point(972, 598);
            tb_index.Name = "tb_index";
            tb_index.ReadOnly = true;
            tb_index.Size = new Size(51, 31);
            tb_index.TabIndex = 34;
            tb_index.TextAlign = HorizontalAlignment.Center;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 651);
            Controls.Add(tb_index);
            Controls.Add(btn_next);
            Controls.Add(btn_back);
            Controls.Add(label8);
            Controls.Add(tb_readAverage);
            Controls.Add(label9);
            Controls.Add(tb_readCourse3);
            Controls.Add(label10);
            Controls.Add(tb_readCourse2);
            Controls.Add(label11);
            Controls.Add(tb_readCourse1);
            Controls.Add(label12);
            Controls.Add(tb_readPhone);
            Controls.Add(label13);
            Controls.Add(tb_readID);
            Controls.Add(label14);
            Controls.Add(tb_readName);
            Controls.Add(btn_add);
            Controls.Add(label6);
            Controls.Add(tb_writeCourse3);
            Controls.Add(label5);
            Controls.Add(tb_writeCourse2);
            Controls.Add(label4);
            Controls.Add(tb_writeCourse1);
            Controls.Add(label3);
            Controls.Add(tb_writePhone);
            Controls.Add(label2);
            Controls.Add(tb_writeID);
            Controls.Add(label1);
            Controls.Add(tb_writeName);
            Controls.Add(btn_read);
            Controls.Add(btn_write);
            Controls.Add(rtb_content);
            Name = "Bai4";
            Text = "Bai4_24520303_BuiCongDinh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_content;
        private Button btn_write;
        private Button btn_read;
        private TextBox tb_writeName;
        private Label label1;
        private Label label2;
        private TextBox tb_writeID;
        private Label label3;
        private TextBox tb_writePhone;
        private Label label4;
        private TextBox tb_writeCourse1;
        private Label label5;
        private TextBox tb_writeCourse2;
        private Label label6;
        private TextBox tb_writeCourse3;
        private Button btn_add;
        private Label label8;
        private TextBox tb_readAverage;
        private Label label9;
        private TextBox tb_readCourse3;
        private Label label10;
        private TextBox tb_readCourse2;
        private Label label11;
        private TextBox tb_readCourse1;
        private Label label12;
        private TextBox tb_readPhone;
        private Label label13;
        private TextBox tb_readID;
        private Label label14;
        private TextBox tb_readName;
        private Button btn_back;
        private Button btn_next;
        private TextBox tb_index;
    }
}