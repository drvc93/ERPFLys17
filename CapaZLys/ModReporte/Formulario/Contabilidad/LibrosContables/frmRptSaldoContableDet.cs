using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Domain.Sistema;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.LibrosContables;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables
{
    public partial class frmRptSaldoContableDet : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==Propiedades=="

        private String sCia = "", sPer = "", sCta = "";
        private entEstructForm xestruct = new entEstructForm();
        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmRptSaldoContableDet()
        {
            InitializeComponent();
        }

        private void frmSaldoContableDet_Load(object sender, EventArgs e)
        {   
            fxSetearInicio();            
        }

        private void frmRptSaldoContableDet_Shown(object sender, EventArgs e)
        {
            ue_Buscar();
        }

        #endregion

        #region "==FuncionesForm=="
        
        private void fxSetearInicio() {
            sCia = this.EstructuraForm.StrX[0];
            sPer = this.EstructuraForm.StrX[1];
            sCta = this.EstructuraForm.StrX[2];
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {           
            return true;
        }

        public override void ue_Buscar() {
            fnReport xPrmR = new fnReport();
            try{
                String sNom = negCompania.GetDatosNombre(sCia);
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Cuenta", Valor = sCta });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CompaniaNombre", Valor = sNom, OtrosDatos = true });

                rpt_SaldoContableDet oRpt = new rpt_SaldoContableDet();
                oRpt.GenerarReport(ref xPrmR);
                dvReport.DocumentSource = oRpt;
                FnReportW = xPrmR;
                oRpt = null;
               
            }catch(Exception ex){
                fnMensaje.MensajeInfo(ex.Message);            
            }
        }

        #endregion

    }
}
