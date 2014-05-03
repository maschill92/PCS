using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    class Offense
    {
        public int id;
        public String location;
        public String type;
        public String description;
        public String date;
        public Prisoner prisoner;

        public Offense(int id, String location, String type, String description, String date, Prisoner p)
        {
	        this.id = id;
            this.location = location;
	        this.type = type;
	        this.description = description;
            this.date = DateTime.Parse(date).ToString("yyyy-MM-dd");
	        this.prisoner = p;
        }

        public static List<Offense> Generate(Prisoner p)
        {
            String str = "select * from offense where prisonerId='" + p.id + "'";
            MySql.Data.MySqlClient.MySqlDataReader rdr = MySqlManager.MySqlManager.Instance.ExecuteReader(str);
            if (rdr == null)
            {
                throw new Exception("Reading offenses failed.");
            }
            List<Offense> list = new List<Offense>();
            while (rdr.Read())
            {
                list.Add(new Offense(Convert.ToInt32(rdr["id"]), rdr["location"].ToString(), rdr["type"].ToString(), rdr["description"].ToString(), rdr["date"].ToString(), p));
            }
            rdr.Close();
            return list;
        }

        public static bool Update(int id, String loc, String type, String description, String date, int prisonerId)
        {
            String str = "update offense set location='" + loc + "', type='" + type + "', description='" + description + "', date='" + date + "', prisonerId='" + prisonerId + "' where id='" + id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        public static bool Add(String loc, String type, String description, String date, int prisonerId)
        {
            String str = "insert into offense (location, type, description, date, prisonerId) values ('"
                + loc + "', '" + type + "', '" + description + "', '" + date + "', '" + prisonerId + "')";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;

        }

        public static bool Delete(int id)
        {
            String str = "delete from offense where id='" + id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
