using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    /// <summary>
    /// Class that represents a prison in the system.
    /// </summary>
    class Prison
    {
        public int id { get; set; }
        public String name { get; set; }
        public String location;
        public String description;
        public List<CellBlock> blocks;

        /// <summary>
        /// Constructor that sets all the class fields except for 'blocks' which is set in GenerateAll
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="name">String</param>
        /// <param name="location">String</param>
        /// <param name="description">Description</param>
        public Prison(int id, String name, String location, String description)
        {
            this.id = id;
            this.name = name;
            this.location = location;
            this.description = description;
        }

        /// <summary>
        /// Consults the MySQLManager to gather all of the prisons.  This functions eventually cascades
        /// down to the levels of offense
        /// </summary>
        /// <returns></returns>
        public static List<Prison> GenerateAll()
        {
            String str = "select * from prison";
            MySql.Data.MySqlClient.MySqlDataReader rdr = MySqlManager.MySqlManager.Instance.ExecuteReader(str);
            if (rdr == null) 
            {
                throw new Exception("Reading all prisons failed.");
            }
            List<Prison> list = new List<Prison>();
            while (rdr.Read())
            {
                list.Add(new Prison(Convert.ToInt32(rdr["id"]), rdr["name"].ToString(), rdr["location"].ToString(), rdr["description"].ToString()));
            }
            rdr.Close();
            foreach (Prison p in list)
            {
                p.blocks = CellBlock.Generate(p);
            }
            return list;
        }

        /// <summary>
        /// Updates a prisoner with the given data
        /// </summary>
        /// <param name="name">The new name for the Prison</param>
        /// <param name="location">The new locaiton for the Prison</param>
        /// <param name="description">The new description for the Prison</param>
        /// <returns>True if update was successful, false otherwise</returns>
        public bool Update(String name, String location, String description)
        {
            String str = "update prison set name='" + name + "', location='" + location + "', description='" + description + "' where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// Deletes the Prison from the database
        /// </summary>
        /// <returns>True if deletion was successful, false otherwise</returns>
        public bool Delete()
        {
            String str = "delete from prison where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// Adds a new Prison to the system
        /// </summary>
        /// <param name="name">Name of the new Prison</param>
        /// <param name="location">Location of the new Prison</param>
        /// <param name="description">Description of the new Prison</param>
        /// <returns>True if addition was successful, false otherwise</returns>
        public static bool Add(String name, String location, String description)
        {
            String str = "insert into prison (name, location, description) values ('" + name + "', '" + location + "', '" + description + "')";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
