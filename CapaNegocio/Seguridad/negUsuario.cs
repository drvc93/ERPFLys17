using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Seguridad;
using FiltroLys.Repository.Seguridad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Seguridad
{
    public class negUsuario
    {
        public static List<entUsuario> ListaFormID()
        {
            List<entUsuario> ListObj = new List<entUsuario>();
            ListObj = datUsuario.ListaFormID().ToList<entUsuario>();
            return ListObj;
        }

        public static entUsuario GetFormID(String Codigo)
        {
            entUsuario EObj = new entUsuario();
            List<entUsuario> ListObj = new List<entUsuario>();
            ListObj = datUsuario.GetFormID(Codigo).ToList<entUsuario>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entUsuario> ListaCombo(String Estado, String[] Def = null)
        {
            List<entUsuario> ListObj = new List<entUsuario>();
            ListObj = datUsuario.ListaCombo(Estado).ToList<entUsuario>();
            if (Def != null){
                ListObj.Insert(0, new entUsuario() { CodigoUsuario = Def[0], Nombre = Def[1] });
            }
            return ListObj;
        }

        public static List<entUsuario> ListaSearch(String Codigo, String Nombre, String CentroCosto, String Estado)
        {
            List<entUsuario> ListObj = new List<entUsuario>();
            ListObj = datUsuario.ListaSearch(Codigo, Nombre, CentroCosto, Estado).ToList<entUsuario>();
            return ListObj;
        }

        public static entErrores MantFormID(entUsuario Data)
        {
            return datUsuario.MantFormID(Data);
        }

        public static Int32 GetValidarAcceso(String Usuario, String Clave) {
            return datUsuario.GetValidarAcceso(Usuario, Clave);
        }

    }
}
