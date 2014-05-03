using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dba
{
    public class Dba
    {
        public String username;
        public String password;
        public String fName;
        public String lName;
        public String email;
        public String sex;
        public String dateOfBirth;

        public String fullName { get { return fName + " " + lName; } }

        public Dba(String u, String p, String f, String l, String e, String s, String d)
        {
            username = u;
            password = p;
            fName = f;
            lName = l;
            email = e;
            sex = s;
            dateOfBirth = DateTime.Parse(d).ToString("yyyy-MM-dd");
        }

        public static List<Dba> Generate(DbaUser user)
        {
            System.Console.WriteLine("Testing\n");
            MySqlDataReader reader = MySqlManager.MySqlManager.Instance.ExecuteReader("select d.* from dba as d where d.username not in (select u.username from dba as u where u.username='" + user.username + "')");
            List<Dba> list = new List<Dba>();
            while (reader.Read())
            {
                list.Add(new Dba(reader["username"].ToString(), reader["password"].ToString(),
                    reader["fName"].ToString(), reader["lName"].ToString(), reader["email"].ToString(),
                    reader["sex"].ToString(), reader["dateOfBirth"].ToString()));
            }
            reader.Close();
            return list;
        }

        public bool Add()
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("insert into dba (username, password, fName, lName, email, sex, dateOfBirth) values ('" +
                username + "', '" + password + "', '" + fName + "', '" + lName + "', '" + email +
                "', '" + sex + "', '" + dateOfBirth + "')");
        }

        public bool Update(String p, String f, String l, String e, String s, String d)
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("update dba set password='" + p + "', fName='" + f
                + "', lName='" + l + "', email='" + e + "', sex='" + s + "', dateOfBirth='" + d + "' where username='" + username + "'");
        }

        public bool Delete()
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("delete from dba where username = '" + username + "'");
        }
    }
}