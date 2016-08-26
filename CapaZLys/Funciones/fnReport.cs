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
        private String sNombreStoreProc;
        private Boolean bValidoExportar;
        private Int32 nReg = 0;

        public String ConnString{
            get { return negConexion.getEntConexion().ConeccionString; ; }
        }

        public String NombreStoreProc{
            get { return sNombreStoreProc; }
            set { sNombreStoreProc = value; }
        }

        public Boolean TieneParametros{
            get { return (LParametros.Count > 0); }
        }

        public Boolean ValidoExportar{
            get { return bValidoExportar; }
            set { bValidoExportar = value; }
        }

        public Int32 ContReg{
            get { return nReg; }
            set { nReg = value; }
        }

        public List<entRepParam> Parametros{
            get { return LParametros; }
            set { LParametros = value; }
        }

        #endregion

        #region "Funciones"

        public entRepParam GetObject(String Nombre){
            var nindex = LParametros.FindIndex(x => x.Propiedad.ToUpper().Equals(Nombre.ToUpper()));
            Int32 nInd = (Int32)nindex;
            return LParametros[nInd];
        }

        public void SetValue(String Nombre, Object Valor)
        {
            var nindex = LParametros.FindIndex(x => x.Propiedad.ToUpper().Equals(Nombre.ToUpper()));
            Int32 nInd = (Int32)nindex;
            LParametros[nInd].Valor = Valor;
        }

        public Object GetValue(String Nombre)
        {
            var nindex = LParametros.FindIndex(x => x.Propiedad.ToUpper().Equals(Nombre.ToUpper()));
            Int32 nInd = (Int32)nindex;
            return LParametros[nInd].Valor;
        }

        public void AddParametro(entRepParam oEnt) {
            LParametros.Add(oEnt);
        }

        public List<entRepParam> GetParametrosPK() {
            List<entRepParam> oLst = new List<entRepParam>();
            foreach (entRepParam eXn in LParametros) {
                if (!eXn.SubReporte) {
                    oLst.Add(eXn);
                }
            }
            return oLst;
        }

        public String GetQueryProcPK()
        {
            String sQuery = "";
            List<entRepParam> oLst = new List<entRepParam>();
            foreach (entRepParam eXn in LParametros){
                if (!eXn.SubReporte){
                    Object oTip = eXn.Valor;
                    System.Type tCode = oTip.GetType();
                    if(tCode.Equals(typeof(String))){
                        sQuery = sQuery + "'" + oTip.ToString() + "',";
                    }
                    else if (tCode.Equals(typeof(DateTime))){
                        sQuery = sQuery + "'" + oTip.ToString() + "',";
                    }
                    else{
                        sQuery = sQuery + oTip.ToString() + ",";
                    }                   
                }
            }
            if (sQuery.Length > 0) { sQuery = sQuery.Substring(0, sQuery.Length - 1); }
            sQuery = sNombreStoreProc + " " + sQuery;
            return sQuery;

        }

        #endregion

    }

    #region "EntParam"

    public class entRepParam
    {
        private String sPropiedad;
        private Boolean bSubReporte;
        private Boolean bOtrosDatos;
        private Object sValor;
        private Int32 nNivelSubReporte = 0;

        public String Propiedad{
            get { return sPropiedad; }
            set { sPropiedad = value; }
        }

        public Object Valor{
            get { return sValor; }
            set { sValor = value; }
        }

        public Boolean SubReporte
        {
            get { return bSubReporte; }
            set { bSubReporte = value; }
        }

        public Boolean OtrosDatos{
            get { return bOtrosDatos; }
            set { bOtrosDatos = value; }
        }

        public Int32 NivelSubReporte{
            get { return nNivelSubReporte; }
            set { nNivelSubReporte = value; }
        }
    }

    #endregion

}
