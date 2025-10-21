namespace Lab2_NT106
{
    partial class Bai7
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
            treev_tree = new TreeView();
            rtb_fileContext = new RichTextBox();
            label1 = new Label();
            pic_fileContext = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_fileContext).BeginInit();
            SuspendLayout();
            // 
            // treev_tree
            // 
            treev_tree.Location = new Point(39, 33);
            treev_tree.Name = "treev_tree";
            treev_tree.Size = new Size(360, 510);
            treev_tree.TabIndex = 0;
            treev_tree.BeforeExpand += new TreeViewCancelEventHandler(treeView1_BeforeExpand);
            treev_tree.AfterSelect += new TreeViewEventHandler(treev_tree_AfterSelect);
            // 
            // rtb_fileContext
            // 
            rtb_fileContext.Location = new Point(435, 64);
            rtb_fileContext.Name = "rtb_fileContext";
            rtb_fileContext.ReadOnly = true;
            rtb_fileContext.Size = new Size(539, 479);
            rtb_fileContext.TabIndex = 1;
            rtb_fileContext.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 2;
            label1.Text = "File Context";
            // 
            // pic_fileContext
            // 
            pic_fileContext.Location = new Point(435, 64);
            pic_fileContext.Name = "pic_fileContext";
            pic_fileContext.Size = new Size(539, 479);
            pic_fileContext.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_fileContext.TabIndex = 3;
            pic_fileContext.TabStop = false;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 576);
            Controls.Add(pic_fileContext);
            Controls.Add(label1);
            Controls.Add(rtb_fileContext);
            Controls.Add(treev_tree);
            Name = "Bai7";
            Text = "Bai7_24520303_BuiCongDinh";
            Load += Bai7_Load;
            ((System.ComponentModel.ISupportInitialize)pic_fileContext).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treev_tree;
        private RichTextBox rtb_fileContext;
        private Label label1;
        private PictureBox pic_fileContext;
    }
}