using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace loginRegisterForm
{
    public class User
    {
        int id;
       
        public string name {  get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(string name,string email,string password) {
            this.name = name;
            this.email = email;
            this.password = password;
            
        
        
        }
        public User(SQLiteDataReader dataReader)
        {
            this.name =dataReader["name"].ToString();
            this.email=dataReader["email"].ToString();
            this.password=dataReader["password"].ToString();

        }

        
     

        
    }
}
