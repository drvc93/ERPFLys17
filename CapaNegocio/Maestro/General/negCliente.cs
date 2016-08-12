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
    public class negCliente
    {
        public static List<entCliente> ListaFormID(String Compania)
        {
            List<entCliente> ListObj = new List<entCliente>();
            ListObj = datCliente.ListaFormID(Compania).ToList<entCliente>();
            return ListObj;
        }

        public static entCliente GetFormID(String Compania, Int32 Cliente)
        {
            entCliente EObj = new entCliente();
            List<entCliente> ListObj = new List<entCliente>();
            ListObj = datCliente.GetFormID(Compania, Cliente).ToList<entCliente>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCliente> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entCliente> ListObj = new List<entCliente>();
            ListObj = datCliente.ListaCombo(Compania, Estado).ToList<entCliente>();
            if (Def != null){
                ListObj.Insert(0, new entCliente() { Cliente = Int32.Parse(Def[0]), RazonSocial = Def[1] });
            }
            return ListObj;
        }

        public static List<entCliente> ListaSearch(String Compania, Int32 Cliente, String RazonSocial, String Documento, String DocumentoFiscal, String Estado)
        {
            List<entCliente> ListObj = new List<entCliente>();
            ListObj = datCliente.ListaSearch(Compania, Cliente, RazonSocial, Documento, DocumentoFiscal, Estado).ToList<entCliente>();
            return ListObj;
        }

        public static entErrores MantFormID(entCliente Data)
        {
            return datCliente.MantFormID(Data);
        }

        public static Boolean GetExisteCliente(String Compania, Int32 Cliente){
            entCliente EObj = GetFormID(Compania, Cliente);
            Boolean bvalor = EObj.ResultadoBusqueda;
            EObj = null;
            return bvalor;
        }

    }
}
