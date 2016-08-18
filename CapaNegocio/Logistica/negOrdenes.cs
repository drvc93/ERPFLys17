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
    public class negOrdenes
    {
        public static List<entOrdenes> ListaFormID(String Compania)
        {
            List<entOrdenes> ListObj = new List<entOrdenes>();
            ListObj = datOrdenes.ListaFormID(Compania).ToList<entOrdenes>();
            return ListObj;
        }

        public static entOrdenes GetFormID(String Compania, String NumeroOrden, Int32 Ampliacion)
        {
            entOrdenes EObj = new entOrdenes();
            List<entOrdenes> ListObj = new List<entOrdenes>();
            ListObj = datOrdenes.GetFormID(Compania, NumeroOrden, Ampliacion).ToList<entOrdenes>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entOrdenes> ListaToVoucher(String Compania)
        {
            List<entOrdenes> ListObj = new List<entOrdenes>();
            ListObj = datOrdenes.ListaToVoucher(Compania).ToList<entOrdenes>();
            return ListObj;
        }
        
        public static entErrores MantFormID(entOrdenes Data)
        {
            return datOrdenes.MantFormID(Data);
        }

    }
}
