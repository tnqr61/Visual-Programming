using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJob
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            
        }

        

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginEmailText.Text) ||
                string.IsNullOrWhiteSpace(loginPasswordText.Text))
                MessageBox.Show("Kullanıcı Adı ya da Şifreyi tam girin");
            else
            {
              int table = DBManagement.login(loginEmailText.Text,loginPasswordText.Text);
                if (table == 2)
                {
                    Employer empForm = new Employer();
                    this.Hide();
                    empForm.Show();   
                }
                else if (table == 1)
                {
                    worker workerForm = new worker();
                    this.Hide();
                    workerForm.Show();
                }
                
                
            }
            

        }

        private void clickForRegisterClick(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.Show();
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBManagement.CreateDatabase();
        }
    }
}
