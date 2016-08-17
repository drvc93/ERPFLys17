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
    public class negVoucherDet
    {
        public static List<entVoucherDet> GetFormID(String Compania, String Periodo, String TipoVoucher, String NumeroVoucher)
        {
            List<entVoucherDet> ListObj = new List<entVoucherDet>();
            ListObj = datVoucherDet.GetFormID(Compania, Periodo, TipoVoucher, NumeroVoucher).ToList<entVoucherDet>();            
            return ListObj;
        }

        public static List<entVoucherDet> LstSaldoCuenta(String Compania, String Periodo, String Cuenta)
        {
            List<entVoucherDet> ListObj = new List<entVoucherDet>();
            ListObj = datVoucherDet.LstSaldoCuenta(Compania, Periodo, Cuenta).ToList<entVoucherDet>();
            return ListObj;
        }

        public static entErrores MantFormID(entVoucherDet Data)
        {
            return datVoucherDet.MantFormID(Data);
        }

    }
}
