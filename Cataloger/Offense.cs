using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    /// <summary>
    /// Class that represents an Offense.  It references the Prisoner that committed it.
    /// </summary>
    class Offense
    {
        public int id;
        public String location;
        public String type;
        public String description;
        public String date;
        public Prisoner prisoner;

        /// <summary>
        /// Constructor that accepts all class fields
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="location">Where the offense occured</param>
        /// <param name="type">The Type of the offense</param>
        /// <param name="description">Details of the offense</param>
        /// <param name="date">When the offense occured</param>
        /// <param name="p">The Prisoner that committed the Offense</param>
        public Offense(int id, String location, String type, String description, String date, Prisoner p)
        {
	        this.id = id;
            this.location = location;
	        this.type = type;
	        this.description = description;
            this.date = DateTime.Parse(date).ToString("yyyy-MM-dd");
	        this.prisoner = p;
        }

        /// <summary>
        /// Generates a list of Offenses of a given prisoner
        /// </summary>
        /// <param name="p">The prisoner whose offenses will be generated</param>
        /// <returns>A list of Offense objects that are associated with a Prisoner</returns>
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

        /// <summary>
        /// Updates an Offense with the new given details.
        /// Note you cannot change the Prisoner associated with an offense
        /// </summary>
        /// <returns>True if the update was successful, false otherwise</returns>
        public static bool Update(int id, String loc, String type, String description, String date, int prisonerId)
        {
            String str = "update offense set location='" + loc + "', type='" + type + "', description='" + description + "', date='" + date + "', prisonerId='" + prisonerId + "' where id='" + id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// Adds a new Offense to the database.
        /// </summary>
        /// <returns>True if the offense was successful, false otherwise</returns>
        public static bool Add(String loc, String type, String description, String date, int prisonerId)
        {
            String str = "insert into offense (location, type, description, date, prisonerId) values ('"
                + loc + "', '" + type + "', '" + description + "', '" + date + "', '" + prisonerId + "')";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;

        }

        /// <summary>
        /// Deletes an Offense from the database
        /// </summary>
        /// <param name="id">The id of the Offense to be deleted</param>
        /// <returns>True if the deletion was successful, false otherwise</returns>
        public static bool Delete(int id)
        {
            String str = "delete from offense where id='" + id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
