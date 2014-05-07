using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dba
{
    /// <summary>
    /// Represents a Cataloger in the system associated with the DBA interface.
    /// </summary>
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

        /// <summary>
        /// The constructor for the Cataloger class that is used to create a new Cataloger object in the system.
        /// The information for the Cataloger is passed directly as paramaters to this method
        /// </summary>
        /// <param name="u"></param> represents the Cataloger's username
        /// <param name="p"></param> represents the Cataloger's password
        /// <param name="f"></param> represents the Cataloger's first name
        /// <param name="l"></param> represents the Cataloger's last name
        /// <param name="e"></param> represents the Cataloger's email address
        /// <param name="s"></param> represents the Cataloger's sex
        /// <param name="d"></param> represents the Cataloger's date of birth
        public Cataloger(String u, String p, String f, String l, String e, String s, String d)
        {
            username = u;
            password = p;
            fName = f;
            lName = l;
            email = e;
            sex = s;
            dateOfBirth = DateTime.Parse(d).ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// This method creates and returns a list of all of the Cataloger in the database
        /// </summary>
        /// <returns></returns> returns a list of all of the Cataloger in the database
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

        /// <summary>
        /// This method is used to add a new Cataloger into the database
        /// </summary>
        /// <returns></returns> returns 'true' if the operation was successful and 'false' otherwise
        public bool Add()
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("insert into cataloger (username, password, fName, lName, email, sex, dateOfBirth) values ('" +
                username + "', '" + password + "', '" + fName + "', '" + lName + "', '" + email +
                "', '" + sex + "', '" + dateOfBirth + "')");
        }

        /// <summary> Updating method for the Cataloger class
        /// This method is used to update the Cataloger's information in the database. Only the Cataloger's password, first name, last name,
        /// email address, sex, and date of birth may be updated. The username cannot be.
        /// </summary>
        /// <param name="password"></param> represents the Cataloger's new password
        /// <param name="f"></param> represents the Cataloger's new first name
        /// <param name="l"></param> represents the Cataloger's new last name
        /// <param name="e"></param> represents the Cataloger's email address
        /// <param name="s"></param> represents the Cataloger's sex
        /// <param name="d"></param> represents the Cataloger's date of birth
        /// <returns></returns> returns 'true' if the operation was successful and 'false' otherwise
        public bool Update(String p, String f, String l, String e, String s, String d)
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("update cataloger set password='" + p + "', fName='" + f
                + "', lName='" + l + "', email='" + e + "', sex='" + s + "', dateOfBirth='" + d + "' where username='" + username + "'");
        }

        /// <summary>
        /// This method is used to remove the repsective Cataloger from the database
        /// </summary>
        /// <returns></returns> returns 'true' if the operation was successful and 'false' otherwise
        public bool Delete()
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("delete from cataloger where username = '" + username + "'");
        }

    }
}
