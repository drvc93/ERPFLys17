using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Sistema;
using FiltroLys.Repository.Sistema;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Sistema
{
    public class negReporte
    {
        public static List<entReporte> ListaFormID()
        {
            List<entReporte> ListObj = new List<entReporte>();
            ListObj = datReporte.ListaFormID().ToList<entReporte>();
            return ListObj;
        }

        public static entReporte GetFormID(String Aplicacion, Int32 Menu, Int32 Reporte)
        {
            entReporte EObj = new entReporte();
            List<entReporte> ListObj = new List<entReporte>();
            ListObj = datReporte.GetFormID(Aplicacion, Menu, Reporte).ToList<entReporte>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static entErrores MantFormID(entReporte Data)
        {
            return datReporte.MantFormID(Data);
        }

    }
}
