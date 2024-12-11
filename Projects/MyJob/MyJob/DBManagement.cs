using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyJob
{
    public class DBManagement
    {
        public static readonly string dbFileName = "MyJOB.db";
        public static readonly string connectionString = $"Data source={dbFileName}";
        public static string AuthUserEmail = "";
             
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
                                                   FOREIGN KEY (employer_nickName) REFERENCES employer_table(NickName),
                                                   FOREIGN KEY (employee_nickName) REFERENCES employee_table(NickName),
                                                   PRIMARY KEY (employer_nickName, employee_nickName));";


                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = createEmployeeTable;
                    cmd.CommandText += createEmployerTable;
                    cmd.CommandText += createEmployersWorkersTable;
                        
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
                    if (role == "Employee") 

                       
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
        public static void joinToEmployeer(string employee_nickName,string employer_nickName)
        {

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString)) {
                    con.Open();

                    string joinQuery = "";

                    joinQuery = @"INSERT INTO employers_workers (employer_nickName,employee_nickName) VALUES(@employer_nickName,@employee_nickName)";

                    string findEmployeerQuery = @"SELECT NickName FROM employer_table WHERE NickName = @nickName";


                    using (SQLiteCommand command = new SQLiteCommand(findEmployeerQuery, con)) {
                        command.Parameters.AddWithValue("nickName", employer_nickName);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                                MessageBox.Show("Bu nickName,e ait bir kullanıcı bulunamadı");
                            else
                            {
                                
                                using(SQLiteCommand cmd  = new SQLiteCommand(joinQuery, con))
                                {
                                    cmd.Parameters.AddWithValue("employer_nickName", employer_nickName);
                                    cmd.Parameters.AddWithValue("employee_nickName", employee_nickName);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Başarıyla Çalışanın listesine Kaydoldunuz");

                                }
                            }

                        }
                    }



                }

            }
            catch (Exception ex) { 
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

       



    }
}
