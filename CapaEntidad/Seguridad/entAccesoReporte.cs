using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Seguridad
{
    public class entAccesoReporte : entBase
    {
        private String c_Usuario, c_Aplicacion, c_Acceso = "N", c_TotalConsulta = "N",c_UltimoUsuarioMod;
        private int n_Menu, n_Reporte;
        private DateTime d_UltimaFechaMod = DateTime.Now;
        private String c_NombreModulo, c_NombreReporte, c_CodReporte;
        private String c_Nivel, c_CodReg, c_Padre, c_NombreAplicacion;
        private String c_Descripcion, c_FormNet, c_Modulo = "--", c_NameSpaceRpt = "";

        public String Usuario
        {
            get { return c_Usuario; }
            set { c_Usuario = value; }
        }

        public String Aplicacion
        {
            get { return c_Aplicacion; }
            set { c_Aplicacion = value; }
        }
        
        public Int32 Menu
        {
            get { return n_Menu; }
            set { n_Menu = value; }
        }

        public Int32 Reporte
        {
            get { return n_Reporte; }
            set { n_Reporte = value; }
        }

        public String Acceso
        {
            get { return c_Acceso; }
            set { c_Acceso = value; }
        }

        public String TotalConsulta
        {
            get { return c_TotalConsulta; }
            set { c_TotalConsulta = value; }
        }

        public String UltimoUsuarioMod
        {
            get { return c_UltimoUsuarioMod; }
            set { c_UltimoUsuarioMod = value; }
        }

        public DateTime UltimaFechaMod
        {
            get { return d_UltimaFechaMod; }
            set { d_UltimaFechaMod = value; }
        }

        public String NombreModulo
        {
            get { return c_NombreModulo; }
            set { c_NombreModulo = value; }
        }

        public String NombreReporte
        {
            get { return c_NombreReporte; }
            set { c_NombreReporte = value; }
        }

        public String CodReporte
        {
            get { return c_CodReporte; }
            set { c_CodReporte = value; }
        }

        public String Nivel
        {
            get { return c_Nivel; }
            set { c_Nivel = value; }
        }

        public String CodReg
        {
            get { return c_CodReg; }
            set { c_CodReg = value; }
        }

        public String Padre
        {
            get { return c_Padre; }
            set { c_Padre = value; }
        }

        public String NombreAplicacion
        {
            get { return c_NombreAplicacion; }
            set { c_NombreAplicacion = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String FormNet
        {
            get { return c_FormNet; }
            set { c_FormNet = value; }
        }

        public String Modulo
        {
            get { return c_Modulo; }
            set { c_Modulo = value; }
        }

        public String NameSpaceRpt
        {
            get { return c_NameSpaceRpt; }
            set { c_NameSpaceRpt = value; }
        }

    }
}