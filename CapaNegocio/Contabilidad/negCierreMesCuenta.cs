using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using FiltroLys.Model.Objeto;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Repository.Contabilidad;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Type;

namespace FiltroLys.Domain.Contabilidad
{
    public class negCierreMesCuenta
    {
        public static List<entCierreMesCuenta> ListaFormID(String Compania)
        {
            List<entCierreMesCuenta> ListObj = new List<entCierreMesCuenta>();
            ListObj = datCierreMesCuenta.ListaFormID(Compania).ToList<entCierreMesCuenta>();
            return ListObj;
        }

        public static entCierreMesCuenta GetFormID(String Compania,String Periodo, String Cuenta)
        {
            entCierreMesCuenta EObj = new entCierreMesCuenta();
            List<entCierreMesCuenta> ListObj = new List<entCierreMesCuenta>();
            ListObj = datCierreMesCuenta.GetFormID(Compania,Periodo,Cuenta).ToList<entCierreMesCuenta>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static entErrores MantFormID(entCierreMesCuenta Data)
        {
            return datCierreMesCuenta.MantFormID(Data);
        }

        public static List<entCierreMesCuenta> ListSaldoToMayor(String Compania, String Periodo)
        {
            List<entCierreMesCuenta> ListObj = new List<entCierreMesCuenta>();
            ListObj = datCierreMesCuenta.ListSaldoToMayor(Compania, Periodo).ToList<entCierreMesCuenta>();
            return ListObj;
        }

        public static List<entCierreMesCuenta> ListSaldoToCuenta(String Compania, String Periodo, String Mayor)
        {
            List<entCierreMesCuenta> ListObj = new List<entCierreMesCuenta>();
            ListObj = datCierreMesCuenta.ListSaldoToCuenta(Compania, Periodo, Mayor).ToList<entCierreMesCuenta>();
            return ListObj;
        }

        public static List<entFail> GetRevisionMensual(String Compania, String Periodo, String Operacion)
        {
            List<entFail> ListObj = new List<entFail>();
            ListObj = datCierreMesCuenta.GetRevisionMensual(Compania, Periodo, Operacion).ToList<entFail>();
            return ListObj;
        }

        public static String SetProcesoMensual(String Compania, String Periodo, String Usuario)
        {
            return datCierreMesCuenta.SetProcesoMensual(Compania, Periodo, Usuario);
        }

        public static String GetPeriodoSiguiente(String Periodo)
        {
            return datCierreMesCuenta.GetPeriodoSiguiente(Periodo);
        }

    }
}
