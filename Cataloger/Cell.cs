using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    class Cell
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description;
        public CellBlock block;
        public List<Prisoner> prisoners;

        public Cell(int id, String name, String description, CellBlock block)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.block = block;
        }

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
    }
}
