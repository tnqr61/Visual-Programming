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
    public partial class worker : Form
    {
        public worker()
        {
            InitializeComponent();
        }


        private void worker_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> userInfos = new Dictionary<string, string>();
            userInfos = DBManagement.getInfos("employee_table");
            NameText.Text = userInfos["Name"];
            NickNameText.Text = userInfos["NickName"];
            EmailText.Text = userInfos["Email"];
            PasswordText.Text = userInfos["Password"];
            roleLabel.Text += userInfos["Role"];
            EmailText.Enabled = false;
            NickNameText.Enabled = false;
            double total_salary = DBManagement.getTotalSalary();
            totalText.Text = total_salary.ToString();

        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            DBManagement.UpdateInfos("employee_table", NameText.Text, PasswordText.Text);
            this.Hide();
            worker workerForm = new worker();
            workerForm.ShowDialog();

        }

        private void joinToEmployerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(joinToEmployerNickNameTextBox.Text))
                MessageBox.Show("İşveren nickName i girmelisin!");

            else
            {
                DBManagement.joinToEmployer(joinToEmployerNickNameTextBox.Text);
                joinToEmployerNickNameTextBox.Clear();

            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            DBManagement.AuthUserEmail=null;
        }

        
    }
}
