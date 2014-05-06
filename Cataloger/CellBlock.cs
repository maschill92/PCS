using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    /// <summary>
    /// Class that represents a CellBlock.  It references the Prison that contains it
    /// and a list of cells are contained by the CellBlock
    /// </summary>
    class CellBlock
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description;
        public Prison prison;
        public List<Cell> cells;

        /// <summary>
        /// Constructor that accepts all class fields except prisoners which is generated in the Generate function
        /// </summary>
        /// <param name="id">The id of the CellBlock</param>
        /// <param name="name">The name of the CellBlock</param>
        /// <param name="description">The description of the CellBlock</param>
        /// <param name="prison">The prison where the CellBlock is</param>
        public CellBlock(int id, String name, String description, Prison prison)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.prison = prison;
        }

        /// <summary>
        /// Returns of list of CellBlocks contained in a given Prison
        /// It then generates a list of Cells that each CellBlock contains
        /// </summary>
        /// <param name="prison">The Prison that contains each CellBlock generated</param>
        /// <returns>A list of CellBlock objects that are contained in prison</returns>
        public static List<CellBlock> Generate(Prison prison)
        {
            String str = "select * from cell_block where prisonId='" + prison.id + "'";
            MySql.Data.MySqlClient.MySqlDataReader rdr = MySqlManager.MySqlManager.Instance.ExecuteReader(str);
            if (rdr == null)
            {
                throw new Exception("Reading cell blocks failed.");
            }
            List<CellBlock> list = new List<CellBlock>();
            while (rdr.Read())
            {
                list.Add(new CellBlock(Convert.ToInt32(rdr["id"]), rdr["name"].ToString(), rdr["description"].ToString(), prison));
            }
            rdr.Close();
            foreach (CellBlock cb in list)
            {
                cb.cells = Cell.Generate(cb);
            }
            return list;
        }

        /// <summary>
        /// Updates the CellBlock's information
        /// </summary>
        /// <param name="name">New name</param>
        /// <param name="description">New description</param>
        /// <returns>True if update was successful, false otherwise</returns>
        public bool Update(String name, String description)
        {
            String str = "update cell_block set name='" + name + "', description='" + description + "' where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// Deletes the CellBlock from the database
        /// </summary>
        /// <returns>True if the deletion was successful, false otherwise</returns>
        public bool Delete()
        {
            String str = "delete from cell_block where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="prisonId"></param>
        /// <returns>True if the deletion was successful, false otherwise</returns>
        public static bool Add(String name, String description, int prisonId)
        {
            String str = "insert into cell_block (name, description, prisonId) values ('" + name + "', '" + description + "', '" + prisonId.ToString() + "')";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
