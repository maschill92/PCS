using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    /// <summary>
    /// This class contains the methods that facilitate the login authentication process. These methods determine if the user 
    /// information entered is valid within the database.
    /// </summary>
    static class LoginHandler
    {
        /// <summary>
        /// This method determines if the user information entered is valid within the database.
        /// It uses a MySQL query to count the number of users in the respective table that match the given user information.
        /// If the value is 1, it returns true and grants authentication. Otherwise it returns false and authentication is denied.
        /// </summary>
        /// <param name="uName"></param>Username paramater of the respective userType
        /// <param name="pWord"></param>Password paramater of the respective userType
        /// <param name="userType"></param>Selected userType in the Login Interface (Cataloger, Database Administrator)
        /// <returns></returns> returns 'true' if the user is valid and 'false' otherwise
        public static bool IsValidUser(String uName, String pWord, String userType)
        {
            String table;
            switch (userType)
            {
                case ("Cataloger"):
                    table = "cataloger";
                    break;
                case ("Database Administrator"):
                    table = "dba";
                    break;
                default:
                    throw new Exception("User type doesn't exist.");
            }

            String str = "select count(*) from " + table + " where username='" + uName + "' and password='" + pWord + "'";
            int count = Convert.ToInt32(MySqlManager.MySqlManager.Instance.ExecuteScalar(str));
            return (count == 1);
        }
    }
}
