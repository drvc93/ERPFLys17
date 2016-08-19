using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Sistema
{
    public class entBaseDato
    {
        private String c_DataBase;
        private Int32 n_IdReg;

        public Int32 IdReg
        {
            get { return n_IdReg; }
            set { n_IdReg = value; }
        }

        public String DataBase
        {
            get { return c_DataBase; }
            set { c_DataBase = value; }
        }

    }
}
