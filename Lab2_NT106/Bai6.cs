using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_NT106
{

    public partial class Bai6 : Form
    {
        string connectToDBString = @"Data Source=D:\Project\LapTrinhMAng\Lab2_NT106\Lab2_NT106\Database\Bai2\.FOOD.db;";
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            using (var conn = new SqliteConnection(connectToDBString))
            {
                conn.Open();

                string sql = "SELECT FOODNAME FROM FOOD";
                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rtb_foodsList.Text += reader["FOODNAME"].ToString() +
                            Environment.NewLine;
                    }
                }
            }
        }

        private void btn_addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb_foodImageAdded.Text = ofd.FileName;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_contributorNameAdded.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên của bạn!");
                return;
            }

            if(tb_foodImageAdded.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
                return;
            }

            using (var conn = new SqliteConnection(connectToDBString))
            {
                conn.Open();
                
                string sql = "INSERT INTO FOOD (CONTRIBUTORNAME, FOODNAME) VALUES (@contributorName, @foodName)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@contributorName", $"{tb_contributorNameAdded.Text}");

                }
            }
        }
    }

    public struct Food
    {
        public int ID;
        public string ContributorName;
        public string FoodName;
        public string FoodImagePath;
    }
}
