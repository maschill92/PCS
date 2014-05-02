using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    static class LoginHandler
    {
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
