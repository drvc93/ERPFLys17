﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Funciones
{
    public static class fnGeneral
    {
        public static DateTime StringTODatetime(String fecha){
            IFormatProvider culture = new CultureInfo("en-US", true);
            DateTime FechaFin;
            fecha = fecha + ".000";
            bool val = DateTime.TryParseExact(fecha, "dd/MM/yyyy HH:mm:ss.fff", culture, DateTimeStyles.None,out FechaFin);
            return FechaFin;
        }

        public static String FormatoDateTime(DateTime dFecha, fnEnum.FormatFecha Formato = fnEnum.FormatFecha.FechaLarga) {
            String sFecha = "";
            if (dFecha != null && dFecha != DateTime.MinValue) {
                switch (Formato) { 
                    case fnEnum.FormatFecha.FechaCorta:
                        sFecha = String.Format("{0:dd/MM/yyyy}", dFecha);
                        break;
                    case fnEnum.FormatFecha.FechaLarga:
                        sFecha = String.Format("{0:dd/MM/yyyy HH:mm:ss}", dFecha);
                        break;
                    case fnEnum.FormatFecha.FechaPeriodo:
                        sFecha = String.Format("{0:yyyyMM}", dFecha);
                        break;
                    case fnEnum.FormatFecha.FechaTexto:
                        sFecha = String.Format("{0:yyyyMM}", dFecha);
                        break;
                    case fnEnum.FormatFecha.FechaYMDALL:
                        sFecha = String.Format("{0:yyyyMMdd}", dFecha);
                        break;
                    case fnEnum.FormatFecha.FechaLargaSP:
                        sFecha = String.Format("{0:yyyyMMdd HH:mm:ss}", dFecha);
                        break;
                }
            }
            return sFecha;    
        }

        public static String XTrim(String Texto) {
            Texto = (String.IsNullOrEmpty(Texto))? "" : Texto;
            Texto = Texto.Trim();
            return Texto;
        }

        public static DateTime FechaFinDeMes(String Periodo)
        {
            String sAnual="",sMes="";
            Int32 nAnual=1, nMes=1;
            DateTime dFec;

            if (Periodo.Length >= 2) { sAnual = Periodo.Substring(0,4);}
            if (Periodo.Length == 6) { sMes = Periodo.Substring(4,2);}

            Int32.TryParse(sAnual, out nAnual);
            Int32.TryParse(sMes, out nMes);

            dFec = new DateTime(nAnual, nMes, 1);
            dFec = dFec.AddMonths(1).AddSeconds(-1);
            return dFec;
        }

        public static String FechaFinDeMesText(String Periodo) {
            String xFec = "";
            DateTime dFec = FechaFinDeMes(Periodo);
            xFec = String.Format("{0:dd/MM/yyyy}", dFec);
            return xFec;
        }

        public static String PeriodoAnt(String Periodo) {
            String sPer = "";
            Int32 nAnual = 0, nMes = 0;

            Periodo = Periodo.Trim();
            Periodo = Periodo.Replace("-", "");
            if (Periodo.Length >= 4) { Int32.TryParse(Periodo.Substring(0,4),out nAnual);}
            if (Periodo.Length == 6) { Int32.TryParse(Periodo.Substring(4,2),out nMes); }
            if (nAnual > 0 || nMes > 0) {
                sPer = FormatoDateTime(new DateTime(nAnual, nMes, 1).AddSeconds(-1), fnEnum.FormatFecha.FechaPeriodo);
            }
            return sPer;
        }

        public static String PeriodoAnt(DateTime Fecha)
        {
            String sPer = "";
            sPer = FormatoDateTime(new DateTime(Fecha.Year,Fecha.Month,1).AddSeconds(-1), fnEnum.FormatFecha.FechaPeriodo);
            return sPer;
        }

        public static String PeriodoActual()
        {
            String sPer = "";
            sPer = FormatoDateTime(DateTime.Today, fnEnum.FormatFecha.FechaPeriodo);
            return sPer;
        }

        public static DateTime FechaRepNULL()
        {
            return (DateTime) System.Data.SqlTypes.SqlDateTime.MinValue; 
        }

    }

}
