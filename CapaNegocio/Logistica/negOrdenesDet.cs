using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Logistica;
using FiltroLys.Repository.Logistica;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Logistica
{
    public class negOrdenesDet
    {
        public static List<entOrdenesDet> ListaFormID(String Compania, String NumeroOrden)
        {
            List<entOrdenesDet> ListObj = new List<entOrdenesDet>();
            ListObj = datOrdenesDet.ListaFormID(Compania, NumeroOrden).ToList<entOrdenesDet>();
            return ListObj;
        }

        public static entOrdenesDet GetFormID(String Compania, String NumeroOrden, Int32 Ampliacion)
        {
            entOrdenesDet EObj = new entOrdenesDet();
            List<entOrdenesDet> ListObj = new List<entOrdenesDet>();
            ListObj = datOrdenesDet.GetFormID(Compania, NumeroOrden, Ampliacion).ToList<entOrdenesDet>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entOrdenesDet> ListaToVoucher(String Compania, String NumeroOrden, Int32 Ampliacion)
        {
            List<entOrdenesDet> ListObj = new List<entOrdenesDet>();
            ListObj = datOrdenesDet.ListaToVoucher(Compania, NumeroOrden, Ampliacion).ToList<entOrdenesDet>();
            return ListObj;
        }
        
        public static entErrores MantFormID(entOrdenesDet Data)
        {
            return datOrdenesDet.MantFormID(Data);
        }

    }
}
