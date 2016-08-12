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
    public class negProveedor
    {
        public static List<entProveedor> ListaFormID(String Compania)
        {
            List<entProveedor> ListObj = new List<entProveedor>();
            ListObj = datProveedor.ListaFormID(Compania).ToList<entProveedor>();
            return ListObj;
        }

        public static entProveedor GetFormID(String Compania, Int32 Proveedor)
        {
            entProveedor EObj = new entProveedor();
            List<entProveedor> ListObj = new List<entProveedor>();
            ListObj = datProveedor.GetFormID(Compania, Proveedor).ToList<entProveedor>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entProveedor> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entProveedor> ListObj = new List<entProveedor>();
            ListObj = datProveedor.ListaCombo(Compania, Estado).ToList<entProveedor>();
            if (Def != null){
                ListObj.Insert(0, new entProveedor() { Proveedor = Int32.Parse(Def[0]), RazonSocial = Def[1] });
            }
            return ListObj;
        }

        public static List<entProveedor> ListaSearch(String Compania, Int32 Proveedor, String RazonSocial, String DocumentoFiscal, String Estado)
        {
            List<entProveedor> ListObj = new List<entProveedor>();
            ListObj = datProveedor.ListaSearch(Compania, Proveedor, RazonSocial,  DocumentoFiscal, Estado).ToList<entProveedor>();
            return ListObj;
        }

        public static entErrores MantFormID(entProveedor Data)
        {
            return datProveedor.MantFormID(Data);
        }

        public static Boolean GetExisteProveedor(String Compania, Int32 Proveedor)
        {
            entProveedor EObj = GetFormID(Compania, Proveedor);
            Boolean bvalor = EObj.ResultadoBusqueda;
            EObj = null;
            return bvalor;
        }

    }
}
