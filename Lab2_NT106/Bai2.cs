using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_NT106
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private int CountWordsBasic(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            // Tách bằng khoảng trắng và loại bỏ các phần tử rỗng
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' },
                                      StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string content = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = ofd.FileName;

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        content = reader.ReadToEnd();
                        rtb_FileContent.Text = content;
                    }

                    MessageBox.Show($"Đã đọc file: {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đọc file: {ex.Message}");
                    return;
                }
            }

            tb_FileName.Text = ofd.SafeFileName;

            FileInfo fi = new FileInfo(ofd.FileName);
            if (fi.Exists)
            {
                long FileSize = fi.Length;
                tb_Size.Text = $"{FileSize.ToString()} bytes";
            }

            tb_URL.Text = ofd.FileName;
            tb_LinesCount.Text = File.ReadLines(ofd.FileName).Count().ToString();
            tb_WordsCount.Text = CountWordsBasic(content).ToString();
            tb_CharactersCount.Text = content.Length.ToString();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
