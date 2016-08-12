using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Seguridad;
using FiltroLys.Repository.Seguridad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Domain.Seguridad
{
    public class negAuditoria
    {
        public static List<entAuditoria> ListaFormID(String Usuario, DateTime FechaInicio, DateTime FechaTermino)
        {

            List<entAuditoria> ListObj = datAuditoria.ListaFormID(Usuario, FechaInicio, FechaTermino).ToList<entAuditoria>();
            return ListObj;            
        }

        public static entAuditoria GetFormID(String Estacion, String CodigoUsuario, DateTime FechaPcIng)
        {
            entAuditoria EObj = new entAuditoria();
            List<entAuditoria> ListObj = new List<entAuditoria>();
            ListObj = datAuditoria.GetFormID(Estacion, CodigoUsuario, FechaPcIng).ToList<entAuditoria>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static entErrores MantFormID(entAuditoria Data)
        {
            return datAuditoria.MantFormID(Data);
        }

    }
}
