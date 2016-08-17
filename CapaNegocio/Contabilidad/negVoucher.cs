using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Repository.Contabilidad;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Domain.Contabilidad
{
    public class negVoucher
    {
        public static List<entVoucher> ListaFormID(String Compania, String FlagDepartCia, String DepartCia, String FlagPeriodo,
        String Periodo, String FlagEstado, String Estado, String FlagVoucher, String TipoVoucher, String VoucherIni, String VoucherFin)
        {
            List<entVoucher> ListObj = new List<entVoucher>();
            ListObj = datVoucher.ListaFormID(Compania, FlagDepartCia, DepartCia, FlagPeriodo, Periodo, FlagEstado,
                                                 Estado, FlagVoucher, TipoVoucher, VoucherIni, VoucherFin).ToList<entVoucher>();
            
            return ListObj;
        }

        public static entVoucher GetFormID(String Compania, String Periodo, String TipoVoucher, String NumeroVoucher)
        {
            entVoucher EObj = new entVoucher();
            List<entVoucher> ListObj = new List<entVoucher>();
            ListObj = datVoucher.GetFormID(Compania, Periodo, TipoVoucher, NumeroVoucher).ToList<entVoucher>();
            if (ListObj.Count > 0) {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entVoucher> LstSaldoMayor(String Compania, String Periodo, String Estado)
        {
            List<entVoucher> ListObj = new List<entVoucher>();
            ListObj = datVoucher.LstSaldoMayor(Compania, Periodo, Estado).ToList<entVoucher>();
            return ListObj;
        }

        public static entErrores MantFormID(entVoucher Data)
        {
            return datVoucher.MantFormID(Data);
        }

        public static entErrores AnularReg(entVoucher Data)
        {
            return datVoucher.AnularReg(Data);
        }

        public static entErrores AprobarReg(entVoucher Data)
        {
            return datVoucher.AprobarReg(Data);
        }

        public static entErrores PasarPendienteReg(entVoucher Data)
        {
            return datVoucher.PasarPendienteReg(Data);
        }

        public static entErrores AprobarMasivo(List<entVoucher> Data, ref BackgroundWorker worker)
        {
            return datVoucher.AprobarMasivo(Data, ref worker);
        }

        public static entErrores PasarPendienteMasivo(List<entVoucher> Data, ref BackgroundWorker worker)
        {
            return datVoucher.PasarPendienteMasivo(Data, ref worker);
        }

    }
}
