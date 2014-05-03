using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    class CellBlock
    {
        public int id { get; set; }
        public String name { get; set; }
        public String description;
        public Prison prison;
        public List<Cell> cells;

        public CellBlock(int id, String name, String description, Prison prison)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.prison = prison;
        }

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

        public bool Update(String name, String description)
        {
            String str = "update cell_block set name='" + name + "', description='" + description + "' where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        public bool Delete()
        {
            String str = "delete from cell_block where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        public static bool Add(String name, String description, int prisonId)
        {
            String str = "insert into cell_block (name, description, prisonId) values ('" + name + "', '" + description + "', '" + prisonId.ToString() + "')";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
