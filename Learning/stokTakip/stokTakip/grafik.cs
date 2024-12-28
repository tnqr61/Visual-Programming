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
using System.Xml.Linq;

namespace stokTakip
{
    public partial class grafik : Form
    {
        public string dbName;
        public string conString;
        public grafik()
        {
            InitializeComponent();
            dbName = "stok.db";
            conString = $"Data Source={dbName}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(conString)) { 
                con.Open();
                string query = "SELECT name,stock FROM stok_table ";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                //burayı kaçırma
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {

                    string stok_name = reader["name"].ToString();
                  
                    int stok_adet = int.Parse(reader["stock"].ToString());

                    chart1.Series["Urun"].Points.AddXY(stok_name,stok_adet);
                
                
                }
                MessageBox.Show("Verileri getirme başarılı");
            
            
            
            
            }


        }
    }
}
