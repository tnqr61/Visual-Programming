using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyJob
{
    public class DBManagement
    {
        public static readonly string dbFileName = "MyJOB.db";
        public static readonly string connectionString = $"Data source={dbFileName}";
        public static string AuthUserEmail = "";
        public static DataSet employeesDataSet = new DataSet();
             
        public static void CreateDatabase()
        {
            if (!System.IO.File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }

            //tabloları oluştur
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();

                    string createEmployeeTable = @"CREATE TABLE IF NOT EXISTS employee_table (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Name TEXT NOT NULL,
                                            NickName TEXT NOT NULL UNIQUE,
                                            Email TEXT NOT NULL UNIQUE,
                                            Role TEXT NOT NULL,
                                            Password TEXT NOT NULL);";

                    string createEmployerTable = @"CREATE TABLE IF NOT EXISTS employer_table (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Name TEXT NOT NULL,
                                            NickName TEXT NOT NULL UNIQUE,
                                            Email TEXT NOT NULL UNIQUE,
                                            Role TEXT NOT NULL,
                                            Password TEXT NOT NULL,
                                            employees TEXT);";

                    string createEmployersWorkersTable = @"CREATE TABLE IF NOT EXISTS employers_workers (
                                                   employer_nickName TEXT,
                                                   employee_nickName TEXT,
                                                   employee_daily_wage DOUBLE,
                                                   employee_monthly_wage DOUBLE,
                                                   employee_total_salary DOUBLE,

                                                   FOREIGN KEY (employer_nickName) REFERENCES employer_table(NickName),
                                                   FOREIGN KEY (employee_nickName) REFERENCES employee_table(NickName),
                                                   PRIMARY KEY (employer_nickName, employee_nickName));";

                    // Tüm SQL komutlarını birleştir ve ExecuteNonQuery kullan
                    string createTables = createEmployeeTable +
                                          createEmployerTable +
                                          createEmployersWorkersTable;

                    using (SQLiteCommand cmd = new SQLiteCommand(createTables, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
           



        }


        
        public static bool AddUser(string name, string nickName,string email,string role,string password)
        {
            
            try
            {
                
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open(); 
                    string query = "";
                    if (role == "employee") 

                       
                    {
                         query = @"INSERT INTO employee_table (Name,NickName,Email,Role,Password) VALUES(@name,@nickName,@email,@role,@password)";
                    }
                    else
                    {
                         query = @"INSERT INTO employer_table (Name,NickName,Email,Role,Password) VALUES(@name,@nickName,@email,@role,@password)";
                    }
                   
                    using (SQLiteCommand command = new SQLiteCommand(query, con)) {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@nickName", nickName);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@role", role);
                        command.Parameters.AddWithValue("@password", password);
                        

                        command.ExecuteNonQuery ();
                        con.Close();
                        return true;

                    }
                }

            }
            catch (Exception ex) 
            {
                
                MessageBox.Show(ex.Message);
                return false;
            }

           
        }
        public static int login(string email, string password) {
            
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    //dönen değer 1 employye table 2 employer table ve 0 kayıt bulunamamyı ifade eder.
                    string query_employeeTable = @"SELECT Name,NickName,Email,Password FROM employee_table WHERE Email = @email AND Password = @password ";
                    string query_employerTable = @"SELECT Name,NickName,Email,Password FROM employer_table WHERE Email = @email AND Password = @password ";
                    
                    //employee tablosunda sorgu
                    using (SQLiteCommand command = new SQLiteCommand(query_employeeTable, con)) // employee tablosunda sorgu
                    {
                       
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue ("@password", password);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            //kullanıcıyı employee tablosunda arar //1 employee tablosunu temsil eder
                            if (reader.HasRows)
                            {
                               
                                while (reader.Read())
                                    AuthUserEmail = reader["Email"].ToString();
                                
                                reader.Close();
                                con.Close();
                                return 1;
                            }
                               
                      

                        }

                    }
                    // employer tablosunda sorgu
                    using (SQLiteCommand cmd2 = new SQLiteCommand(query_employerTable, con)) 
                    {

                        cmd2.Parameters.AddWithValue("@email", email);
                        cmd2.Parameters.AddWithValue("@password", password);

                        using (SQLiteDataReader reader = cmd2.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                    AuthUserEmail = reader["Email"].ToString();
                                    reader.Close();
                                con.Close();  
                                return 2;
                            }
                                               
                            else
                            {
                                reader.Close();
                                con.Close();
                                MessageBox.Show("Kullanıcı adı veya şifre Hatalı");
                                return 0;

                            }

                        }

                    }

                }

            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return 0;
            }
        
        
        }

        public static void deleteEmp(string employee_NickName)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = @"DELETE FROM employers_workers
                                    WHERE employee_nickName = @EmployeeNickName
                                    AND employer_nickName IN (
                                    SELECT NickName
                                    FROM employer_table
                                    WHERE Email = @Email)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@EmployeeNickName", employee_NickName);
                        cmd.Parameters.AddWithValue("@Email", AuthUserEmail);

                        
                        cmd.ExecuteNonQuery();
                        con.Close(); 

                    }
                }
            }


            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }

        public static void getEmployees(string nickName)
        {
            ArrayList employeesList = new ArrayList();
            string query = @"SELECT e.Name 
                             FROM employee_table e
                             JOIN employers_workers ew ON e.NickName = ew.employee_nickName
                             WHERE ew.employer_nickName = @employer_nickName";


            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString)) {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn)) { 
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("employer_nickName",nickName);

                        using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                            if (!reader.HasRows)
                               return;
                            
                            else
                            {
                                
                                
                                while (reader.Read())
                                {

                                      employeesList.Add(reader["Name"]);
                                      //frm3.employeesList.Add(emps);

                                }

                            }
                                reader.Close();
                                conn.Close();
                                

                                    
                            } 

                        }
                    
                    
                    }
                
                
                
                
                

            }
            catch (Exception e) 
            {
                    MessageBox.Show(e.Message);

            }
            
            



        }

        public static Dictionary<string, string> getInfos(string table_name)
        {
            Dictionary<string, string> infos = new Dictionary<string, string>();
            try
            {
                using (SQLiteConnection connn = new SQLiteConnection(connectionString))
                {
                    connn.Open();
                    string query = $"SELECT * FROM {table_name} WHERE Email = @Email";

                   
                    SQLiteCommand cmdd = new SQLiteCommand(query, connn);
                    cmdd.Parameters.AddWithValue("@Email", AuthUserEmail); 

                 
                    SQLiteDataReader reader = cmdd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                          
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnName = reader.GetName(i);  
                                string value = reader[i].ToString();  
                              

                                infos[columnName] = value;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return infos;
        }

        public static void UpdateInfos(string table_name,string name,string password)
        {
            try
            {
                using (SQLiteConnection connn = new SQLiteConnection(connectionString))
                {
                    connn.Open();

                    string updateQuery = $@"UPDATE {table_name} SET Name = @Name, Password = @Password WHERE Email = @Email";
                    SQLiteCommand cmd = new SQLiteCommand(updateQuery, connn);
                    cmd.Parameters.AddWithValue("@Email", AuthUserEmail);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Bilgiler Başarıyla Güncellendi");
                }

            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }

        }
        public static void getEmployeesInfo()
        {
            try
            {
                using (SQLiteConnection connn = new SQLiteConnection(connectionString))
                {
                    connn.Open();
                    string query = @"SELECT 
                            ew.employee_nickName, 
                            ew.employee_daily_wage, 
                            ew.employee_monthly_wage, 
                            ew.employee_total_salary
                            FROM employers_workers ew
                            INNER JOIN employer_table et ON ew.employer_nickName = et.NickName
                            WHERE et.email = @authEmail";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connn))
                    {
                        
                        cmd.Parameters.AddWithValue("@authEmail", AuthUserEmail);

                        // Önceki bilgileri temizle
                        if (employeesDataSet.Tables.Contains("Workers"))
                        {
                            employeesDataSet.Tables["Workers"].Clear();
                        }

                        // data sete verileri yükle
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        adapter.Fill(employeesDataSet, "Workers");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        public static void addEmployees(string employeeNickName,double daily_salary,double mothly_salary)
        {
            try
            {
                using (SQLiteConnection connn = new SQLiteConnection(connectionString))
                {
                    connn.Open();

                    string findEmployerQuery = @"SELECT NickName FROM employer_table WHERE Email = @Email";
                    string findEmployeeQuery = @"SELECT NickName FROM employee_table WHERE NickName = @EmployeeNickName";
                    string joinQuery = @"INSERT INTO employers_workers (employer_nickName, employee_nickName, employee_daily_wage, employee_monthly_wage,employee_total_salary)
                             VALUES (@EmployerNickName, @EmployeeNickName, @DailyWage, @MonthlyWage,0)";

                    string employerNickName;

                    // İşveren kontrolü
                    using (SQLiteCommand employerCommand = new SQLiteCommand(findEmployerQuery, connn))
                    {
                        employerCommand.Parameters.AddWithValue("@Email", AuthUserEmail);

                        using (SQLiteDataReader employerReader = employerCommand.ExecuteReader())
                        {
                            if (employerReader.Read()) // .HasRows kontrolü ve veri çekme bir arada
                            {
                                employerNickName = employerReader["NickName"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("İşveren bilgeri Hatalı!");
                                return;
                            }
                        }
                    }

                    // İşçi kontrolü
                    using (SQLiteCommand employeeCommand = new SQLiteCommand(findEmployeeQuery, connn))
                    {
                        employeeCommand.Parameters.AddWithValue("@EmployeeNickName", employeeNickName); // Doğru parametre atandı

                        using (SQLiteDataReader employeeReader = employeeCommand.ExecuteReader())
                        {
                            if (!employeeReader.HasRows) // Eğer sonuç boş ise hata döner
                            {
                                MessageBox.Show("Bu NickName'e ait çalışan bulunamadı!");
                                return;
                            }
                        }
                    }

                    // İşçiyi işverene bağla
                    using (SQLiteCommand cmd = new SQLiteCommand(joinQuery, connn))
                    {
                        cmd.Parameters.AddWithValue("@EmployerNickName", employerNickName);
                        cmd.Parameters.AddWithValue("@EmployeeNickName", employeeNickName);
                        cmd.Parameters.AddWithValue("@DailyWage", daily_salary);
                        cmd.Parameters.AddWithValue("@MonthlyWage", mothly_salary);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Çalışan Başarıyla Listenize Dahil Oldu");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // 0 ödeme 1 amount kadar ekleme yapmak için.
        public static void UpdateEmployeesSalary(string employeeNickName, double amount,int payType)
        {
            if(payType==0)
                amount = -amount;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    // Çalışan maaşını almak için sorgu
                    string totalSalaryQuery = @"SELECT employee_total_salary FROM employers_workers WHERE employee_nickName = @employee_nickName";

                    // Maaşı güncellemek için sorgu
                    string addDailyQuery = @"UPDATE employers_workers 
                                  SET employee_total_salary = @totalSalary 
                                  WHERE employee_nickName = @employeeNickName";

                    // Çalışanın mevcut maaşını almak
                    using (SQLiteCommand cmd = new SQLiteCommand(totalSalaryQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@employee_nickName", employeeNickName);
                        object result = cmd.ExecuteScalar(); //veriyi çek
                        if (result != DBNull.Value) // Eğer veri varsa
                        {
                            double currentSalary = Convert.ToDouble(result);

                            //yeni total salary değeri hesapla
                            double newTotalSalary = currentSalary + amount;

                            // Güncelleme sorgusu
                            using (SQLiteCommand updateCmd = new SQLiteCommand(addDailyQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@totalSalary", newTotalSalary);
                                updateCmd.Parameters.AddWithValue("@employeeNickName", employeeNickName);

                                updateCmd.ExecuteNonQuery(); 
                            }
                        }
                        else
                        {
                            MessageBox.Show("Çalışan bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        
        public static double getTotalExpenses()
        {
                double totalSalary = 0; 
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                       
                        string query = @"SELECT SUM(e.employee_total_salary) AS TotalSalary
                                            FROM employers_workers e
                                            JOIN employer_table et ON e.employer_nickName = et.NickName
                                            WHERE et.Email = @Email";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", AuthUserEmail);

                           
                            object result = cmd.ExecuteScalar();

                            if (result != DBNull.Value)
                            {
                                totalSalary = Convert.ToDouble(result);
                            }
                            else
                            {
                                MessageBox.Show("Belirtilen email ile ilgili veri bulunamadı.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return totalSalary;
        }

        public static double getTotalSalary()
        {
            try { 
            
                string query = @"SELECT ew.employee_total_salary
                               FROM employers_workers ew
                               JOIN employee_table et ON ew.employee_nickName = et.NickName
                               WHERE et.Email = @Email";

              
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn)) {
                        cmd.Parameters.AddWithValue("@Email", AuthUserEmail);
                        object result = cmd.ExecuteScalar();
                        return (double)result;
                    }




                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            
        }
        public static void joinToEmployer(string employer_nickName) {

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string employeeNickName="";
                    string findEmployerQuery = @"SELECT NickName FROM employer_table WHERE NickName = @nickName";
                    string findEmployeeQeery = @"SELECT NickName FROM employee_table WHERE Email = @email";
                    string joinEmployerQuery = @"INSERT INTO employers_workers (employer_nickName, employee_nickName, employee_daily_wage, employee_monthly_wage,employee_total_salary)
                                                 VALUES (@EmployerNickName, @EmployeeNickName, 0, 0 ,0)";
                    //işveren kontrolü
                    using (SQLiteCommand findCmd = new SQLiteCommand(findEmployerQuery, conn))
                    {
                        findCmd.CommandText = findEmployerQuery;
                        findCmd.Parameters.AddWithValue("@nickName", employer_nickName);
                        using (SQLiteDataReader reader = findCmd.ExecuteReader()) { 

                            if (!reader.Read())
                            {
                                MessageBox.Show("Girilen nickName e ait işveren bulunmadı");
                                return;
                            } 
                        }

                    }

                    //kullanıcı nickName çekme.
                    using (SQLiteCommand findemployeeCmd = new SQLiteCommand(findEmployeeQeery, conn))
                    {
                        findemployeeCmd.CommandText = findEmployeeQeery;
                        findemployeeCmd.Parameters.AddWithValue("@email", AuthUserEmail);
                        using (SQLiteDataReader reader = findemployeeCmd.ExecuteReader())
                        {

                            while (reader.Read()) { 
                                employeeNickName = reader["nickName"].ToString();

                            }
                        }

                    }

                    // işveren listesine dahil olma
                    using (SQLiteCommand cmd = new SQLiteCommand(joinEmployerQuery, conn))
                    {
                        cmd.CommandText = joinEmployerQuery;
                        cmd.Parameters.AddWithValue("@EmployerNickName", employer_nickName);
                        cmd.Parameters.AddWithValue("@EmployeeNickName", employeeNickName);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("İşveren Listesine Başarıyla Dahil oldunuz.");




                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        }
  

    }
}
