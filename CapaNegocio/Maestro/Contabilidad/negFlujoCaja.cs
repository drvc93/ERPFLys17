using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negFlujoCaja
    {
        public static List<entFlujoCaja> ListaFormID()
        {
            List<entFlujoCaja> ListObj = new List<entFlujoCaja>();
            ListObj = datFlujoCaja.ListaFormID().ToList<entFlujoCaja>();
            return ListObj;
        }

        public static entFlujoCaja GetFormID(String FlujoCaja)
        {
            entFlujoCaja EObj = new entFlujoCaja();
            List<entFlujoCaja> ListObj = new List<entFlujoCaja>();
            ListObj = datFlujoCaja.GetFormID(FlujoCaja).ToList<entFlujoCaja>();
            if (ListObj.Count > 0)
            {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entFlujoCaja> ListaCombo(String Estado, String[] Def = null)
        {
            List<entFlujoCaja> ListObj = new List<entFlujoCaja>();
            ListObj = datFlujoCaja.ListaCombo(Estado).ToList<entFlujoCaja>();
            if (Def != null)
            {
                ListObj.Insert(0, new entFlujoCaja() { FlujoCaja = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entFlujoCaja> ListaSearch(String FlujoCaja, String Descripcion, String Estado)
        {
            List<entFlujoCaja> ListObj = new List<entFlujoCaja>();
            ListObj = datFlujoCaja.ListaSearch(FlujoCaja, Descripcion, Estado).ToList<entFlujoCaja>();
            return ListObj;
        }

        public static entErrores MantFormID(entFlujoCaja Data)
        {
            return datFlujoCaja.MantFormID(Data);
        }

    }
}
