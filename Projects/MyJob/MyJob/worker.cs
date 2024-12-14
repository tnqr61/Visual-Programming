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
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            DBManagement.UpdateInfos("employee_table", NameText.Text, PasswordText.Text);
            this.Hide();
            Employer employerForm = new Employer();
            employerForm.ShowDialog();

        }
    }
}
