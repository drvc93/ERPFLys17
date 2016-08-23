using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Sistema;
using FiltroLys.Repository.Sistema;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using System.Data;

namespace FiltroLys.Domain.Sistema
{
    public class negBaseDatos
    {
        public static List<entBaseDato> ListaBaseDatos()
        {
            List<entBaseDato> ListObj = new List<entBaseDato>();
            ListObj = datBaseDatos.ListaBaseDatos().ToList<entBaseDato>();
            ListObj.Insert(0, new entBaseDato() { DataBase = fnConst.TextSeleccioneNom }); 
            return ListObj;
        }

        public static List<entTabla> ListaTablas(String BaseDatos)
        {
            List<entTabla> ListObj = new List<entTabla>();
            ListObj = datBaseDatos.ListaTablas(BaseDatos).ToList<entTabla>();
            ListObj.Insert(0, new entTabla() { TableName = fnConst.TextSeleccioneNom }); 
            return ListObj;
        }

        public static List<entColumna> ListaColumnas(String BaseDatos, String Tabla)
        {
            List<entColumna> ListObj = new List<entColumna>();
            ListObj = datBaseDatos.ListaColumnas(BaseDatos, Tabla).ToList<entColumna>();
            return ListObj;
        }

        public static DataTable ListaDatosOfStoreProc(String XsqlProcedure) {
            return datBaseDatos.ListaDatosOfStoreProc(XsqlProcedure);
        }

    }
}
