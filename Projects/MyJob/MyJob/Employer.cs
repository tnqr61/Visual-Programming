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
    public partial class Employer : Form
    {
        public Employer()
        {
            InitializeComponent();
        }
          

        private void Employer_Load(object sender, EventArgs e)
        {

            Dictionary<string,string> userInfos = new Dictionary<string,string>();
            userInfos= DBManagement.getInfos("employer_table");
            NameText.Text = userInfos["Name"];
            NickNameText.Text = userInfos["NickName"];
            EmailText.Text = userInfos["Email"];
            PasswordText.Text = userInfos["Password"];
            roleLabel.Text += userInfos["Role"];
            EmailText.Enabled=false;
            NickNameText.Enabled=false;
            

            //workers Bilgilerini getirme
            DBManagement.getEmployeesInfo();

            employeeList.DataSource = DBManagement.employeesDataSet.Tables["Workers"];

            employeeList.Columns["employee_nickName"].HeaderText = "Employee";
            employeeList.Columns["employee_daily_wage"].HeaderText = "Daily Wage";
            employeeList.Columns["employee_monthly_wage"].HeaderText = "Monthly Wage";
            employeeList.Columns["employee_total_salary"].HeaderText = "Total Salary";
            employeeList.AutoGenerateColumns = false;
            employeeList.RowHeadersVisible = false;

            //worker Expenses
            double total_Expenses = DBManagement.getTotalExpenses();
            workerExpenses.Text = total_Expenses.ToString()+" $";







        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DBManagement.UpdateInfos("employer_table", NameText.Text, PasswordText.Text);
            this.Hide();
            Employer employerForm = new Employer();
            employerForm.ShowDialog();
        }

        private void addEmployer_Click(object sender, EventArgs e)
        {
              if (string.IsNullOrEmpty(employeeNickNameText.Text) ||
                string.IsNullOrEmpty(employeeSalaryText.Text) ||
               ( !DailyRadioButton.Checked  && !mothlyRaidoButton.Checked))
            {
                MessageBox.Show("Gerekli Alanları doldurun!!");

            }
            else
            {
                double monthlyWage = 0;
                double dailyWage = 0;
                if (DailyRadioButton.Checked)
                {
                    monthlyWage = int.Parse(employeeSalaryText.Text) * 30;
                    dailyWage = int.Parse(employeeSalaryText.Text);

                }
                  
                if (mothlyRaidoButton.Checked)
                {
                    monthlyWage = int.Parse(employeeSalaryText.Text);
                    dailyWage = int.Parse(employeeSalaryText.Text)/30;
                }
                DBManagement.addEmployees(employeeNickNameText.Text, dailyWage, monthlyWage);
                employeeNickNameText.Clear();
                employeeSalaryText.Clear();
                this.Hide();
                Employer empForm = new Employer();
                empForm.ShowDialog();
                

                    
               
            }

        }


        private void addDaily_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in employeeList.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    string employeeNickName = row.Cells["employee_nickName"].Value.ToString();

                    double amount = Convert.ToDouble(row.Cells["employee_daily_wage"].Value);

                     DBManagement.UpdateEmployeesSalary(employeeNickName, amount,1);
                }

            }
            this.Hide();
            Employer employerForm = new Employer();
            employerForm.ShowDialog();
            
           
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in employeeList.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    string employeeNickName = row.Cells["employee_nickName"].Value.ToString();
                    double total_salary = Convert.ToDouble(row.Cells["employee_total_salary"].Value); 
                    double amount = double.Parse(paySalaryTextBox.Text);


                    if (total_salary < amount)
                    {
                        MessageBox.Show($"{employeeNickName} nickname'ine sahip işçiye olan toplam borcunuz ödediğniz bütçeden daha az!!");
                        paySalaryTextBox.Clear();
                        return;

                    }  //ödeme yapılacak tutarı salaryboxtaki değerden al ve bunun ödeme olduğunu son parametreyi 0 olarak girerek göster.
                    DBManagement.UpdateEmployeesSalary(employeeNickName,amount, 0);







                }

            }
            Employer employerForm = new Employer();
            this.Hide();
            employerForm.ShowDialog();

        }


        private void deleteSelectedEmp_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in employeeList.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    string employeeNickName = row.Cells["employee_nickName"].Value.ToString();



                    DBManagement.deleteEmp(employeeNickName);
                }

            }
            Employer employerForm = new Employer();
            this.Hide();
            employerForm.ShowDialog();


        }

        private void logOut_Click(object sender, EventArgs e)
        {
           Login loginForm = new Login();
           this.Hide();
           loginForm.ShowDialog();
            DBManagement.AuthUserEmail = null;
        }

       
    }
}
