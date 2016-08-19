using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Sistema;
using FiltroLys.Repository.Sistema;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Sistema
{
    public class negMenu
    {
        public static List<entMenu> ListaFormID()
        {
            List<entMenu> ListObj = new List<entMenu>();
            ListObj = datMenu.ListaFormID().ToList<entMenu>();
            return ListObj;
        }

        public static entMenu GetFormID(String AplicacionCodigo, Int32 Nivel1, Int32 Nivel2, Int32 Nivel3, Int32 Nivel4, Int32 Nivel5)
        {
            entMenu EObj = new entMenu();
            List<entMenu> ListObj = new List<entMenu>();
            ListObj = datMenu.GetFormID(AplicacionCodigo, Nivel1, Nivel2, Nivel3, Nivel4, Nivel5).ToList<entMenu>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static entErrores MantFormID(entMenu Data)
        {
            return datMenu.MantFormID(Data);
        }

    }
}
