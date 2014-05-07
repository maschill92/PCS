using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cataloger
{
    /// <summary>
    /// Class the represents a Cataloger, a major user of the system.
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

        /// <summary>
        /// Constructor that using MySQL Manager to gather the data of
        /// a given Cataloger based on username
        /// </summary>
        /// <param name="uName">username of the Cataloger to be instantiated</param>
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

        /// <summary>
        /// Updates the Cataloger with the given variables
        /// </summary>
        /// <param name="password">The new of password the Cataloger</param>
        /// <param name="fName">The new of first name the Cataloger</param>
        /// <param name="lName">The new of last name the Cataloger</param>
        /// <param name="email">The new of email the Cataloger</param>
        /// <param name="sex">The new of sex the Cataloger</param>
        /// <param name="dateOfBirth">The new of date of birth the Cataloger</param>
        /// <returns>True if update was successful, false otherwise</returns>
        public bool Update(String password, String fName, String lName, String email, String sex, String dateOfBirth)
        {
            return MySqlManager.MySqlManager.Instance.ExecuteNonQuery("update cataloger set password='" + password + "', fName='" + fName
                + "', lName='" + lName + "', email='" + email + "', sex='" + sex + "', dateOfBirth='" + dateOfBirth + "' where username='" + this.username + "'");
        }
    }
}
