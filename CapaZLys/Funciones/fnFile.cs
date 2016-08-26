using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiltroLys.Type;
using System.Data;
using System.IO;
using FiltroLys.Domain.Sistema;

namespace FiltroLys.ZLys.Funciones
{
    public class fnFile
    {
        public static Boolean ExisteDirectorio(String sRuta){
            return Directory.Exists(sRuta);
        }
        
    }
}
