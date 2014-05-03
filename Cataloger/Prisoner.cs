﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cataloger
{
    class Prisoner
    {
        public int id;
        public String fName;
        public String lName;
        public String dateOfBirth;
        public String sex;
        public Cell cell;
        public List<Offense> offenses;

        public Prisoner(int id, String f, String l, String doB, String sex, Cell cell)
        {
            this.id = id;
            this.fName = f;
            this.lName = l;
            this.dateOfBirth = doB;
            this.sex = sex;
            this.cell = cell;
        }

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
    }
}