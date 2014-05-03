using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    class Prison
    {
        public int id { get; set; }
        public String name { get; set; }
        public String location;
        public String description;
        public List<CellBlock> blocks;

        public Prison(int id, String name, String location, String description)
        {
            this.id = id;
            this.name = name;
            this.location = location;
            this.description = description;
        }

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

        public bool Update(String name, String location, String description)
        {
            String str = "update prison set name='" + name + "', location='" + location + "', description='" + description + "' where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        public bool Delete()
        {
            String str = "delete from prison where id='" + this.id + "'";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }

        public static bool Add(String name, String location, String description)
        {
            String str = "insert into prison (name, location, description) values ('" + name + "', '" + location + "', '" + description + "')";
            bool ret = MySqlManager.MySqlManager.Instance.ExecuteNonQuery(str);
            return ret;
        }
    }
}
