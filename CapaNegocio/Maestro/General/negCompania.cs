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
    public class negCompania
    {
        public static List<entCompania> ListaFormID()
        {
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.ListaFormID().ToList<entCompania>();
            return ListObj;
        }

        public static entCompania GetFormID(String Compania)
        {
            entCompania EObj = new entCompania();
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.GetFormID(Compania).ToList<entCompania>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCompania> ListaCombo(String Estado, String[] Def = null)
        {
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.ListaCombo(Estado).ToList<entCompania>();
            if (Def != null){
                ListObj.Insert(0, new entCompania() { Compania = Def[0], Nombres = Def[1] });
            }
            return ListObj;
        }

        public static List<entCompania> ListaSearch(String Compania, String Nombre, String DocumentoFiscal, String Estado)
        {
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.ListaSearch(Compania, Nombre, DocumentoFiscal,Estado).ToList<entCompania>();
            return ListObj;
        }

        public static List<entCompania> ListaXUsuario(String App, String Usuario, String SoloActivo, String[] Def = null)
        {
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.ListaXUsuario(App, Usuario, SoloActivo).ToList<entCompania>();
            if (Def != null){
                ListObj.Insert(0, new entCompania() { Compania = Def[0], Nombres = Def[1] });
            }
            return ListObj;
        }

        public static entErrores MantCompania(entCompania Data)
        {
            return datCompania.MantCompania(Data);
        }

        public static String GetDatosNombre(String Compania){
            String sCiaNombre = "";
            entCompania oEnt = GetFormID(Compania);
            if(oEnt.ResultadoBusqueda){
                sCiaNombre = oEnt.Nombres;
            }
            oEnt = null;
            return sCiaNombre;
        }

        public static String GetDatosDocFiscal(String Compania)
        {
            String sDocFiscal = "";
            entCompania oEnt = GetFormID(Compania);
            if (oEnt.ResultadoBusqueda){
                sDocFiscal = oEnt.DocumentoFiscal;
            }
            oEnt = null;
            return sDocFiscal;
        }

    }
}
