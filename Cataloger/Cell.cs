using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    /// <summary>
    /// Class that represents a Cell.  It references the CellBlock that contains it
    /// and a list of prisoners that live in the Cell
    /// </summary>
    class Cell
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description;
        public CellBlock block;
        public List<Prisoner> prisoners;

        /// <summary>
        /// Constructor that accepts all class fields except prisoners which is generated in the Generate function
        /// </summary>
        /// <param name="id">The id of the cell</param>
        /// <param name="name">The name of the cell</param>
        /// <param name="description">The description of the cell</param>
        /// <param name="block">The block of the cell</param>
        public Cell(int id, String name, String description, CellBlock block)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.block = block;
        }

        /// <summary>
        /// Returns of list of Cells contained in a given CellBlock
        /// It then generates a list of prisoners that live each cell generated
        /// </summary>
        /// <param name="cellBlock">The CellBlock that contains the Cells to be generated</param>
        /// <returns>A list of Cell objects that are contained in cellBlock</returns>
        public static List<Cell> Generate(CellBlock cellBlock)
        {
            String str = "select * from cell where blockId='" + cellBlock.id + "'";
            MySql.Data.MySqlClient.MySqlDataReader rdr = MySqlManager.MySqlManager.Instance.ExecuteReader(str);
            if (rdr == null)
            {
                throw new Exception("Reading cells failed.");
            }
            List<Cell> list = new List<Cell>();
            while (rdr.Read())
            {
                list.Add(new Cell(Convert.ToInt32(rdr["id"]), rdr["name"].ToString(), rdr["description"].ToString(), cellBlock));
            }
            rdr.Close();
            foreach(Cell c in list)
            {
                c.prisoners = Prisoner.Generate(c);
            }
            return list;
        }

        /// <summary>
        /// Updates the Cell's information
        /// </summary>
        /// <param name="name">New name</param>
        /// <param name="description">New description</param>
        /// <returns>True if update was successful, false otherwise</returns>
        public bool Update(String name, String description)
        {
            String str = "update cell set name='" + name + "', description='" + description + "' where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// Deletes the Cell from the database
        /// </summary>
        /// <returns>True if the deletion was successful, false otherwise</returns>
        public bool Delete()
        {
            String str = "delete from cell where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        /// <summary>
        /// Adds a new Cell to the database
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="blockId">ID of the CellBlock that will contain the new Cell</param>
        /// <returns>True if the deletion was successful, false otherwise</returns>
        public static bool Add(String name, String description, int blockId)
        {
            String str = "insert into cell (name, description, blockId) values ('" + name + "', '" + description + "', '" + blockId.ToString() + "')";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
