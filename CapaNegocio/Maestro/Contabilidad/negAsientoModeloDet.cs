using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negAsientoModeloDet
    {
        public static List<entAsientoModeloDet> GetFormID(String Compania, String Modelo)
        {
            List<entAsientoModeloDet> ListObj = new List<entAsientoModeloDet>();
            ListObj = datAsientoModeloDet.GetFormID(Compania, Modelo).ToList<entAsientoModeloDet>();
            return ListObj;
        }

        public static List<entAsientoModeloDet> ListaSearch(String Compania, String Modelo)
        {
            List<entAsientoModeloDet> ListObj = new List<entAsientoModeloDet>();
            ListObj = datAsientoModeloDet.ListaSearch(Compania, Modelo).ToList<entAsientoModeloDet>();
            return ListObj;
        }

        public static entErrores MantFormID(entAsientoModeloDet Data)
        {
            return datAsientoModeloDet.MantFormID(Data);
        }

    }
}
