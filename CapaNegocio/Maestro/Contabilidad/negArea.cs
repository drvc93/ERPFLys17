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
    public class negArea
    {
        public static List<entArea> ListaFormID()
        {
            List<entArea> ListObj = new List<entArea>();
            ListObj = datArea.ListaFormID().ToList<entArea>();
            return ListObj;
        }

        public static entArea GetFormID(String Area)
        {
            entArea EObj = new entArea();
            List<entArea> ListObj = new List<entArea>();
            ListObj = datArea.GetFormID(Area).ToList<entArea>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entArea> ListaCombo(String Estado, String[] Def = null)
        {
            List<entArea> ListObj = new List<entArea>();
            ListObj = datArea.ListaCombo(Estado).ToList<entArea>();
            if (Def != null){
                ListObj.Insert(0, new entArea() { Areas = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entArea> ListaSearch(String Area, String Descripcion, String Estado)
        {
            List<entArea> ListObj = new List<entArea>();
            ListObj = datArea.ListaSearch(Area, Descripcion, Estado).ToList<entArea>();
            return ListObj;
        }
        
        public static entErrores MantFormID(entArea Data)
        {
            return datArea.MantFormID(Data);
        }

    }
}
