using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dba
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

        public String fullName { get { return fName + " " + lName; } }

        public Cataloger(String u, String p, String f, String l, String e, String s, String d)
        {
            username = u;
            password = p;
            fName = f;
            lName = l;
            email = e;
            sex = s;
            dateOfBirth = d;
        }

        public static List<Cataloger> Generate()
        {
            MySqlDataReader reader = MySqlManager.MySqlManager.Instance.ExecuteReader("select * from cataloger");
            List<Cataloger> list = new List<Cataloger>();
            while (reader.Read())
            {
                list.Add(new Cataloger(reader["username"].ToString(), reader["password"].ToString(),
                    reader["fName"].ToString(), reader["lName"].ToString(), reader["email"].ToString(),
                    reader["sex"].ToString(), reader["dateOfBirth"].ToString()));
            }
            reader.Close();
            return list;
        }

        public bool Add()
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("insert into cataloger (username, password, fName, lName, email, sex, dateOfBirth) values ('" +
                username + "', '" + password + "', '" + fName + "', '" + lName + "', '" + email +
                "', '" + sex + "', '" + dateOfBirth + "')");
        }

        public bool Update(String p, String f, String l, String e, String s, String d)
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("update cataloger set password='" + p + "', fName='" + f
                + "', lName='" + l + "', email='" + e + "', sex='" + s + "', dateOfBirth='" + d + "' where username='" + username + "'");
        }

        public bool Delete()
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("delete from cataloger where username = '" + username + "'");
        }

    }
}
