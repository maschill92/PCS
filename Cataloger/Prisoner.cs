using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    /// <summary>
    /// Class that represents a Prisoner.  It refrences the cell the Prisoner lives in
    /// and a list of offenses that the Prisoner has committed
    /// </summary>
    class Prisoner
    {
        public int id;
        public String fName;
        public String lName;
        public String dateOfBirth;
        public String sex;
        public Cell cell;
        public List<Offense> offenses;
        public String ListBoxDisplay
        {
            get { return id.ToString() + ": " + fName + " " + lName;}
        }

        /// <summary>
        /// Constructor that accepts all class fields except for the list
        /// of offenses that the Prisoner has committed. That data is produce in Generate
        /// </summary>
        /// <param name="id">ID of the Prisoner</param>
        /// <param name="f">First Name of the Prisoner</param>
        /// <param name="l">Last Nmame of the Prisoner</param>
        /// <param name="doB">Date of Birth of the Prisoner</param>
        /// <param name="sex">Sex of the Prisoner</param>
        /// <param name="cell">Cell that Prisoner lives in</param>
        public Prisoner(int id, String f, String l, String doB, String sex, Cell cell)
        {
            this.id = id;
            this.fName = f;
            this.lName = l;
            this.dateOfBirth = doB;
            this.sex = sex;
            this.cell = cell;
        }

        /// <summary>
        /// Generates a list of Prisoners that live in a given Cell.  It also
        /// produces of list of each Prisoner's offenses
        /// </summary>
        /// <param name="c">The Cell that the prisoners live in</param>
        /// <returns>A list of Prisoners that live in c</returns>
        public static List<Prisoner> Generate(Cell c)
        {
            String str = "select * from prisoner where cellId='" + c.id + "'";
            MySql.Data.MySqlClient.MySqlDataReader rdr = MySqlManager.MySqlManager.Instance.ExecuteReader(str);
            if (rdr == null)
            {
                throw new Exception("Reading prisoners failed.");
            }
            List<Prisoner> list = new List<Prisoner>();
            while (rdr.Read())
            {
                list.Add(new Prisoner(Convert.ToInt32(rdr["id"]), rdr["fName"].ToString(), rdr["lName"].ToString(), rdr["dateOfBirth"].ToString(), rdr["sex"].ToString(), c));
            }
            rdr.Close();
            foreach(Prisoner p in list)
            {
                p.offenses = Offense.Generate(p);
            }
            return list;
        }

        /// <summary>
        /// Deletes a Prisoner from the database
        /// </summary>
        /// <param name="id">The ID of the prisoner to be deleted</param>
        /// <returns>True if the deletion was successful, false otherwise</returns>
        public static bool Delete(int id)
        {
            String str = "delete from prisoner where id='" + id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// Adds a new Prisoner to the database requires all data
        /// except for any offenses the prisoner has created
        /// </summary>
        /// <returns>True if the addition was successful, false otherwise</returns>
        public static bool Add(String f, String l, String doB, String sex, int cellId)
        {
            String str = "insert into prisoner(fName, lName, dateOfBirth, sex, cellId) values ('" + f + "', '" + l + "', '" + doB + "', '" + sex + "', '" + cellId.ToString() + "')";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// Updates the prisoner tied to the given ID with the given data
        /// </summary>
        /// <returns>True if the update was successful, false otherwise</returns>
        public static bool Update(int id, String f, String l, String doB, String sex, int cellId)
        {
            String str = "update prisoner set fName='" + f + "', lName='" + l + "', dateOfBirth='" + doB + "', sex='" + sex + "', cellId='" + cellId + "' where id='" + id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
