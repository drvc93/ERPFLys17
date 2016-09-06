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
    public partial class frmRptRegistroCompa : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptRegistroCompa()
        {
            InitializeComponent();
        }

        private void frmRptRegistroCompa_Load(object sender, EventArgs e)
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

            //Dato No Habido/No Hallado
            cmbDatoProv.Properties.DataSource = fnListasDat.ListNoHabNoHallado();
            cmbDatoProv.Properties.DisplayMember = "Nombre";
            cmbDatoProv.Properties.ValueMember = "Codigo";

            //Version PLE
            cmbVersion.Properties.DataSource = fnListasDat.ListRptLBContableVersion();
            cmbVersion.Properties.DisplayMember = "Nombre";
            cmbVersion.Properties.ValueMember = "Codigo";

            //Consultas
            List<entComboList> LstB = new List<entComboList>();
            LstB.Add(new entComboList() { Codigo = "RC", Nombre = "Registro de Compras" });
            LstB.Add(new entComboList() { Codigo = "ND", Nombre = "Registro No Domiciliados" });
            cmbConsulta.Properties.DataSource = LstB;
            cmbConsulta.Properties.DisplayMember = "Nombre";
            cmbConsulta.Properties.ValueMember = "Codigo";
            LstB = null;
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            Int32 nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            String sPerAnt = fnGeneral.PeriodoAnt(DateTime.Today);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;
            cmbVersion.EditValue = fnConst.RepVersionLBContableV500Cod;
            cmbDatoProv.EditValue = fnConst.TextRaya3;
            cmbConsulta.EditValue = "RC";
            txtPerIni.Text = sPerAnt;
            txtPerFin.Text = sPerAnt;
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {
            String sCia = cmbCompania.EditValue.ToString();
            String sPerI = txtPerIni.Text.Trim().Replace("-", "");
            String sPerF = txtPerFin.Text.Trim().Replace("-", "");
            String sProv = txtProveedor.Text.Trim();
            String sDatP = cmbDatoProv.EditValue.ToString();
            Int32 nProv = 0,nPerI = 0, nPerF = 0;
            Boolean bOB, bCH, bRG;

            Int32.TryParse(sProv, out nProv);
            Int32.TryParse(sPerI, out nPerI);
            Int32.TryParse(sPerF, out nPerF);

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio)) {
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sPerI)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo Inicial.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sPerF)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo Final.");
                return false;
            }

            if (nPerF < nPerI) {
                fnMensaje.MensajeInfo("Periodo final no puede ser menor que periodo inicial.");
                return false;
            }
            
            bOB = (ccbRegistro.Properties.Items[0].CheckState == CheckState.Checked) ? true : false;
            bCH = (ccbRegistro.Properties.Items[1].CheckState == CheckState.Checked) ? true : false;
            bRG = (ccbRegistro.Properties.Items[2].CheckState == CheckState.Checked) ? true : false;
            if (!bOB && !bCH && !bRG) {
                fnMensaje.MensajeInfo("Seleccione alguna de las fuentes de información, por favor.");
                return false;
            }

            if (!chkProveedor.Checked && (sProv.Length == 0 || nProv == 0)) {
                fnMensaje.MensajeInfo("Debe ingresar proveedor por favor.");
                return false;
            }

            if (!chkDatoProv.Checked && (sDatP.Equals(fnConst.TextRaya3))) {
                fnMensaje.MensajeInfo("Debe Seleccionar Tipo Dato proveedor por favor.");
                return false;
            }
            return true;
        }

        public override void ue_Buscar() {
            fnReport xPrmR = new fnReport();
            String sCia = cmbCompania.EditValue.ToString();
            String sPerI = txtPerIni.Text.Trim().Replace("-", "");
            String sPerF = txtPerFin.Text.Trim().Replace("-", "");
            String sProv = txtProveedor.Text.Trim();
            String sDatP = cmbDatoProv.EditValue.ToString();
            String sVersion = cmbVersion.EditValue.ToString();
            String sConsult = cmbConsulta.EditValue.ToString();
            String sOB = (ccbRegistro.Properties.Items[0].CheckState == CheckState.Checked) ? "S" : "N";
            String sCH = (ccbRegistro.Properties.Items[1].CheckState == CheckState.Checked) ? "S" : "N";
            String sRG = (ccbRegistro.Properties.Items[2].CheckState == CheckState.Checked) ? "S" : "N";
            String sFlgProv = (chkProveedor.Checked) ? "S" : "N";
            String sFlgDProv = (chkDatoProv.Checked) ? "S" : "N";
            String sFlgUIT = (chkMayorUIT.Checked) ? "S" : "N";
            Int32 nProv = 0;
            
            Int32.TryParse(sProv, out nProv);
            
            try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "PerIni", Valor = sPerI });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "PerFin", Valor = sPerF });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "RegOB", Valor = sOB });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "RegCH", Valor = sCH });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "RegRG", Valor = sRG });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagProv", Valor = sFlgProv });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Proveedor", Valor = nProv});
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagDatProv", Valor = sFlgDProv });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "DatProv", Valor = sDatP });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoReporte", Valor = "1" });

                if (sConsult.Equals("RC"))
                {
                    if (sVersion.Equals(fnConst.RepVersionLBContableV409Cod)) {
                        rpt_CuentaCCteProv oRpt = new rpt_CuentaCCteProv();
                        oRpt.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt;
                        FnReportW = xPrmR;
                        oRpt = null;
                    }

                    if (sVersion.Equals(fnConst.RepVersionLBContableV500Cod)) {
                        rpt_RegistroCompraV500 oRpt = new rpt_RegistroCompraV500();
                        oRpt.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt;
                        FnReportW = xPrmR;
                        oRpt = null;
                    }
                }
                else {
                    if (sVersion.Equals(fnConst.RepVersionLBContableV409Cod)){
                        rpt_CuentaCCteProv oRpt = new rpt_CuentaCCteProv();
                        oRpt.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt;
                        FnReportW = xPrmR;
                        oRpt = null;
                    }

                    if (sVersion.Equals(fnConst.RepVersionLBContableV500Cod)){
                        rpt_CuentaCCteProv oRpt = new rpt_CuentaCCteProv();
                        oRpt.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt;
                        FnReportW = xPrmR;
                        oRpt = null;
                    }
                }
            }catch(Exception ex){
                fnMensaje.MensajeInfo(ex.Message);            
            }
        }

        #endregion

        #region "==EventObject=="

        private void btnGenerarFileTXT_Click(object sender, EventArgs e){
            String sCia = "", sPer = "", sMon = "", sRuc = "", sFil = "", sRut = "", sConInf = "0";
            String sConsulta = "", sVersion = "";

            if (uf_validarBuscar()){
                try{
                    OpenFormEspere(this);
                    ue_Buscar();

                    //Ruta a Guardar
                    sCia = FnReportW.GetValue("Compania").ToString();
                    sPer = FnReportW.GetValue("Periodo").ToString();
                    sMon = FnReportW.GetValue("Moneda").ToString();
                    sMon = (sMon.Equals("L")) ? "1" : "2";
                    sConsulta = cmbConsulta.EditValue.ToString();
                    sVersion = cmbVersion.EditValue.ToString();
                    sConInf = (FnReportW.ContReg > 0) ? "1" : "0";

                    sRuc = negCompania.GetDatosDocFiscal(sCia);
                    if (sConsulta.Equals("RC")) { sFil = "LE" + sRuc + sPer + "000801" + "0000" + "1" + sConInf + sMon + "1"; }
                    if (sConsulta.Equals("ND")) { sFil = "LE" + sRuc + sPer + "000802" + "0000" + "1" + sConInf + sMon + "1"; }
                    sRut = GlobalVar.DirRegSunat + sFil + ".txt";
                    if (!fnFile.ExisteDirectorio(GlobalVar.DirRegSunat)){
                        fnMensaje.MensajeInfo("No existe Directorio donde exportar");
                        CloseFormEspere();
                        return;
                    }

                    //Exportar Informacion
                    FnReportW.SetValue("TipoReporte", "2");
                    Int32 nReturn = fnExportar.CreateTXTFile(FnReportW.GetQueryProcPK(), sRut, false);
                    CloseFormEspere();
                    if (nReturn != 1){
                        fnMensaje.MensajeInfo(fnExportar.MensajeError(nReturn));
                        return;
                    }
                    fnMensaje.MensajeInfo("Archivo de TXT se generó satisfactoriamente. " + sRut);
                }
                catch (Exception ex){
                    fnMensaje.MensajeInfo(ex.Message);
                }
            }
        }

        #endregion

    }
}
