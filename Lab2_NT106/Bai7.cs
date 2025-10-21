using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_NT106
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                TreeNode node = new TreeNode(drive);
                node.Tag = drive;
                node.Nodes.Add("..."); // dummy để có dấu +
                treev_tree.Nodes.Add(node);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();

            string path = node.Tag.ToString();

            try
            {
                // Thư mục con
                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode dirNode = new TreeNode(Path.GetFileName(dir));
                    dirNode.Tag = dir;
                    dirNode.Nodes.Add("...");
                    node.Nodes.Add(dirNode);
                }

                // File
                foreach (string file in Directory.GetFiles(path))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    fileNode.Tag = file;
                    node.Nodes.Add(fileNode);
                }
            }
            catch { }
        }

        private void treev_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            if (File.Exists(path))
            {
                string ext = Path.GetExtension(path).ToLower();

                if (ext == ".jpg" || ext == ".png")
                {
                    // Hiển thị ảnh
                    pic_fileContext.Visible = true;
                    rtb_fileContext.Visible = false;
                    try
                    {
                        pic_fileContext.Image = Image.FromFile(path);
                    }
                    catch
                    {
                        pic_fileContext.Image = null;
                        MessageBox.Show("Không thể hiển thị ảnh.");
                    }
                }
                else if (ext == ".txt" || ext == ".cs" || ext == ".doc")
                {
                    // Hiển thị text
                    pic_fileContext.Visible = false;
                    rtb_fileContext.Visible = true;
                    try
                    {
                        rtb_fileContext.Text = File.ReadAllText(path);
                    }
                    catch
                    {
                        rtb_fileContext.Text = "Không thể đọc file.";
                    }
                }
                else
                {                                   
                }
            }
        }        
    }
}
