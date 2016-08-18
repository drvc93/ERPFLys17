using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Tesoreria;
using FiltroLys.Repository.Tesoreria;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Tesoreria
{
    public class negObligacion
    {
        public static List<entObligacion> ListaFormID(String Compania)
        {
            List<entObligacion> ListObj = new List<entObligacion>();
            ListObj = datObligacion.ListaFormID(Compania).ToList<entObligacion>();
            return ListObj;
        }

        public static entObligacion GetFormID(String Compania, String Obligacion)
        {
            entObligacion EObj = new entObligacion();
            List<entObligacion> ListObj = new List<entObligacion>();
            ListObj = datObligacion.GetFormID(Compania, Obligacion).ToList<entObligacion>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entObligacion> ListaSearch(String Compania, String TipoDocumento, String NumeroDocumento, String Estado)
        {
            List<entObligacion> ListObj = new List<entObligacion>();
            ListObj = datObligacion.ListaSearch(Compania, TipoDocumento, NumeroDocumento,Estado).ToList<entObligacion>();
            return ListObj;
        }

        public static List<entObligacion> ListaToVoucher(String Compania, Int32 CodProveedor, String TipoDocumento, String NumeroDocumento, String Estado)
        {
            List<entObligacion> ListObj = new List<entObligacion>();
            ListObj = datObligacion.ListaToVoucher(Compania, CodProveedor, TipoDocumento, NumeroDocumento, Estado).ToList<entObligacion>();
            return ListObj;
        }

        public static Int32 GetNumObligacion(String Compania, Int32 CodProveedor, String TipoDocumento, String NumeroDocumento) {
            return datObligacion.GetNumObligacion(Compania, CodProveedor, TipoDocumento, NumeroDocumento);
        }

        public static entErrores MantFormID(entObligacion Data)
        {
            return datObligacion.MantFormID(Data);
        }

    }
}
