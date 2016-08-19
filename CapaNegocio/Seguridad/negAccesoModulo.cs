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
    public class negAccesoModulo
    {
        public static List<entAccesoModulo> ListaFormID()
        {
            List<entAccesoModulo> ListObj = new List<entAccesoModulo>();
            ListObj = datAccesoModulo.ListaFormID().ToList<entAccesoModulo>();
            return ListObj;
        }

        public static entAccesoModulo GetFormID(String Usuario, String Aplicacion)
        {
            entAccesoModulo EObj = new entAccesoModulo();
            List<entAccesoModulo> ListObj = new List<entAccesoModulo>();
            ListObj = datAccesoModulo.GetFormID(Usuario, Aplicacion).ToList<entAccesoModulo>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static entErrores MantFormID(entAccesoModulo Data)
        {
            return datAccesoModulo.MantFormID(Data);
        }

    }
}
