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
    public partial class listForm : Form
    {
        public string dbName;
        public string conString;
        public listForm()
        {
            InitializeComponent();
            dbName = "stok.db";
            conString = $"Data Source={dbName}";

        }

        private void listForm_Load(object sender, EventArgs e)
        {
            LoadInfoToDataSet();
            

        }
        private void LoadInfoToDataSet()
        {

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    con.Open();
                    string query = "SELECT * FROM stok_table";

                    // DataAdapter oluştur
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, con);

                    // DataSet'i doldur
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "stok_table");

                    dataGridView1.DataSource = ds.Tables["stok_table"];

                    // DataGridView'e tabloyu bağla
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yükleme sırasında bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                try
                {
                    using(SQLiteConnection con = new SQLiteConnection(conString))
                    {
                        con.Open();
                        string query = @"DELETE FROM stok_table WHERE id = @id";
                        SQLiteCommand command = new SQLiteCommand(query, con);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                
                }

            }

        }

      
    }
}
