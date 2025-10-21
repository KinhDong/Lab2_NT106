using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_NT106
{
    public struct Film
    {
        public string Name; // Tên phim
        public double standardPrice; // Giá chuẩn
        public List<int> rooms; // Danh sách các phòng chiếu
        public List<List<List<string>>> seats; // Chỗ chưa có người mua
        public int numOfTickets; // Số vé ban đầu
        public int numOfSoldTickets; // Số vé đã bán
        public int numOfTicketsLeft; // Sô vé còn lại
        public double revenue; // Doanh thu

        public Film(string _Name, string _Price, string _rooms, 
            string _numOfTickets)
        {            
            Name = _Name;
            
            standardPrice = double.Parse(_Price);
            
            rooms = new List<int>();
            string room = "";
            foreach (char r  in _rooms)
            {                
                if(r == ' ')
                {
                    rooms.Add(int.Parse(room));
                    room = "";
                }

                else room += r;
            }
            rooms.Add(int.Parse(room));

            seats = new List<List<List<string>>> ();
            for(int i1 = 0; i1 < rooms.Count; i1++)
            {
                seats.Add(new List<List<string>>());
                seats[i1].Add(new List<string> { "A1", "A5", "C1", "C5" });
                seats[i1].Add(new List<string> { "A2", "A3", "A4", "C2", "C3", "C4" });
                seats[i1].Add(new List<string> { "B2", "B3", "B4" });
            }

            numOfTickets = int.Parse(_numOfTickets);

            numOfSoldTickets = 0;
            numOfTicketsLeft = numOfTickets;
            revenue = 0;
        }
    }

    public partial class Bai5 : Form
    {
        List<Film> filmList = new List<Film>();
        public Bai5()
        {
            InitializeComponent();
        }

        private void clearInfo()
        {
            tb_customName.Text = String.Empty;
            cb_filmName.Text = String.Empty;
            cb_rooms.Text = String.Empty;
            cb_rooms.Items.Clear();
            cb_ticketClass.Text = String.Empty;
            cb_seat.Text = String.Empty;
            cb_seat.Items.Clear();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            filmList.Clear();
            clearInfo();
            rtb_customInfo.Text = String.Empty;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {                
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        while (!sr.EndOfStream)
                        {
                            Film f = new Film(sr.ReadLine(), sr.ReadLine(),
                                sr.ReadLine(), sr.ReadLine());
                            filmList.Add(f);
                        }
                    }

                    MessageBox.Show("Đọc file thành công!");

                    for (int i = 0; i < filmList.Count; i++)
                    {
                        cb_filmName.Items.Add(filmList[i].Name);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đọc file: {ex.Message}");
                    return;
                }
            }
        }

        private void cb_filmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_filmName.SelectedIndex;
            cb_rooms.Items.Clear();
            foreach (int r in filmList[index].rooms)
            {
                cb_rooms.Items.Add(r);
            }
        }

        private void cb_ticketClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_filmName.SelectedIndex == -1) return;
            if (cb_rooms.SelectedIndex == -1) return;

            cb_seat.Items.Clear();
            int filmIndex = cb_filmName.SelectedIndex;
            int roomIndex = cb_rooms.SelectedIndex;
            int classIndex = cb_ticketClass.SelectedIndex;

            foreach (string s in filmList[filmIndex].seats[roomIndex][classIndex])
            {
                cb_seat.Items.Add(s);
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (tb_customName.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }

            if (cb_filmName.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim");
                return;
            }

            if (cb_rooms.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu");
                return;
            }

            if (cb_ticketClass.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hạn mức vé");
                return;
            }

            if (cb_seat.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chỗ ngồi");
                return;
            }

            int filmIndex = cb_filmName.SelectedIndex;
            int classIndex = cb_ticketClass.SelectedIndex;
            double price = filmList[filmIndex].standardPrice;
            if (classIndex == 0) price /= 4;
            else
            {
                if (classIndex == 2) price *= 2;
            }

            rtb_customInfo.Text +=
                $"Tên khách hàng: {tb_customName.Text}{Environment.NewLine}" +
                $"Loại vé: {cb_ticketClass.SelectedItem}{Environment.NewLine}" +
                $"Tên phim: {cb_filmName.SelectedItem}{Environment.NewLine}" +
                $"Phòng chiếu: {cb_rooms.SelectedItem}{Environment.NewLine}" +
                $"Cái giá phải trả: {price}{Environment.NewLine}" +
                $"{Environment.NewLine}";

            var temp = filmList[filmIndex];
            temp.numOfSoldTickets++;
            temp.numOfTicketsLeft--;
            temp.revenue += price;
            filmList[filmIndex] = temp;
            filmList[filmIndex].seats[cb_rooms.SelectedIndex][classIndex].RemoveAt(cb_seat.SelectedIndex);

            clearInfo();
        }

        private async void btn_write_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var filmIndexList = new (double, int)[filmList.Count];

                for(int i = 0; i < filmList.Count; i++)
                {                    
                    filmIndexList[i].Item1 = filmList[i].revenue;
                    filmIndexList[i].Item2 = i;
                }

                Array.Sort(filmIndexList);

                try
                {
                    using (StreamWriter sw = new StreamWriter(ofd.FileName))
                    {
                        pb_progress.Minimum = 0;
                        pb_progress.Maximum = filmIndexList.Length;
                        pb_progress.Value = 0;


                        for(int i = filmIndexList.Length - 1; i >= 0; i--)
                        {
                            int index = filmIndexList[i].Item2;
                            sw.WriteLine($"Tên phim: { filmList[index].Name}");
                            sw.WriteLine($"Số vé bán ra: { filmList[index].numOfSoldTickets }");
                            sw.WriteLine($"Số vé tồn: {filmList[index].numOfTicketsLeft}");
                            sw.WriteLine($"Tỉ lệ vé bán ra: {1.0 * filmList[index].numOfSoldTickets / filmList[index].numOfTickets}");
                            sw.WriteLine($"Doanh thu: {filmList[index].revenue}");
                            sw.WriteLine($"Thứ hạng: {filmIndexList.Length - i}{Environment.NewLine}");

                            pb_progress.Value++;
                            await Task.Delay(5);
                        }

                        MessageBox.Show("Ghi file thành công!");
                        pb_progress.Value = 0;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ghi file: {ex.Message}");
                    return;
                }
            }
        }
    }
}
