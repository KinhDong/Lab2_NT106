using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_NT106
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_readFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        rtb_content.Text = sr.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đọc file: {ex.Message}");
                }
            }
        }

        // Xác định độ ưu tiên toán tử
        int precedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return -1;
        }

        // Chuyển từ biểu thức trung tố sang hậu tố
        List<string> stringToPostfix(string s)
        {
            s = '0' + s;
            List<string> res = new List<string>();
            Stack<char> st = new Stack<char>();
            string num = "";

            foreach (char c in s)
            {
                if (c == ' ') continue;

                // Lấy số
                if (c == '.' || c - '0' <= 9 && c - '0' >= 0) num += c;

                else
                {
                    // Đưa số vào res                    
                    res.Add(num);
                    num = "";

                    if (c == '(') st.Push(c);

                    else if (c == ')')
                    {
                        while (st.Peek() != '(')
                        {
                            res.Add(st.Pop().ToString());
                        }
                        st.Pop();
                    }

                    else
                    {
                        while (st.Count > 0 &&
                            precedence(st.Peek()) >= precedence(c))
                        {
                            res.Add(st.Pop().ToString());
                        }
                        st.Push(c);
                    }
                }
            }

            // Thêm số cuối cùng của chuỗi
            if (num != "") res.Add(num);

            while (st.Count > 0)
            {
                res.Add(st.Pop().ToString());
            }

            return res;
        }

        // Tính biểu thức hậu tố
        double caculatePostfix(List<string> ls)
        {
            Stack<double> nums = new Stack<double>();

            foreach (string s in ls) 
            {
                if (s == "+") nums.Push(nums.Pop() + nums.Pop());
                else if (s == "-") nums.Push(- nums.Pop() + nums.Pop());
                else if (s == "*") nums.Push(nums.Pop() * nums.Pop());
                else if (s == "/") nums.Push(1 / nums.Pop() * nums.Pop());
                else nums.Push(double.Parse(s, CultureInfo.InvariantCulture));
            }

            return nums.Peek();
        }

        private void btn_caculateAndWrite_Click(object sender, EventArgs e)
        {
            List<string> content = rtb_content.Lines.ToList();

            for(int i = 0; i < content.Count; i++)
            {
                content[i] += $" = {caculatePostfix(stringToPostfix(content[i]))}";
            }

            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(ofd.FileName))
                    {
                        for(int i = 0; i < content.Count; i++)
                        {
                            sw.WriteLine(content[i]);
                        }
                    }

                    MessageBox.Show("Ghi file thành công");
                }

                catch(Exception ex) 
                {
                    MessageBox.Show($"Lỗi ghi file: {ex.Message}");
                }
            }
        }
    }
}
