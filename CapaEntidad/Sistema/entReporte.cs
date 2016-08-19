using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Sistema
{
    public class entReporte : entBase
    {
        private String c_Aplicacion, c_Ventana, c_Descripcion, ulTimoUsuario, c_NombreMenu, c_FormNet;
        private int n_Menu, n_Reporte;
        private DateTime ulTimaFechaModificacion = DateTime.Now;
        private String c_NombreAplicacion;

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

        public String Ventana
        {
            get { return c_Ventana; }
            set { c_Ventana = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String TimoUsuario
        {
            get { return ulTimoUsuario; }
            set { ulTimoUsuario = value; }
        }

        public DateTime TimaFechaModificacion
        {
            get { return ulTimaFechaModificacion; }
            set { ulTimaFechaModificacion = value; }
        }

        public String NombreMenu
        {
            get { return c_NombreMenu; }
            set { c_NombreMenu = value; }
        }

        public String FormNet
        {
            get { return c_FormNet; }
            set { c_FormNet = value; }
        }

        public String NombreAplicacion
        {
            get { return c_NombreAplicacion; }
            set { c_NombreAplicacion = value; }
        }

    }
}