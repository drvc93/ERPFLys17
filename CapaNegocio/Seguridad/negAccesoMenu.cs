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
    public class negAccesoMenu
    {
        public static List<entAccesoMenu> ListaFormID()
        {
            List<entAccesoMenu> ListObj = new List<entAccesoMenu>();
            ListObj = datAccesoMenu.ListaFormID().ToList<entAccesoMenu>();
            return ListObj;
        }

        public static entAccesoMenu GetFormID(String Usuario, String Aplicacion, String Niveles)
        {
            entAccesoMenu EObj = new entAccesoMenu();
            List<entAccesoMenu> ListObj = new List<entAccesoMenu>();
            ListObj = datAccesoMenu.GetFormID(Usuario, Aplicacion, Niveles).ToList<entAccesoMenu>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entAccesoMenu> ListaUsuarioApp(String Usuario, String Aplicacion)
        {
            List<entAccesoMenu> ListObj = new List<entAccesoMenu>();
            ListObj = datAccesoMenu.ListaUsuarioApp(Usuario, Aplicacion).ToList<entAccesoMenu>();
            return ListObj;
        }

        public static entErrores MantFormID(entAccesoMenu Data)
        {
            return datAccesoMenu.MantFormID(Data);
        }

        public static List<entAccesoMenu> ListaMenuMaestro(String Usuario)
        {
            List<entAccesoMenu> ListObj = new List<entAccesoMenu>();
            ListObj = datAccesoMenu.ListaMenuMaestro(Usuario).ToList<entAccesoMenu>();
            return ListObj;
        }

    }
}
