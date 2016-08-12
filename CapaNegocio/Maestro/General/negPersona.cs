using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Repository.Maestro.General;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Domain.Maestro.General
{
    public class negPersona
    {
        public static List<entPersona> ListaFormID(String Compania)
        {
            List<entPersona> ListObj = new List<entPersona>();
            ListObj = datPersona.ListaFormID(Compania).ToList<entPersona>();
            return ListObj;
        }

        public static entPersona GetFormID(String Compania, Int32 Persona)
        {
            entPersona EObj = new entPersona();
            List<entPersona> ListObj = new List<entPersona>();
            ListObj = datPersona.GetFormID(Compania, Persona).ToList<entPersona>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entPersona> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entPersona> ListObj = new List<entPersona>();
            ListObj = datPersona.ListaCombo(Compania, Estado).ToList<entPersona>();
            if (Def != null){
                ListObj.Insert(0, new entPersona() { Persona = Int32.Parse(Def[0]), NombreCompleto = Def[1] });
            }
            return ListObj;
        }

        public static List<entPersona> ListaSearch(String Compania, Int32 Persona, String NombreCompleto, String DocumentoIdentidad, String DocumentoFiscal, String Estado,
                                            String EsEmpleado, String EsProveedor, String EsCliente)
        {
            List<entPersona> ListObj = new List<entPersona>();
            ListObj = datPersona.ListaSearch(Compania, Persona, NombreCompleto, DocumentoIdentidad, DocumentoFiscal, Estado, EsEmpleado, EsProveedor, EsCliente).ToList<entPersona>();
            return ListObj;
        }

        public static entErrores MantFormID(entPersona Data)
        {
            return datPersona.MantFormID(Data);
        }

    }
}
