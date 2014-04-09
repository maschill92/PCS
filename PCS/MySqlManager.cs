using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace PCS
{
    sealed class MySqlManager
    {
        private String connectionString = "server=localhost;user=root;database=pcs;password=root;port=3306";
        private MySqlConnection conn;

        private static MySqlManager instance = null;
        private MySqlManager()
        {
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Application.Exit();
            }
        }

        public static MySqlManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MySqlManager();
                }
                return instance;
            }
        }

        public bool AuthenticateDataCataloger(String username, String password)
        {
            MySqlCommand cmd = new MySqlCommand(
                "SELECT count(*) FROM pcs.data_cataloger " +
                "WHERE username='" + username+ "' and password='" + password + "';", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            String count = rdr.GetString(0);
            rdr.Close();
            if (count == "1") return true;
            else return false;
        }

        public DataCataloger GetDataCataloger(String username)
        {
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM pcs.data_cataloger " +
                "WHERE username='" + username + "';", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            DataCataloger dc = new DataCataloger(
                rdr["username"].ToString(),
                rdr["password"].ToString(),
                rdr["fName"].ToString(),
                rdr["lName"].ToString(),
                rdr["email"].ToString(),
                rdr["sex"].ToString(),
                rdr["doB"].ToString()
            );
            return dc;
        }
    }
}
