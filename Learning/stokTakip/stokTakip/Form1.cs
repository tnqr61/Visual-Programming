using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace stokTakip
{
    public partial class Form1 : Form
    {
        public string dbName;
        public string conString;
        public Form1()
        {
            InitializeComponent();
            dbName = "stok.db";
            conString = $"Data Source={dbName}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDatabase();


        }
        private void CreateDatabase() {
            if (!File.Exists(dbName)) 
                SQLiteConnection.CreateFile(dbName);

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    con.Open();
                    string query = "CREATE TABLE IF NOT EXISTS stok_table(id INTEGER AUTO INCREMENT,name TEXT NOT NULL,stock DOUBLE NOT NULL )";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();


                }

            }
            catch (Exception ex) {
                MessageBox.Show("database oluşturulurken hata:" + ex.Message);
            }
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(stokAdet.Text) || string.IsNullOrEmpty(stokName.Text))
                MessageBox.Show("bunlar boş karşim");
            else
            {
                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(conString)) { 
                        con.Open();
                        string query = @"INSERT INTO stok_table(name,stock) VALUES(@name,@stok)";

                        SQLiteCommand cmd = new SQLiteCommand(query,con);
                        cmd.Parameters.AddWithValue("@name", stokName.Text); 
                        double stokadet= double.Parse(stokAdet.Text);
                        cmd.Parameters.AddWithValue("@stok", stokadet);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla eklendi");



                    }

                }
                catch (Exception ex) {
                    MessageBox.Show("ürün eklenirken hata:"+ex.Message);
                
                
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form grafikForm = new grafik();
            this.Hide();
            grafikForm.Show();


        }
    }
}
