using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;
using FiltroLys.Domain.Sistema;

namespace FiltroLys.ZLys.Funciones
{
    public class fnReport
    {
        #region "Propiedades"

        private List<entRepParam> LParametros = new List<entRepParam>();
        private String sNombreStoreProc, sConnString;
        private Boolean bExportar = false;

        public List<entRepParam> Parametros{
            get { return LParametros; }
            set { LParametros = value; }
        }

        public String NombreStoreProc{
            get { return sNombreStoreProc; }
            set { sNombreStoreProc = value; }
        }

        public String ConnString{
            get { return negConexion.getEntConexion().ConeccionString; ; }
        }

        public Boolean TieneParametros{
            get { return (LParametros.Count > 0); }
        }

        public Boolean bValidoExportar
        {
            get { return bExportar; }
            set { bExportar = value; }
        }

        public entRepParam getParam(String Nombre) { 
            LParametros.g
        }

        #endregion

        public String GetParamProced() {
            return "";
        }
    }

    #region "EntParam"

    public class entRepParam
    {
        private String sPropiedad;
        private fnEnum.TDatoReportParam sTipo;
        private Object sValor;

        public String Propiedad{
            get { return sPropiedad; }
            set { sPropiedad = value; }
        }

        public fnEnum.TDatoReportParam Tipo{
            get { return sTipo; }
            set { sTipo = value; }
        }

        public Object Valor{
            get { return sValor; }
            set { sValor = value; }
        }
    }

    #endregion

}
