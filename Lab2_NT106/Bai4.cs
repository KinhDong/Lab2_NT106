using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_NT106
{
    public struct Student
    {
        public string Name;
        public int ID;
        public string Phone;
        public float Course1, Course2, Course3;
        public float Average;
    }

    public partial class Bai4 : Form
    {
        List<Student> students = new List<Student>();

        public Bai4()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int numInt = 0;
            if (tb_writeID.Text.Length != 8 || !int.TryParse(tb_writeID.Text, out numInt))
            {
                MessageBox.Show("ID sai định dạng!");
                return;
            }

            if (tb_writePhone.Text.Length != 10 || tb_writePhone.Text[0] != '0' ||
                !int.TryParse(tb_writePhone.Text, out numInt))
            {
                MessageBox.Show("Số điện thoại sai định dạng!");
                return;
            }

            float numFloat = 0;
            if (!float.TryParse(tb_writeCourse1.Text, out numFloat) ||
                !float.TryParse(tb_writeCourse2.Text, out numFloat) ||
                !float.TryParse(tb_writeCourse3.Text, out numFloat))
            {
                MessageBox.Show("Điểm sai định dạng!");
                return;
            }

            Student a = new Student();
            a.Name = tb_writeName.Text;
            a.ID = int.Parse(tb_writeID.Text);
            a.Phone = tb_writePhone.Text;
            a.Course1 = float.Parse(tb_writeCourse1.Text, CultureInfo.InvariantCulture);
            a.Course2 = float.Parse(tb_writeCourse2.Text, CultureInfo.InvariantCulture);
            a.Course3 = float.Parse(tb_writeCourse3.Text, CultureInfo.InvariantCulture);
            a.Average = (a.Course1 + a.Course2 + a.Course3) / 3;

            students.Add(a);
            MessageBox.Show("Thêm thành công");
        }

        private void writeToFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BinaryWriter bw = new BinaryWriter(File.Open(ofd.FileName, FileMode.Create)))
                    {
                        bw.Write(students.Count);
                        foreach (Student s in students)
                        {
                            bw.Write(s.Name);
                            bw.Write(s.ID);
                            bw.Write(s.Phone);
                            bw.Write(s.Course1);
                            bw.Write(s.Course2);
                            bw.Write(s.Course3);
                            bw.Write(s.Average);
                        }

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ghi file: {ex.Message}");
                }
            }
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            writeToFile();
        }

        private void showInfo(int index)
        {
            tb_readName.Text = students[index].Name;
            tb_readID.Text = students[index].ID.ToString();
            tb_readPhone.Text = students[index].Phone;
            tb_readCourse1.Text = students[index].Course1.ToString();
            tb_readCourse2.Text = students[index].Course2.ToString();
            tb_readCourse3.Text = students[index].Course3.ToString();
            tb_readAverage.Text = students[index].Average.ToString();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    students.Clear();
                    string content = "";
                 
                    using (BinaryReader br = new BinaryReader(File.Open(ofd.FileName, FileMode.Open)))
                    {
                        int length = br.ReadInt32();

                        for (int i = 0; i < length; i++)
                        {
                            Student student = new Student();
                            student.Name = br.ReadString();
                            student.ID = br.ReadInt32();
                            student.Phone = br.ReadString();
                            student.Course1 = br.ReadSingle();
                            student.Course2 = br.ReadSingle();
                            student.Course3 = br.ReadSingle();
                            student.Average = br.ReadSingle();

                            content +=
                                $"{student.Name}{Environment.NewLine}" +
                                $"{student.ID}{Environment.NewLine}" +
                                $"{student.Phone}{Environment.NewLine}" +
                                $"{student.Course1}{Environment.NewLine}" +
                                $"{student.Course2}{Environment.NewLine}" +
                                $"{student.Course3}{Environment.NewLine}" +
                                $"{student.Average}{Environment.NewLine}" +
                                $"{Environment.NewLine}";

                            students.Add(student);
                        }                        
                    }

                    rtb_content.Text = content;

                    tb_index.Text = "0";
                    if (students.Count > 0)
                    {
                        showInfo(0);
                    }

                    MessageBox.Show("Đọc file thành công!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đọc file: {ex.Message}");
                    return;
                }
            }

            writeToFile();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int index = int.Parse(tb_index.Text);
            if (index + 1 < students.Count)
            {
                tb_index.Text = (index + 1).ToString();
                showInfo(index + 1);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int index = int.Parse (tb_index.Text);
            if(index >= 1)
            {
                tb_index.Text = (index - 1).ToString();
                showInfo(index - 1);
            }
        }
    }
}
