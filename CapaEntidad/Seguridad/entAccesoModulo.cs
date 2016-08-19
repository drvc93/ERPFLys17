using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Seguridad
{
    public class entAccesoModulo : entBase
    {
        private String c_Usuario, c_Aplicacion,c_Estado,c_NombreAplicacion;
        private String c_UltimoUsuario;
        private DateTime d_UltimaFechaModificacion;
        
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

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String UltimoUsuario
        {
            get { return c_UltimoUsuario; }
            set { c_UltimoUsuario = value; }
        }

        public DateTime UltimaFechaModificacion
        {
            get { return d_UltimaFechaModificacion; }
            set { d_UltimaFechaModificacion = value; }
        }

        public String NombreAplicacion
        {
            get { return c_NombreAplicacion; }
            set { c_NombreAplicacion = value; }
        }

    }
}
