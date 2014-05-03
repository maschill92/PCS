using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cataloger
{
    public class Cataloger
    {
        public String username;
        public String password;
        public String fName;
        public String lName;
        public String email;
        public String sex;
        public String dateOfBirth;

        public Cataloger(String uName)
        {
            MySqlDataReader reader = MySqlManager.MySqlManager.Instance.ExecuteReader("select * from cataloger as c where c.username = '" + uName + "'");
            
            if (reader.Read())
            {
                username = reader["username"].ToString();
                password = reader["password"].ToString();
                fName = reader["fName"].ToString();
                lName = reader["lName"].ToString();
                email = reader["email"].ToString();
                sex = reader["sex"].ToString();
                dateOfBirth = reader["dateOfBirth"].ToString();
            }
            reader.Close();
        }

        public bool Update(String p, String f, String l, String e, String s, String d)
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("update cataloger set password='" + p + "', fName='" + f
                + "', lName='" + l + "', email='" + e + "', sex='" + s + "', dateOfBirth='" + d + "' where username='" + this.username + "'");
        }
    }
}
