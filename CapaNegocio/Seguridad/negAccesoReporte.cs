using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Seguridad;
using FiltroLys.Repository.Seguridad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Seguridad
{
    public class negAccesoReporte
    {
        public static List<entAccesoReporte> ListaFormID()
        {
            List<entAccesoReporte> ListObj = new List<entAccesoReporte>();
            ListObj = datAccesoReporte.ListaFormID().ToList<entAccesoReporte>();
            return ListObj;
        }

        public static entAccesoReporte GetFormID(String Usuario, String Aplicacion, Int32 Menu, Int32 Reporte)
        {
            entAccesoReporte EObj = new entAccesoReporte();
            List<entAccesoReporte> ListObj = new List<entAccesoReporte>();
            ListObj = datAccesoReporte.GetFormID(Usuario, Aplicacion, Menu, Reporte).ToList<entAccesoReporte>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }
        
        public static entErrores MantFormID(entAccesoReporte Data)
        {
            return datAccesoReporte.MantFormID(Data);
        }

        public static List<entAccesoReporte> ListaReportexModulo(String Usuario)
        {
            List<entAccesoReporte> ListObj = new List<entAccesoReporte>();
            ListObj = datAccesoReporte.ListaReportexModulo(Usuario).ToList<entAccesoReporte>();
            return ListObj;
        }

    }
}
