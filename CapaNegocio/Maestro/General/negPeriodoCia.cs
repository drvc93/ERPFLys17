using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Repository.Maestro.General;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.General
{
    public class negPeriodoCia
    {
        public static List<entPeriodoCia> ListaFormID(String Sistema)
        {
            List<entPeriodoCia> ListObj = new List<entPeriodoCia>();
            ListObj = datPeriodoCia.ListaFormID(Sistema).ToList<entPeriodoCia>();
            return ListObj;
        }

        public static entPeriodoCia GetFormID(String Compania, String Periodo, String Sistema)
        {
            entPeriodoCia EObj = new entPeriodoCia();
            List<entPeriodoCia> ListObj = new List<entPeriodoCia>();
            ListObj = datPeriodoCia.GetFormID(Compania, Periodo, Sistema).ToList<entPeriodoCia>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entPeriodoCia> ListaCombo(String Compania, String Sistema, String Estado, String[] Def = null)
        {
            List<entPeriodoCia> ListObj = new List<entPeriodoCia>();
            ListObj = datPeriodoCia.ListaCombo(Compania, Sistema, Estado).ToList<entPeriodoCia>();
            if (Def != null){
                ListObj.Insert(0, new entPeriodoCia() { Periodo = Def[1] });
            }
            return ListObj;
        }

        public static List<entPeriodoCia> ListaSearch(String Compania, String Periodo, String Sistema, String Estado, String FlagBloqueo, String FlagTrabajo)
        {
            List<entPeriodoCia> ListObj = new List<entPeriodoCia>();
            ListObj = datPeriodoCia.ListaSearch(Compania, Periodo, Sistema, Estado, FlagBloqueo, FlagTrabajo).ToList<entPeriodoCia>();
            return ListObj;
        }

        public static entErrores MantFormID(entPeriodoCia Data)
        {
            return datPeriodoCia.MantFormID(Data);
        }

        public static entErrores MantBloqueoPeriodo(List<entPeriodoCia> Data)
        {
            return datPeriodoCia.MantBloqueoPeriodo(Data);
        }

        public static entErrores AbrirPeriodoCB(entPeriodoCia Data)
        {
            return datPeriodoCia.AbrirPeriodoCB(Data);
        }

        public static entErrores CerrarPeriodoCB(entPeriodoCia Data)
        {
            return datPeriodoCia.CerrarPeriodoCB(Data);
        }

        public static String GetPeriodoTrabajo(String Compania, String Sistema)
        {
            String sPer = "";
            List<entPeriodoCia> ListObj = new List<entPeriodoCia>();
            ListObj = datPeriodoCia.ListaPeriodoTrabajo(Compania, Sistema).ToList<entPeriodoCia>();
            if (ListObj.Count == 1){
                sPer = ListObj[0].Periodo;
            }
            ListObj = null;
            return sPer;
        }

        public static Int32 GetValidaPeriodoCia(String Compania, String Periodo, String Sistema)
        {
            return datPeriodoCia.GetValidaPeriodoCia(Compania, Periodo, Sistema);
        }

        public static entErrores GetValidarPeriodoMasivo(List<entPeriodoCia> Data)
        {
            return datPeriodoCia.GetValidarPeriodoMasivo(Data);
        }

        public static entErrores GetValidarPeriodoBloqueo(List<entPeriodoCia> Data)
        {
            return datPeriodoCia.GetValidarPeriodoBloqueo(Data);
        }

        public static entErrores SetPeriodoTrabajo(entPeriodoCia Data)
        {
            return datPeriodoCia.SetPeriodoTrabajo(Data);
        }

    }
}
