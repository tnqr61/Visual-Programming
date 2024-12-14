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
    public partial class Register : Form
    {
        Form login = new Login();
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
          
            if ((string.IsNullOrWhiteSpace(registerNameText.Text) ||
                string.IsNullOrWhiteSpace(registerNickNameText.Text) ||
                string.IsNullOrWhiteSpace(registerEmailText.Text) ||
                string.IsNullOrWhiteSpace(registerPasswordText.Text) ) || (!employerRadioBtn.Checked && !employeeRadioBtn.Checked)
                )
            {

                    MessageBox.Show("Lütfen tüm bilgileri doldurun");
            }
            else
            {
                string role = employeeRadioBtn.Checked ? "employee" : "employer";
                bool success;
                success = DBManagement.AddUser(registerNameText.Text, registerNickNameText.Text, registerEmailText.Text, role, registerPasswordText.Text);
                if (success)
                {
                    MessageBox.Show("Başarıyla Kaydolundu");
                    label2_Click(sender, e);
                    this.Hide();
                    login.Show();
                }
            }

              
                        
                        
                

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            login.Show();

        }

        
    }
}
