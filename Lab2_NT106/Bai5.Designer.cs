namespace Lab2_NT106
{
    partial class Bai5
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
            btn_read = new Button();
            btn_write = new Button();
            groupBox1 = new GroupBox();
            tb_customName = new TextBox();
            label6 = new Label();
            btn_buy = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cb_seat = new ComboBox();
            cb_ticketClass = new ComboBox();
            cb_rooms = new ComboBox();
            cb_filmName = new ComboBox();
            rtb_customInfo = new RichTextBox();
            label1 = new Label();
            pb_progress = new ProgressBar();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_read
            // 
            btn_read.Location = new Point(45, 52);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(134, 34);
            btn_read.TabIndex = 0;
            btn_read.Text = "Đọc thông tin";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_write
            // 
            btn_write.Location = new Point(45, 159);
            btn_write.Name = "btn_write";
            btn_write.Size = new Size(134, 34);
            btn_write.TabIndex = 1;
            btn_write.Text = "Ghi thông tin";
            btn_write.UseVisualStyleBackColor = true;
            btn_write.Click += btn_write_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_customName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btn_buy);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cb_seat);
            groupBox1.Controls.Add(cb_ticketClass);
            groupBox1.Controls.Add(cb_rooms);
            groupBox1.Controls.Add(cb_filmName);
            groupBox1.Location = new Point(228, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 561);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mua vé";
            // 
            // tb_customName
            // 
            tb_customName.Location = new Point(215, 78);
            tb_customName.Name = "tb_customName";
            tb_customName.Size = new Size(182, 31);
            tb_customName.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 81);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 9;
            label6.Text = "Nhập tên của bạn";
            // 
            // btn_buy
            // 
            btn_buy.Location = new Point(154, 497);
            btn_buy.Name = "btn_buy";
            btn_buy.Size = new Size(112, 34);
            btn_buy.TabIndex = 8;
            btn_buy.Text = "Mua";
            btn_buy.UseVisualStyleBackColor = true;
            btn_buy.Click += btn_buy_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 408);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 7;
            label5.Text = "Chỗ ngồi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 328);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 6;
            label4.Text = "Hạn mức";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 246);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 5;
            label3.Text = "Phòng chiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 162);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 4;
            label2.Text = "Tên phim";
            // 
            // cb_seat
            // 
            cb_seat.FormattingEnabled = true;
            cb_seat.Location = new Point(215, 405);
            cb_seat.Name = "cb_seat";
            cb_seat.Size = new Size(182, 33);
            cb_seat.TabIndex = 3;
            // 
            // cb_ticketClass
            // 
            cb_ticketClass.FormattingEnabled = true;
            cb_ticketClass.Items.AddRange(new object[] { "Vé vớt", "Vé thường", "Vé VIP" });
            cb_ticketClass.Location = new Point(215, 325);
            cb_ticketClass.Name = "cb_ticketClass";
            cb_ticketClass.Size = new Size(182, 33);
            cb_ticketClass.TabIndex = 2;
            cb_ticketClass.SelectedIndexChanged += cb_ticketClass_SelectedIndexChanged;
            // 
            // cb_rooms
            // 
            cb_rooms.FormattingEnabled = true;
            cb_rooms.Location = new Point(215, 243);
            cb_rooms.Name = "cb_rooms";
            cb_rooms.Size = new Size(182, 33);
            cb_rooms.TabIndex = 1;
            // 
            // cb_filmName
            // 
            cb_filmName.FormattingEnabled = true;
            cb_filmName.Location = new Point(215, 159);
            cb_filmName.Name = "cb_filmName";
            cb_filmName.Size = new Size(182, 33);
            cb_filmName.TabIndex = 0;
            cb_filmName.SelectedIndexChanged += cb_filmName_SelectedIndexChanged;
            // 
            // rtb_customInfo
            // 
            rtb_customInfo.Location = new Point(728, 70);
            rtb_customInfo.Name = "rtb_customInfo";
            rtb_customInfo.ReadOnly = true;
            rtb_customInfo.Size = new Size(427, 530);
            rtb_customInfo.TabIndex = 3;
            rtb_customInfo.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(728, 29);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 4;
            label1.Text = "Thông tin khách hàng";
            // 
            // pb_progress
            // 
            pb_progress.Location = new Point(45, 246);
            pb_progress.Name = "pb_progress";
            pb_progress.Size = new Size(150, 34);
            pb_progress.TabIndex = 5;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 639);
            Controls.Add(pb_progress);
            Controls.Add(label1);
            Controls.Add(rtb_customInfo);
            Controls.Add(groupBox1);
            Controls.Add(btn_write);
            Controls.Add(btn_read);
            Name = "Bai5";
            Text = "Bai5_24520303_BuiCongDinh";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_read;
        private Button btn_write;
        private GroupBox groupBox1;
        private Button btn_buy;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cb_seat;
        private ComboBox cb_ticketClass;
        private ComboBox cb_rooms;
        private ComboBox cb_filmName;
        private RichTextBox rtb_customInfo;
        private Label label1;
        private TextBox tb_customName;
        private Label label6;
        private ProgressBar pb_progress;
    }
}