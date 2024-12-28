using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginRegisterForm
{
    public partial class Form1 : Form
    {
        public static string conString;
        public static string dbName;
        public Form1()
        {
         
            InitializeComponent();
            dbName = "user.db";
            conString = $"Data Source={dbName}";

        }




        private void Form1_Load(object sender, EventArgs e)
        {

           Create_database();
       



        }
        private void Create_database()
        {
            if (!System.IO.File.Exists(dbName))
                SQLiteConnection.CreateFile(dbName);
            {
               
                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(conString))
                    {
                        con.Open();

                        string query = "CREATE TABLE IF NOT EXISTS user_table(id INTEGER PRIMARY KEY AUTOINCREMENT,name TEXT NOT NULL,email TEXT NOT NULL,password TEXT NOT NULL)";
                        SQLiteCommand cmd = new SQLiteCommand(query, con);
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                }
                catch (Exception ex) { 
                    MessageBox.Show("Veri tabanı oluşturulurken hata:"+ex.Message);
                }
            }


        }
        public bool AddUser(User user)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    con.Open();
                    string query = @"INSERT INTO user_table
                              (name,email,password)
                              VALUES(@name,@email,@password)";
                    SQLiteCommand command = new SQLiteCommand(query, con);

                    command.Parameters.AddWithValue("@name", user.name);
                    command.Parameters.AddWithValue("@email", user.email);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.ExecuteNonQuery();
                    return true;


                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool login(string email,string password)
        {
            try
            {
                using(SQLiteConnection con = new SQLiteConnection(conString))
                {
                    con.Open();
                    string query = @"SELECT *FROM user_table WHERE email= @email AND password=@password";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        User user = new User(reader);

                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Your crediantials  are invalid ");
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu kullanıcı bilgilerine ait herhangi bir kullanıcı bulunamadı");
                return false;

            }
        }


        private void register_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(registerNameTextbox.Text) || string.IsNullOrEmpty(registerEmailTextBo.Text) || string.IsNullOrEmpty(registerPassTextBox.Text))
            {
                MessageBox.Show("gerekli alanları doldudurun");
              
            }
            else
            {
                User user = new User(registerNameTextbox.Text,registerEmailTextBo.Text,registerPassTextBox.Text);
                bool success = AddUser(user);
                if (success)
                {
                    Form listform = new ListForm();
                    this.Visible = false;
                    listform.ShowDialog();


                }
                   
                    
                   

            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailText.Text) || string.IsNullOrEmpty(passText.Text))
                MessageBox.Show("gerekli alanları doldur!!");
            else
            {
               bool success = login(emailText.Text,passText.Text);
                if (success) { 
                    Form listForm = new ListForm();
                    this.Visible = false;
                    listForm.ShowDialog();
                    
                }
            }
        }

        
    }
}
