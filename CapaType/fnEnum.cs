﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Type
{
    public class fnEnum
    {
        public enum ConexionSQL
        {
            Lys = 1,
            Ibsa = 2,
            Iso9001 = 3
        }

        public enum AccesoOpcion
        {
            Acceso = 1,
            Nuevo = 2,
            Modificar = 3,
            Eliminar = 4,
            Otros = 5,
            NuevoOrEliminar = 6
        }

        public enum OperacionMant
        {
            Ninguno = 0,
            Insertar = 1,
            Modificar = 2,
            Eliminar = 3,
            EliminarTodos = 4            
        }

        public enum FormBusqueda
        { 
            Ninguno = 0,
            BuscarCompania = 1,
            BuscarMaquina = 2,
            BuscarCuentaContable = 3,
            BuscarPersona = 4,
            BuscarCCosto = 5,
            BuscarFlujoCaja = 6,
            BuscarProyecto = 7,
            BuscarCuentaMayor = 8
        }

        public enum RegExistente { 
            Si = 1,
            No = 2
        }

        public enum RegVer { 
            Si = 1,
            No = 2
        }
                
        public enum RegEditado
        {
            Si = 1,
            No = 2
        }

        public enum FormatFecha { 
            FechaLarga = 1,
            FechaCorta = 2,
            FechaPeriodo = 3,
            FechaTexto = 4 , 
            FechaYMDALL = 5,
            FechaLargaSP = 6
        }

        public enum ParameterCRTipo { 
            Campo = 1,
            Formula = 2
        }

        public enum PanelFormMaestros { 
            PanelAll = 0,
            PanelList = 1,
            PanelMant = 2
        }

        public enum TDatoReportParam{
            String = 1,
            Integer = 2,
            Decimal = 3,
            DateTime = 4            
        }

        public enum TipoArchivo
        {
            XLS = 1,
            TXT = 2
        }

    }
}
