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
                        listv_foodList.Items.Add(reader["FOODNAME"].ToString());                    
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
            if (tb_contributorNameAdded.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên của bạn!");
                return;
            }

            if (tb_foodImageAdded.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
                return;
            }

            if (tb_foodImageAdded.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng thêm ảnh!");
                return;
            }

            using (var conn = new SqliteConnection(connectToDBString))
            {
                conn.Open();

                string sql = "INSERT INTO FOOD (CONTRIBUTORNAME, FOODNAME, FOODIMAGEPATH) VALUES (@contributorName, @foodName, @foodImagePath)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@contributorName", $"{tb_contributorNameAdded.Text}");
                    cmd.Parameters.AddWithValue("@foodName", $"{tb_foodNameAdded.Text}");
                    cmd.Parameters.AddWithValue("@foodImagePath", $"{tb_foodImageAdded.Text}");
                    cmd.ExecuteNonQuery();
                }
            }

            //rtb_foodsList.Text += tb_foodNameAdded.Text + Environment.NewLine;

            MessageBox.Show("Thêm thành công!");
        }

        private void btn_findFoods_Click(object sender, EventArgs e)
        {
            using (var conn = new SqliteConnection(connectToDBString))
            {
                conn.Open();

                int numOfFoods = 0;

                string sql = "SELECT COUNT (*) FROM FOOD";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    numOfFoods = Int32.Parse(cmd.ExecuteScalar().ToString());
                    numOfFoods++;
                }

                Random ran = new Random();
                int randomFood = ran.Next(numOfFoods);

                sql = "SELECT CONTRIBUTORNAME, FOODNAME, FOODIMAGEPATH FROM FOOD WHERE ID = @id";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", randomFood);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            tb_contributorNameFound.Text = reader["CONTRIBUTORNAME"].ToString();
                            tb_foodNameFound.Text = reader["FOODNAME"].ToString() ;
                            pic_foodImageFound.Image = Image.FromFile(reader["FOODIMAGEPATH"].ToString());
                        }
                    }
                }
            }
        }
    }
}
