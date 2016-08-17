using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Mantenimiento;
using FiltroLys.Repository.Maestro.Mantenimiento;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Domain.Maestro.Mantenimiento
{
    public class negMaquina
    {
        public static List<entMaquina> ListaFormID(String Compania)
        {
            List<entMaquina> ListObj = new List<entMaquina>();
            ListObj = datMaquina.ListaFormID(Compania).ToList<entMaquina>();
            return ListObj;
        }

        public static entMaquina GetFormID(String Compania, String Maquina)
        {
            entMaquina EObj = new entMaquina();
            List<entMaquina> ListObj = new List<entMaquina>();
            ListObj = datMaquina.GetFormID(Compania, Maquina).ToList<entMaquina>();
            if (ListObj.Count > 0)
            {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entMaquina> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entMaquina> ListObj = new List<entMaquina>();
            ListObj = datMaquina.ListaCombo(Compania, Estado).ToList<entMaquina>();
            if (Def != null){
                ListObj.Insert(0, new entMaquina() { Maquina = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entMaquina> ListaSearch(String Compania, String Maquina, String Descripcion, String Estado)
        {
            List<entMaquina> ListObj = new List<entMaquina>();
            ListObj = datMaquina.ListaSearch(Compania, Maquina, Descripcion, Estado).ToList<entMaquina>();
            return ListObj;
        }

        public static entErrores MantFormID(entMaquina Data)
        {
            return datMaquina.MantFormID(Data);
        }

    }
}
