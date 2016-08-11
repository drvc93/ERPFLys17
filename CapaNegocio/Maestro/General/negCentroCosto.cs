using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Repository.Maestro.General;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.General
{
    public class negCentroCosto
    {
        public static List<entCentroCosto> ListaFormID()
        {
            List<entCentroCosto> ListObj = new List<entCentroCosto>();
            ListObj = datCentroCosto.ListaFormID().ToList<entCentroCosto>();
            return ListObj;
        }

        public static entCentroCosto GetFormID(String Compania, String CentroCosto)
        {
            entCentroCosto EObj = new entCentroCosto();
            List<entCentroCosto> ListObj = new List<entCentroCosto>();
            ListObj = datCentroCosto.GetFormID(Compania, CentroCosto).ToList<entCentroCosto>();
            if (ListObj.Count > 0) {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCentroCosto> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entCentroCosto> ListObj = new List<entCentroCosto>();
            ListObj = datCentroCosto.ListaCombo(Compania, Estado).ToList<entCentroCosto>();
            if (Def != null){
                ListObj.Insert(0, new entCentroCosto() { CentroCosto = Def[0], Nombres = Def[1] });
            }
            return ListObj;
        }

        public static List<entCentroCosto> ListaSearch(String Compania, String CentroCosto, String Nombre, String Estado)
        {
            List<entCentroCosto> ListObj = new List<entCentroCosto>();
            ListObj = datCentroCosto.ListaSearch(Compania, CentroCosto, Nombre, Estado).ToList<entCentroCosto>();
            return ListObj;
        }

        public static entErrores MantFormID(entCentroCosto Data)
        {
            return datCentroCosto.MantFormID(Data);
        }

    }
}
