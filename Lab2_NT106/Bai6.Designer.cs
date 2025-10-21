namespace Lab2_NT106
{
    partial class Bai6
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
            groupBox1 = new GroupBox();
            tb_foodImageAdded = new TextBox();
            label5 = new Label();
            btn_addImage = new Button();
            btn_add = new Button();
            label2 = new Label();
            label1 = new Label();
            tb_contributorNameAdded = new TextBox();
            tb_foodNameAdded = new TextBox();
            pic_foodImageFound = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            tb_contributorNameFound = new TextBox();
            tb_foodNameFound = new TextBox();
            btn_findFoods = new Button();
            listv_foodList = new ListView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_foodImageFound).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_foodImageAdded);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btn_addImage);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_contributorNameAdded);
            groupBox1.Controls.Add(tb_foodNameAdded);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 267);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm món ăn";
            // 
            // tb_foodImageAdded
            // 
            tb_foodImageAdded.Location = new Point(178, 165);
            tb_foodImageAdded.Name = "tb_foodImageAdded";
            tb_foodImageAdded.ReadOnly = true;
            tb_foodImageAdded.Size = new Size(200, 31);
            tb_foodImageAdded.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 168);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 12;
            label5.Text = "Hình ảnh";
            // 
            // btn_addImage
            // 
            btn_addImage.Location = new Point(40, 217);
            btn_addImage.Name = "btn_addImage";
            btn_addImage.Size = new Size(146, 34);
            btn_addImage.TabIndex = 11;
            btn_addImage.Text = "Thêm hình ảnh";
            btn_addImage.UseVisualStyleBackColor = true;
            btn_addImage.Click += btn_addImage_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(239, 217);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(139, 34);
            btn_add.TabIndex = 10;
            btn_add.Text = "Thêm món ăn";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 106);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 8;
            label2.Text = "Tên món ăn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 7;
            label1.Text = "Tên của bạn";
            // 
            // tb_contributorNameAdded
            // 
            tb_contributorNameAdded.Location = new Point(178, 44);
            tb_contributorNameAdded.Name = "tb_contributorNameAdded";
            tb_contributorNameAdded.Size = new Size(200, 31);
            tb_contributorNameAdded.TabIndex = 5;
            // 
            // tb_foodNameAdded
            // 
            tb_foodNameAdded.Location = new Point(178, 103);
            tb_foodNameAdded.Name = "tb_foodNameAdded";
            tb_foodNameAdded.Size = new Size(200, 31);
            tb_foodNameAdded.TabIndex = 4;
            // 
            // pic_foodImageFound
            // 
            pic_foodImageFound.Location = new Point(622, 142);
            pic_foodImageFound.Name = "pic_foodImageFound";
            pic_foodImageFound.Size = new Size(338, 281);
            pic_foodImageFound.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_foodImageFound.TabIndex = 3;
            pic_foodImageFound.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 469);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 8;
            label3.Text = "Tên người đóng góp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(577, 527);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 9;
            label4.Text = "Tên món ăn";
            // 
            // tb_contributorNameFound
            // 
            tb_contributorNameFound.Location = new Point(776, 466);
            tb_contributorNameFound.Name = "tb_contributorNameFound";
            tb_contributorNameFound.ReadOnly = true;
            tb_contributorNameFound.Size = new Size(200, 31);
            tb_contributorNameFound.TabIndex = 11;
            // 
            // tb_foodNameFound
            // 
            tb_foodNameFound.Location = new Point(776, 524);
            tb_foodNameFound.Name = "tb_foodNameFound";
            tb_foodNameFound.ReadOnly = true;
            tb_foodNameFound.Size = new Size(200, 31);
            tb_foodNameFound.TabIndex = 10;
            // 
            // btn_findFoods
            // 
            btn_findFoods.Location = new Point(712, 54);
            btn_findFoods.Name = "btn_findFoods";
            btn_findFoods.Size = new Size(136, 34);
            btn_findFoods.TabIndex = 12;
            btn_findFoods.Text = "Tìm món ăn";
            btn_findFoods.UseVisualStyleBackColor = true;
            btn_findFoods.Click += btn_findFoods_Click;
            // 
            // listv_foodList
            // 
            listv_foodList.Location = new Point(30, 309);
            listv_foodList.Name = "listv_foodList";
            listv_foodList.Size = new Size(428, 246);
            listv_foodList.TabIndex = 13;
            listv_foodList.UseCompatibleStateImageBehavior = false;
            listv_foodList.View = View.List;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 581);
            Controls.Add(listv_foodList);
            Controls.Add(btn_findFoods);
            Controls.Add(tb_contributorNameFound);
            Controls.Add(tb_foodNameFound);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pic_foodImageFound);
            Controls.Add(groupBox1);
            Name = "Bai6";
            Text = "Bai6_24520303_BuiCongDinh";
            Load += Bai6_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_foodImageFound).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox tb_contributorNameAdded;
        private TextBox tb_foodNameAdded;
        private Button btn_addImage;
        private Button btn_add;
        private Label label2;
        private Label label1;
        private PictureBox pic_foodImageFound;
        private Label label3;
        private Label label4;
        private TextBox tb_contributorNameFound;
        private TextBox tb_foodNameFound;
        private Button btn_findFoods;
        private TextBox tb_foodImageAdded;
        private Label label5;
        private ListView listv_foodList;
    }
}