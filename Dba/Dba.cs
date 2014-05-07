using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dba
{
    /// <summary>
    /// Represents a DBA in the system associated with the DBA interface.
    /// </summary>
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

        /// <summary>
        /// The constructor for the DBA class that is used to create a new DBA object in the system. The information for the
        /// DBA is passed directly as paramaters to this method
        /// </summary>
        /// <param name="u"></param> represents the DBA's username
        /// <param name="p"></param> represents the DBA's password
        /// <param name="f"></param> represents the DBA's first name
        /// <param name="l"></param> represents the DBA's last name
        /// <param name="e"></param> represents the DBA's email address
        /// <param name="s"></param> represents the DBA's sex
        /// <param name="d"></param> represents the DBA's date of birth
        public Dba(String u, String p, String f, String l, String e, String s, String d)
        {
            username = u;
            password = p;
            fName = f;
            lName = l;
            email = e;
            sex = s;
            dateOfBirth = DateTime.Parse(d).ToString("yyyy-MM-dd"); // MySQL date format
        }

        /// <summary>
        /// This method creates and returns a list of all of the DBAs in the database, except for the DBA user. The user
        /// is excluded so that they cannot be deleted from the system by accident and potentially reach a state where
        /// the system has no DBAs
        /// </summary>
        /// <returns></returns> returns a list of all of the DBAs in the database
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

        /// <summary>
        /// This method is used to add a new DBA into the database
        /// </summary>
        /// <returns></returns> returns 'true' if the operation was successful and 'false' otherwise
        public bool Add()
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("insert into dba (username, password, fName, lName, email, sex, dateOfBirth) values ('" +
                username + "', '" + password + "', '" + fName + "', '" + lName + "', '" + email +
                "', '" + sex + "', '" + dateOfBirth + "')");
        }

        /// <summary> Updating method for the DBA class
        /// This method is used to update the DBA's information in the database. Only the DBA's password, first name, last name,
        /// email address, sex, and date of birth may be updated. The username cannot be.
        /// </summary>
        /// <param name="password"></param> represents the DBA's new password
        /// <param name="f"></param> represents the DBA's new first name
        /// <param name="l"></param> represents the DBA's new last name
        /// <param name="e"></param> represents the DBA's email address
        /// <param name="s"></param> represents the DBA's sex
        /// <param name="d"></param> represents the DBA's date of birth
        /// <returns></returns> returns 'true' if the operation was successful and 'false' otherwise
        public bool Update(String p, String f, String l, String e, String s, String d)
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("update dba set password='" + p + "', fName='" + f
                + "', lName='" + l + "', email='" + e + "', sex='" + s + "', dateOfBirth='" + d + "' where username='" + username + "'");
        }

        /// <summary>
        /// This method is used to remove the repsective DBA from the database
        /// </summary>
        /// <returns></returns> returns 'true' if the operation was successful and 'false' otherwise
        public bool Delete()
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("delete from dba where username = '" + username + "'");
        }
    }
}