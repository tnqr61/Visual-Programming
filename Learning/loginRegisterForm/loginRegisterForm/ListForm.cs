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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginRegisterForm
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void getUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.conString);
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Form1.conString))
                {
                    conn.Open();
                    string query = "SELECT *FROM user_table";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) { 
                        ListViewItem item = new ListViewItem(reader["Id"].ToString()); 
                        item.SubItems.Add(reader["name"].ToString());
                        item.SubItems.Add(reader["email"].ToString());
                        item.SubItems.Add(reader["password"].ToString());
                        listView1.Items.Add(item);
                        
                       
                    
                    }
                   
                }

            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }

        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            int selectedUserID = -1;
            if (listView1.SelectedItems.Count > 0)
            { 
                foreach(ListViewItem item in listView1.SelectedItems)
                {
                    selectedUserID = int.Parse(item.SubItems[0].Text);
                    DeleteUser(selectedUserID);
                    this.Hide();
                    Form form = new ListForm();
                    form.ShowDialog();

                    
                }
            
            
            }

        }

        private void DeleteUser(int id)
        {
            try
            {
                using (SQLiteConnection connectin = new SQLiteConnection(Form1.conString)) { 
                    connectin.Open();

                    string query = @"DELETE FROM user_table WHERE id=@id";

                    SQLiteCommand cmd = new SQLiteCommand(query,connectin);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    connectin.Close();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            if (listView1.SelectedItems.Count>0)
                item = listView1.SelectedItems[0];  

            nameText.Text= item.SubItems[1].Text;
            emailtext.Text=item.SubItems[2].Text;
            passtext.Text = item.SubItems[3].Text;
        }

        private void updateUser_Click(object sender, EventArgs e)
        {

        }
    }
}
