using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS
{
    public class DataCataloger : User
    {
        public DataCataloger() { }
        public DataCataloger(String u, String p, String fN, String lN, String e, String s, String d)
        {
            this.username = u;
            this.password = p;
            this.fName = fN;
            this.lName = lN;
            this.email = e;
            this.sex = s;
            this.dateOfBirth = d;
        }
    }
}
