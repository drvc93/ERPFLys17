using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negAsientoModelo
    {
        public static List<entAsientoModelo> ListaFormID()
        {
            List<entAsientoModelo> ListObj = new List<entAsientoModelo>();
            ListObj = datAsientoModelo.ListaFormID().ToList<entAsientoModelo>();
            return ListObj;
        }

        public static entAsientoModelo GetFormID(String Compania,String Modelo)
        {
            entAsientoModelo EObj = new entAsientoModelo();
            List<entAsientoModelo> ListObj = new List<entAsientoModelo>();
            ListObj = datAsientoModelo.GetFormID(Compania, Modelo).ToList<entAsientoModelo>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entAsientoModelo> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entAsientoModelo> ListObj = new List<entAsientoModelo>();
            ListObj = datAsientoModelo.ListaCombo(Compania,Estado).ToList<entAsientoModelo>();
            if (Def != null){
                ListObj.Insert(0, new entAsientoModelo() { Modelo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entAsientoModelo> ListaSearch(String Compania,String Modelo, String Descripcion, String Estado)
        {
            List<entAsientoModelo> ListObj = new List<entAsientoModelo>();
            ListObj = datAsientoModelo.ListaSearch(Compania, Modelo, Descripcion, Estado).ToList<entAsientoModelo>();
            return ListObj;
        }

        public static entErrores MantFormID(entAsientoModelo Data)
        {
            return datAsientoModelo.MantFormID(Data);
        }

    }
}
