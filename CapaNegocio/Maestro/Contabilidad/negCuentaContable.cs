using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Domain.Maestro.RRHH;
using FiltroLys.Model.Tesoreria;
using FiltroLys.Domain.Tesoreria;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.Model.Contabilidad;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negCuentaContable
    {
        public static List<entCuentaContable> ListaFormID()
        {
            List<entCuentaContable> ListObj = new List<entCuentaContable>();
            ListObj = datCuentaContable.ListaFormID().ToList<entCuentaContable>();
            return ListObj;
        }

        public static entCuentaContable GetFormID(String Cuenta)
        {
            entCuentaContable EObj = new entCuentaContable();
            List<entCuentaContable> ListObj = new List<entCuentaContable>();
            ListObj = datCuentaContable.GetFormID(Cuenta).ToList<entCuentaContable>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCuentaContable> ListaCombo(String Estado, String[] Def = null)
        {
            List<entCuentaContable> ListObj = new List<entCuentaContable>();
            ListObj = datCuentaContable.ListaCombo(Estado).ToList<entCuentaContable>();
            if (Def != null){
                ListObj.Insert(0, new entCuentaContable() { Cuenta = Def[0], Nombres = Def[1] });
            }
            return ListObj;
        }

        public static List<entCuentaContable> ListaSearch(String Cuenta, String Nombre, String Estado)
        {
            List<entCuentaContable> ListObj = new List<entCuentaContable>();
            ListObj = datCuentaContable.ListaSearch(Cuenta, Nombre, Estado).ToList<entCuentaContable>();
            return ListObj;
        }

        public static entErrores MantFormID(entCuentaContable Data)
        {
            return datCuentaContable.MantFormID(Data);
        }

    }
}
