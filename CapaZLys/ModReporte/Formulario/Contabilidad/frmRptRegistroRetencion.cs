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
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad
{
    public partial class frmRptRegistroRetencion : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptRegistroRetencion()
        {
            InitializeComponent();
        }

        private void frmRptRegistroRetencion_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxCargarCombosXCia();
            fxSetearInicio();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> LstA = negCompania.ListaXUsuario(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo,fnConst.StringT, new String[] { fnConst.TextNingunoCod, fnConst.TextSeleccioneNom});
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;
            
            //TipoExp
            cmbTipoExp.Properties.DataSource = fnListasDat.ListRetencionTipoExp();
            cmbTipoExp.Properties.DisplayMember = "Nombre";
            cmbTipoExp.Properties.ValueMember = "Codigo";

            //OrigenRetencion
            cmbOrigenRet.Properties.DataSource = fnListasDat.ListRetencionOrigen();
            cmbOrigenRet.Properties.DisplayMember = "Nombre";
            cmbOrigenRet.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            Int32 nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            String sPer = fnGeneral.PeriodoActual();

            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;
            cmbTipoExp.EditValue = fnConst.RetencionTipoExpPDTCod;
            cmbOrigenRet.EditValue = fnConst.RetencionOrigenOBCod;
            txtPeriodo.Text = sPer;            
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");
            String sORt = cmbOrigenRet.EditValue.ToString();
            DateTime dFecIni = deFecIni.DateTime;
            DateTime dFecFin = deFecFin.DateTime;
            
            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio)) {
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return false;
            }

            if (!chkPeriodo.Checked){
                if (String.IsNullOrWhiteSpace(sPer)){
                    fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                    return false;
                }
            }

            if (!chkFecPago.Checked) {
                if (dFecIni == DateTime.MinValue) {
                    fnMensaje.MensajeInfo("Debe ingresar Fecha Inicio válido.");
                    return false;
                }

                if (dFecFin == DateTime.MinValue){
                    fnMensaje.MensajeInfo("Debe ingresar Fecha Fin válido.");
                    return false;
                }
            }

            if (!chkOrigenRet.Checked) {
                if (sORt.Equals(fnConst.TextRaya3)) {
                    fnMensaje.MensajeInfo("Debe ingresar origen de Retención.");
                    return false;
                }
            }

            return true;
        }

        public override void ue_Buscar() {
            fnReport xPrmR = new fnReport();
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");
            String sTExp = "N";
            String sOrig = cmbOrigenRet.EditValue.ToString();
            DateTime dFRet = deFecRet.DateTime;
            DateTime dFIni = deFecIni.DateTime;
            DateTime dFFin = deFecFin.DateTime;
            String sFlgPer = (chkPeriodo.Checked) ? "S" : "N";
            String sExcAN = (chkExcAnul.Checked) ? "S" : "N";
            String sFlgFPago = (chkFecPago.Checked) ? "S" : "N";
            String sFlgOrig = (chkOrigenRet.Checked) ? "S" : "N";
            String sNCia = cmbCompania.Text.Trim();

            if (dFFin != DateTime.MinValue) { dFFin = dFFin.AddDays(1).AddSeconds(-1);}
            
            try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagPeriodo", Valor = sFlgPer });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagProveedor", Valor = "S" });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Proveedor", Valor = 0 });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagFecha", Valor = sFlgFPago });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FechaPagoIni", Valor = dFIni });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FechaPagoFin", Valor = dFFin });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagTipo", Valor = "S" });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Tipo", Valor = "" });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "RetencionNum", Valor = 0 });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagEstado", Valor = "S" });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Estado", Valor = "" });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "ExcAnulado", Valor = sExcAN });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagOrigen", Valor = sFlgOrig });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Origen", Valor = sOrig });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoExp", Valor = sTExp });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FechaRetencion", Valor = dFRet });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CompaniaNombre", Valor = sNCia, OtrosDatos = true });

                rpt_RetencionProveedor oRptV = new rpt_RetencionProveedor();
                oRptV.GenerarReport(ref xPrmR);
                dvReport.DocumentSource = oRptV;
                FnReportW = xPrmR;
                oRptV = null;
                
            }catch(Exception ex){
                fnMensaje.MensajeInfo(ex.Message);            
            }
        }

        #endregion

        #region "==EventObject=="

        private void btnGenerarFileTXT_Click(object sender, EventArgs e)
        {
            String sCia = "", sPer = "",sRuc="", sFil = "", sRut = "", sTipExp="01";
            DateTime dFecRet = DateTime.MinValue;

            if (uf_validarBuscar()) {
                try{
                    sTipExp = cmbTipoExp.EditValue.ToString();
                    if (sTipExp.Equals(fnConst.RetencionTipoExpLINCod) && dFecRet == DateTime.MinValue) {
                        fnMensaje.MensajeInfo("Ingresar dia para exportar retención.");
                        return;
                    }

                    OpenFormEspere(this);
                    ue_Buscar();

                    //Ruta a Guardar
                    sCia = FnReportW.GetValue("Compania").ToString();
                    sPer = FnReportW.GetValue("Periodo").ToString();
                    dFecRet = Convert.ToDateTime(FnReportW.GetValue("FechaRetencion"));
                    sRuc = negCompania.GetDatosDocFiscal(sCia);

                    if (sTipExp.Equals(fnConst.RetencionTipoExpPDTCod)){
                        sFil = "0626" + sRuc + sPer;
                    }
                    else {
                        sPer = fnGeneral.FormatoDateTime(dFecRet, fnEnum.FormatFecha.FechaYMDALL);
                        sFil = sRuc + "-" + "20" + "-" + sPer + "-" + "1";
                    }

                    sRut = GlobalVar.DirRegSunat + sFil + ".txt";
                    if (!fnFile.ExisteDirectorio(GlobalVar.DirRegSunat)) {
                        fnMensaje.MensajeInfo("No existe Directorio donde exportar");
                        CloseFormEspere();
                        return;
                    }

                    sTipExp = (sTipExp.Equals(fnConst.RetencionTipoExpPDTCod)) ? "S" : "R";

                    //Exportar Informacion
                    FnReportW.SetValue("TipoExp", sTipExp);
                    Int32 nReturn = fnExportar.CreateTXTFile(FnReportW.GetQueryProcPK(), sRut, false);
                    FnReportW.SetValue("TipoExp", "N");
                    CloseFormEspere();
                    if (nReturn != 1) {
                        fnMensaje.MensajeInfo(fnExportar.MensajeError(nReturn));                    
                        return;
                    }
                    fnMensaje.MensajeInfo("Archivo de TXT se generó satisfactoriamente. " + sRut);
                }catch(Exception ex){
                    fnMensaje.MensajeInfo(ex.Message);
                }
            }
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            txtPeriodo.ReadOnly = chkPeriodo.Checked;
            txtPeriodo.Text = (!chkPeriodo.Checked)?fnGeneral.PeriodoActual():String.Empty;
        }

        private void chkFecPago_CheckedChanged(object sender, EventArgs e)
        {
            deFecIni.ReadOnly = chkFecPago.Checked;
            deFecFin.ReadOnly = chkFecPago.Checked;
            deFecIni.DateTime = DateTime.MinValue;
            deFecFin.DateTime = DateTime.MinValue;
            deFecIni.Text = String.Empty;
            deFecFin.Text = String.Empty;
        }

        private void chkOrigenRet_CheckedChanged(object sender, EventArgs e)
        {
            cmbOrigenRet.ReadOnly = chkOrigenRet.Checked;
            cmbOrigenRet.EditValue = fnConst.TextRaya3;
        }

        #endregion
    }
}

