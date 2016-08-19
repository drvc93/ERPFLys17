using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Seguridad
{
    public class tsqSeguridad
    {
        static String xsql = "";
        
        public static String UP_ListMenuMaestros() {
            xsql = "SP_SYS_MENUOPCIONNET";
            return xsql;
        }

        public static String UP_ListMenuReportes()
        {
            xsql = "SP_SYS_REPORTOPCIONNET";
            return xsql;
        }

    }
}
