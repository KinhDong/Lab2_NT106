using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_NT106
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            string content = "";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(ofd.FileName))
                    {
                        content = reader.ReadToEnd();
                    }
                }
                catch
                {
                    MessageBox.Show($"Lỗi đọc file");
                    return;
                }

                rtb_fileContent.Text = content;
            }                        
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            string content = rtb_fileContent.Text;
            content = content.ToUpper();

            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Tạo StreamWriter và ghi file
                    using (StreamWriter writer = new StreamWriter(ofd.FileName))
                    {
                        writer.Write(content);
                    }

                    MessageBox.Show("Ghi file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ghi file: {ex.Message}");
                }
            }            
        }
    }
}
