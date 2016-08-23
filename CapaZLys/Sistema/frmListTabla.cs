using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Sistema;
using FiltroLys.Domain.Sistema;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Sistema
{
    public partial class frmListTabla : FiltroLys.ZLys.Controles.Formulario.frmList
    {
        #region "==EventForm=="

        public frmListTabla()
        {
            InitializeComponent();
        }

        private void frmListTabla_Load(object sender, EventArgs e)
        {
            fxCargarBaseDatos();
            fxValoresDefault();
            fxCargarCombosDetalle();
        }

        #endregion

        #region "==EventObject=="

        private void btnGenEntidad_Click(object sender, EventArgs e)
        {
            if (fxValidarGenQuery()){
                fxGenerarEntidad();
                fxGenerarNegocio();
                fxGenerarData();
                fxGenerarStoreProc();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String sBaseDatos,sTabla;
            if (!fxValidarCriterio()) { return; }

            sBaseDatos = ((entBaseDato)cmbBaseDato.GetSelectedDataRow()).DataBase;
            sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;

            List<entColumna> Ls = negBaseDatos.ListaColumnas(sBaseDatos,sTabla);
            grControl.DataSource = Ls;
        }

        private void cmbBaseDato_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarTabla();
        }

        private void chkSel_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gvDatos.DataRowCount;i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                objE.Sel = chkSel.Checked ? fnConst.ListaCondSel : "";
            }
            gvDatos.RefreshData();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarBaseDatos()
        {
            List<entBaseDato> Lst = negBaseDatos.ListaBaseDatos();
            cmbBaseDato.Properties.DataSource = Lst;
            cmbBaseDato.Properties.DisplayMember = "DataBase";
            cmbBaseDato.Properties.ValueMember = "DataBase";
            Lst = null;
        }

        private void fxCargarTabla()
        {
            String sBaseD = cmbBaseDato.EditValue.ToString();

            List<entTabla> Lst = negBaseDatos.ListaTablas(sBaseD);
            cmbTabla.Properties.DataSource = Lst;
            cmbTabla.Properties.DisplayMember = "TableName";
            cmbTabla.Properties.ValueMember = "TableName";
            cmbTabla.EditValue = fnConst.TextSeleccioneNom;
            Lst = null;
        }

        private void fxCargarCombosDetalle()
        {
            //VB
            List<entComboList> LstA = fnListasDat.ListSelectCondicion();
            rilueVB.DataSource = LstA;
            rilueVB.DisplayMember = "Nombre";
            rilueVB.ValueMember = "Codigo";
            LstA = null;
        }

        private void fxValoresDefault()
        {
            txtFolder.Text = String.Empty;
            txtEntidad.Text = String.Empty;
            cmbBaseDato.EditValue = "LYS";            
        }

        private Boolean fxValidarCriterio()
        {
            String sDataB = ((entBaseDato)cmbBaseDato.GetSelectedDataRow()).DataBase;
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;

            if (sDataB.Equals(fnConst.TextSeleccioneNom)){
                fnMensaje.MensajeInfo("Seleccionar Base Datos por favor.");
                cmbBaseDato.Focus();
                return false;
            }

            if (sTabla.Equals(fnConst.TextSeleccioneNom)){
                fnMensaje.MensajeInfo("Seleccionar Tabla por favor.");
                cmbTabla.Focus();
                return false;
            }
            return true;
        }

        private Boolean fxValidarGenQuery()
        {
            String sBaseD = ((entBaseDato)cmbBaseDato.GetSelectedDataRow()).DataBase;
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;
            String sFolder = txtFolder.Text.Trim();
            String sEntidad = txtEntidad.Text.Trim();

            if (sBaseD.Equals(fnConst.TextSeleccioneNom)){
                fnMensaje.MensajeInfo("Seleccionar Tabla por favor.");
                cmbBaseDato.Focus();
                return false;
            }

            if (sTabla.Equals(fnConst.TextSeleccioneNom)){
                fnMensaje.MensajeInfo("Seleccionar Tabla por favor.");
                cmbTabla.Focus();
                return false;
            }

            if (sFolder.Equals(String.Empty)){
                fnMensaje.MensajeInfo("Ingresar Folder por favor.");
                txtFolder.Focus();
                return false;
            }

            if (sEntidad.Equals(String.Empty)){
                fnMensaje.MensajeInfo("Ingresar Entidad por favor.");
                txtEntidad.Focus();
                return false;
            }

            if (gvDatos.DataRowCount == 0){
                fnMensaje.MensajeInfo("No Existe informaciòn de Columnas");
                cmbTabla.Focus();
                return false;
            }
            return true;
        }

        private void fxGenerarEntidad()
        {
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;
            String sFolder = txtFolder.Text.Trim();
            String sEntidad = txtEntidad.Text.Trim();
            String sprivateString = "", sprivateInt = "", sprivateDecimal = "", sprivateDatetime = "", scampo = "", stipo = "";
            StringBuilder query = new StringBuilder();
            int nCount = gvDatos.DataRowCount;

            //Datos Cabecera
            query.Append("using System;").AppendLine();
            query.Append("using System.Collections.Generic;").AppendLine();
            query.Append("using System.Linq;").AppendLine();
            query.Append("using System.Text;").AppendLine();
            query.Append("using System.Threading.Tasks;").AppendLine();
            query.AppendLine();
            query.Append("namespace FiltroLys.Model." + sFolder).AppendLine();
            query.Append("{").AppendLine();
            query.Append("\t" + "public class ent" + sEntidad + " : entBase ").AppendLine();
            query.Append("\t{").AppendLine();

            //Datos Propiedad Private
            for (int i = 0; i < gvDatos.DataRowCount;i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                scampo = objE.Nombre;
                if(scampo.Substring(1,1).Equals("_")){
                    scampo = objE.Nombre.Substring(0, 2) + objE.Propiedad;
                }else{
                    scampo = objE.Propiedad;
                }

                switch (objE.Tipo){
                    case "varchar":
                    case "char":
                    case "nvarchar":
                    case "text":
                        sprivateString = sprivateString + scampo + (objE.DefaultNet.Length > 0 ? "=\"" + objE.DefaultNet + "\"" : "") + ", ";
                        break;
                    case "int":
                        sprivateInt = sprivateInt + scampo + (objE.DefaultNet.Length > 0 ? "=" + objE.DefaultNet : "") + ", ";
                        break;
                    case "decimal":
                    case "numeric":
                        sprivateDecimal = sprivateDecimal + scampo + (objE.DefaultNet.Length > 0 ? "=" + objE.DefaultNet : "") + ", ";
                        break;
                    case "datetime":
                        sprivateDatetime = sprivateDatetime + scampo + (objE.DefaultNet.Length > 0 ? "=" + objE.DefaultNet : "") + ", ";
                        break;
                }
            }
            sprivateString = sprivateString.Trim();
            sprivateInt = sprivateInt.Trim();
            sprivateDecimal = sprivateDecimal.Trim();
            sprivateDatetime = sprivateDatetime.Trim();

            if (sprivateString.Length > 0) { query.Append("\t\t private String " + sprivateString.Substring(0, sprivateString.Length - 1) + ";").AppendLine(); }
            if (sprivateInt.Length > 0) { query.Append("\t\t private int " + sprivateInt.Substring(0, sprivateInt.Length - 1) + ";").AppendLine(); }
            if (sprivateDecimal.Length > 0) { query.Append("\t\t private Decimal " + sprivateDecimal.Substring(0, sprivateDecimal.Length - 1) + ";").AppendLine(); }
            if (sprivateDatetime.Length > 0) { query.Append("\t\t private DateTime " + sprivateDatetime.Substring(0, sprivateDatetime.Length - 1) + ";").AppendLine(); }
            query.AppendLine();

            //Agregando Campos Otros//
            query.Append("private String c_UserNombreForm;");
            query.AppendLine();

            //Datos Propiedad Publica
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);                
                scampo = objE.Nombre;
                if(scampo.Substring(1,1).Equals("_")){
                    scampo = objE.Nombre.Substring(0, 2) + objE.Propiedad;
                }else{
                    scampo = objE.Propiedad;
                }
                stipo = objE.TipoNetProp;

                query.Append("\t\t public " + stipo + " " + objE.Propiedad + "{").AppendLine();
                query.Append("\t\t\t get { return " + scampo + ";}").AppendLine();
                query.Append("\t\t\t set { " + scampo + "= value;}").AppendLine();
                query.Append("\t\t }").AppendLine().AppendLine();                
            }

            //Propiedades Otros
            query.Append("\t\t public " + "String" + " " + "UserNombreForm" + "{").AppendLine();
            query.Append("\t\t\t get { return " + "c_UserNombreForm" + ";}").AppendLine();
            query.Append("\t\t\t set { " + "c_UserNombreForm" + "= value;}").AppendLine();
            query.Append("\t\t }").AppendLine().AppendLine();

            query.Append("\t }").AppendLine();
            query.Append("}");
            txtQueryEntidad.Text = query.ToString();
        }

        private void fxGenerarNegocio()
        {
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;
            String sFolder = txtFolder.Text.Trim();
            String sEntidad = txtEntidad.Text.Trim();
            String sListPR = "", sList = "", sIdPR = "", sId = "", sCmbPR = "", sCmb = "", sBusqPR = "", sBusq = "";
            Boolean bCombo = false, bBusq = false;
            StringBuilder query = new StringBuilder();
            int nCount = gvDatos.DataRowCount;

            //Datos Cabecera
            query.Append("using System;").AppendLine();
            query.Append("using System.Collections.Generic;").AppendLine();
            query.Append("using System.Linq;").AppendLine();
            query.Append("using System.Text;").AppendLine();
            query.Append("using System.Threading.Tasks;").AppendLine();
            query.Append("using FiltroLys.Model." + sFolder + ";").AppendLine();
            query.Append("using FiltroLys.Repository." + sFolder + ";").AppendLine();
            query.Append("using FiltroLys.Domain.Funciones;").AppendLine();
            query.Append("using FiltroLys.Model.Objeto;").AppendLine();
            query.Append("using FiltroLys.Type;").AppendLine();
            query.AppendLine();

            query.Append("namespace FiltroLys.Model." + sFolder).AppendLine();
            query.Append("{").AppendLine();
            query.Append("\t" + "public class neg" + sEntidad).AppendLine();
            query.Append("\t{").AppendLine();

            //Datos de Parametros
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.Sel.Equals(fnConst.ListaCondUpd) || objE.Sel.Equals(fnConst.ListaCondSelUpd)){
                    sListPR = sListPR + objE.TipoNetProp + " " + objE.Propiedad + ",";
                    sList = sList + objE.Propiedad + ",";
                }

                if (objE.PkId.Equals("S")){
                    sIdPR = sIdPR + objE.TipoNetProp + " " + objE.Propiedad + ",";
                    sId = sId + objE.Propiedad + ",";
                }

                if (objE.Combo.Equals(fnConst.ListaCondUpd) || objE.Combo.Equals(fnConst.ListaCondSelUpd)){
                    sCmbPR = sCmbPR + objE.TipoNetProp + " " + objE.Propiedad + ",";
                    sCmb = sCmb + objE.Propiedad + ",";
                }

                if (objE.Search.Equals(fnConst.ListaCondUpd) || objE.Search.Equals(fnConst.ListaCondSelUpd)){
                    sBusqPR = sBusqPR + objE.TipoNetProp + " " + objE.Propiedad + ",";
                    sBusq = sBusq + objE.Propiedad + ",";
                }

                if (!objE.Combo.Equals("")) { bCombo = true; }
                if (!objE.Search.Equals("")) { bBusq = true; }
            }

            sListPR = (sListPR.Length > 0) ? sListPR.Substring(0, sListPR.Length - 1):"";
            sList = (sList.Length > 0) ? sList.Substring(0, sList.Length - 1) : "";
            sIdPR = (sIdPR.Length > 0) ? sIdPR.Substring(0, sIdPR.Length - 1) : "";
            sId = (sId.Length > 0) ? sId.Substring(0, sId.Length - 1) : "";
            sCmbPR = (sCmbPR.Length > 0) ? sCmbPR.Substring(0, sCmbPR.Length - 1) : "";
            sCmb = (sCmb.Length > 0) ? sCmb.Substring(0, sCmb.Length - 1) : "";
            sBusqPR = (sBusqPR.Length > 0) ? sBusqPR.Substring(0, sBusqPR.Length - 1) : "";
            sBusq = (sBusq.Length > 0) ? sBusq.Substring(0, sBusq.Length - 1) : "";

            //Select
            query.Append("\t\t" + "public static List<ent" + sEntidad + "> ListaFormID(" + sListPR + ")").AppendLine();
            query.Append("\t\t{").AppendLine();
            query.Append("\t\t\t" + "List<ent" + sEntidad + "> ListObj = new List<ent" + sEntidad + ">();").AppendLine();
            query.Append("\t\t\t" + "ListObj =  dat" + sEntidad + ".ListaFormID(" + sList + ").ToList<ent" + sEntidad + ">();").AppendLine();
            query.Append("\t\t\t" + "return ListObj;").AppendLine();
            query.Append("\t\t}").AppendLine();
            query.AppendLine();

            //Id
            query.Append("\t\t" + "public static ent" + sEntidad + " GetFormID(" + sIdPR + ")").AppendLine();
            query.Append("\t\t{").AppendLine();
            query.Append("\t\t\t" + "ent" + sEntidad + " EObj = new ent" + sEntidad + "();").AppendLine();
            query.Append("\t\t\t" + "List<ent" + sEntidad + "> ListObj = new List<ent" + sEntidad + ">();").AppendLine();
            query.Append("\t\t\t" + "ListObj = dat" + sEntidad + ".GetFormID(" + sId + ").ToList<ent" + sEntidad + ">();").AppendLine();
            query.Append("\t\t\t" + "if (ListObj.Count > 0){").AppendLine();
            query.Append("\t\t\t\t" + "EObj = ListObj[0]; EObj.ResultadoBusqueda = true;").AppendLine();
            query.Append("\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t" + "ListObj = null;").AppendLine();
            query.Append("\t\t\t" + "return EObj;").AppendLine();
            query.Append("\t\t}").AppendLine();
            query.AppendLine();

            //Combo
            if(bCombo){
                query.Append("\t\t" + "public static List<ent" + sEntidad + "> ListaCombo(" + sCmbPR + (sCmbPR.Length>0?",":"") + " String[] Def = null)").AppendLine();
                query.Append("\t\t{").AppendLine();
                query.Append("\t\t\t" + "List<ent" + sEntidad + "> ListObj = new List<ent" + sEntidad + ">();").AppendLine();
                query.Append("\t\t\t" + "ListObj = dat" + sEntidad + ".ListaCombo(" + sCmb + ").ToList<ent" + sEntidad + ">();").AppendLine();
                query.Append("\t\t\t" + "if (Def != null){").AppendLine();
                query.Append("\t\t\t\t" + "ListObj.Insert(0, new ent" + sEntidad + "() { Codigo = Def[0], Descripcion = Def[1] });").AppendLine();
                query.Append("\t\t\t" + "}").AppendLine();
                query.Append("\t\t\t" + "return ListObj;").AppendLine();
                query.Append("\t\t}").AppendLine();
                query.AppendLine();
            }

            //Search
            if(bBusq){
            query.Append("\t\t" + "public static List<ent" + sEntidad +"> ListaSearch(" + sBusqPR + ")").AppendLine();
            query.Append("\t\t{").AppendLine();
            query.Append("\t\t\t" + "List<ent" + sEntidad + "> ListObj = new List<ent" + sEntidad + ">();").AppendLine();
            query.Append("\t\t\t" + "ListObj = dat" + sEntidad + ".ListaSearch(" + sBusq + ").ToList<ent" + sEntidad + ">();").AppendLine();
            query.Append("\t\t\t" + "return ListObj;").AppendLine();
            query.Append("\t\t}").AppendLine();
            query.AppendLine();
            }

            //MantForm
            query.Append("\t\t" + "public static entErrores MantFormID(ent" + sEntidad + " Data)").AppendLine();
            query.Append("\t\t{").AppendLine();
            query.Append("\t\t\t" + "return dat" + sEntidad + ".MantFormID(Data);").AppendLine();
            query.Append("\t\t}").AppendLine();
            query.AppendLine();

            //Cerrando Clase y NameSpace
            query.Append("\t }").AppendLine();
            query.Append("}");
            txtQueryNegocio.Text = query.ToString();
        }

        private void fxGenerarData()
        {
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName;
            String sFolder = txtFolder.Text.Trim();
            String sEntidad = txtEntidad.Text.Trim();
            String sListPR = "", sIdPR = "", sCmbPR = "", sBusqPR = "", sValue = "";
            Boolean bCombo = false, bBusq = false;
            StringBuilder query = new StringBuilder();
            int nCount = gvDatos.DataRowCount;

            //Datos Cabecera
            query.Append("using System;").AppendLine();
            query.Append("using System.Collections.Generic;").AppendLine();
            query.Append("using System.Linq;").AppendLine();
            query.Append("using System.Text;").AppendLine();
            query.Append("using System.Threading.Tasks;").AppendLine();
            query.Append("using System.Data;").AppendLine();
            query.Append("using System.Data.SqlClient;").AppendLine();
            query.Append("using FiltroLys.Model." + sFolder + ";").AppendLine();
            query.Append("using FiltroLys.Model.Objeto;").AppendLine();
            query.Append("using FiltroLys.Repository.Objeto;").AppendLine();
            query.Append("using FiltroLys.Type;").AppendLine();
            query.AppendLine();

            query.Append("namespace FiltroLys.Repository." + sFolder).AppendLine();
            query.Append("{").AppendLine();
            query.Append("\t" + "public class dat" + sEntidad).AppendLine();
            query.Append("\t{").AppendLine();

            //Datos de Parametros
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.Sel.Equals(fnConst.ListaCondUpd) || objE.Sel.Equals(fnConst.ListaCondSelUpd)){
                    sListPR = sListPR + objE.TipoNetProp + " " + objE.Propiedad + ",";                    
                }

                if (objE.PkId.Equals("S")){
                    sIdPR = sIdPR + objE.TipoNetProp + " " + objE.Propiedad + ",";                    
                }

                if (objE.Combo.Equals(fnConst.ListaCondUpd) || objE.Combo.Equals(fnConst.ListaCondSelUpd)){
                    sCmbPR = sCmbPR + objE.TipoNetProp + " " + objE.Propiedad + ",";
                }

                if (objE.Search.Equals(fnConst.ListaCondUpd) || objE.Search.Equals(fnConst.ListaCondSelUpd)){
                    sBusqPR = sBusqPR + objE.TipoNetProp + " " + objE.Propiedad + ",";
                }

                if (!objE.Combo.Equals("")) { bCombo = true; }
                if (!objE.Search.Equals("")) { bBusq = true; }
            }

            sListPR = (sListPR.Length > 0) ? sListPR.Substring(0, sListPR.Length - 1) : "";
            sIdPR = (sIdPR.Length > 0) ? sIdPR.Substring(0, sIdPR.Length - 1) : "";
            sCmbPR = (sCmbPR.Length > 0) ? sCmbPR.Substring(0, sCmbPR.Length - 1) : "";
            sBusqPR = (sBusqPR.Length > 0) ? sBusqPR.Substring(0, sBusqPR.Length - 1) : "";
            
            //Select
            query.Append("\t\t" + "public static DataTable ListaFormID(" + sListPR + ")").AppendLine();
            query.Append("\t\t{").AppendLine();
            query.Append("\t\t\t" + "DataTable dt = new DataTable();").AppendLine();
            query.Append("\t\t\t" + "SqlCommand Cmd = new SqlCommand();").AppendLine();
            query.AppendLine();
            query.Append("\t\t\t" + "using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))").AppendLine();
            query.Append("\t\t\t{").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.Connection = Cnx;").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.Connection.Open();").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.CommandText = fnQuery.tsqGenXXX;").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.CommandType = CommandType.StoredProcedure;").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Accion\", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Opcion\", SqlDbType.VarChar)).Value = fnConst.OperLstMaestra;").AppendLine();
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.Sel.Equals(fnConst.ListaCondUpd) || objE.Sel.Equals(fnConst.ListaCondSelUpd)){
                    query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@" + objE.Propiedad + "\", SqlDbType.VarChar)).Value = " + objE.Propiedad + ";").AppendLine();
                }
            }
            query.AppendLine();
            query.Append("\t\t\t\t" + "SqlDataAdapter adapter = new SqlDataAdapter();").AppendLine();
            query.Append("\t\t\t\t" + "adapter.SelectCommand = Cmd;").AppendLine();
            query.Append("\t\t\t\t" + "adapter.Fill(dt);").AppendLine();
            query.Append("\t\t\t\t" + "if (Cmd.Connection.State == ConnectionState.Open)").AppendLine();
            query.Append("\t\t\t\t" + "{").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Connection.Close();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Connection.Dispose();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cnx.Close();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cnx.Dispose();").AppendLine();
            query.Append("\t\t\t\t\t" + "GC.SuppressFinalize(Cnx);").AppendLine();
            query.Append("\t\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t" + "return dt;").AppendLine();
            query.Append("\t\t" + "}").AppendLine();
            query.AppendLine();

            //Id
            query.Append("\t\t" + "public static DataTable GetFormID(" + sIdPR + ")").AppendLine();
            query.Append("\t\t{").AppendLine();
            query.Append("\t\t\t" + "DataTable dt = new DataTable();").AppendLine();
            query.Append("\t\t\t" + "SqlCommand Cmd = new SqlCommand();").AppendLine();
            query.AppendLine();
            query.Append("\t\t\t" + "using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))").AppendLine();
            query.Append("\t\t\t{").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.Connection = Cnx;").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.Connection.Open();").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.CommandText = fnQuery.tsqGenXXX;").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.CommandType = CommandType.StoredProcedure;").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Accion\", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;").AppendLine();
            query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Opcion\", SqlDbType.VarChar)).Value = fnConst.OperLstID;").AppendLine();
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.PkId.Equals("S")){
                    query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@" + objE.Propiedad + "\", SqlDbType.VarChar)).Value = " + objE.Propiedad + ";").AppendLine();
                }
            }
            query.AppendLine();
            query.Append("\t\t\t\t" + "SqlDataAdapter adapter = new SqlDataAdapter();").AppendLine();
            query.Append("\t\t\t\t" + "adapter.SelectCommand = Cmd;").AppendLine();
            query.Append("\t\t\t\t" + "adapter.Fill(dt);").AppendLine();
            query.Append("\t\t\t\t" + "if (Cmd.Connection.State == ConnectionState.Open)").AppendLine();
            query.Append("\t\t\t\t" + "{").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Connection.Close();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Connection.Dispose();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cnx.Close();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cnx.Dispose();").AppendLine();
            query.Append("\t\t\t\t\t" + "GC.SuppressFinalize(Cnx);").AppendLine();
            query.Append("\t\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t" + "return dt;").AppendLine();
            query.Append("\t\t" + "}").AppendLine();
            query.AppendLine();

            //Combo
            if(bCombo){
                query.Append("\t\t" + "public static DataTable ListaCombo(" + sCmbPR + ")").AppendLine();
                query.Append("\t\t{").AppendLine();
                query.Append("\t\t\t" + "DataTable dt = new DataTable();").AppendLine();
                query.Append("\t\t\t" + "SqlCommand Cmd = new SqlCommand();").AppendLine();
                query.AppendLine();
                query.Append("\t\t\t" + "using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))").AppendLine();
                query.Append("\t\t\t{").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.Connection = Cnx;").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.Connection.Open();").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.CommandText = fnQuery.tsqGenXXX;").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.CommandType = CommandType.StoredProcedure;").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Accion\", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Opcion\", SqlDbType.VarChar)).Value = fnConst.OperLstCombo;").AppendLine();
                for (int i = 0; i < gvDatos.DataRowCount; i++){
                    entColumna objE = (entColumna)gvDatos.GetRow(i);
                    if (objE.Combo.Equals(fnConst.ListaCondUpd) || objE.Combo.Equals(fnConst.ListaCondSelUpd)){
                        query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@" + objE.Propiedad + "\", SqlDbType.VarChar)).Value = " + objE.Propiedad + ";").AppendLine();
                    }
                }
                query.AppendLine();
                query.Append("\t\t\t\t" + "SqlDataAdapter adapter = new SqlDataAdapter();").AppendLine();
                query.Append("\t\t\t\t" + "adapter.SelectCommand = Cmd;").AppendLine();
                query.Append("\t\t\t\t" + "adapter.Fill(dt);").AppendLine();
                query.Append("\t\t\t\t" + "if (Cmd.Connection.State == ConnectionState.Open)").AppendLine();
                query.Append("\t\t\t\t" + "{").AppendLine();
                query.Append("\t\t\t\t\t" + "Cmd.Connection.Close();").AppendLine();
                query.Append("\t\t\t\t\t" + "Cmd.Connection.Dispose();").AppendLine();
                query.Append("\t\t\t\t\t" + "Cnx.Close();").AppendLine();
                query.Append("\t\t\t\t\t" + "Cnx.Dispose();").AppendLine();
                query.Append("\t\t\t\t\t" + "GC.SuppressFinalize(Cnx);").AppendLine();
                query.Append("\t\t\t\t" + "}").AppendLine();
                query.Append("\t\t\t" + "}").AppendLine();
                query.Append("\t\t\t" + "return dt;").AppendLine();
                query.Append("\t\t" + "}").AppendLine();
                query.AppendLine();
            }

            //Busq
            if(bBusq){
                query.Append("\t\t" + "public static DataTable ListaSearch(" + sBusqPR + ")").AppendLine();
                query.Append("\t\t{").AppendLine();
                query.Append("\t\t\t" + "DataTable dt = new DataTable();").AppendLine();
                query.Append("\t\t\t" + "SqlCommand Cmd = new SqlCommand();").AppendLine();
                query.AppendLine();
                query.Append("\t\t\t" + "using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))").AppendLine();
                query.Append("\t\t\t{").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.Connection = Cnx;").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.Connection.Open();").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.CommandText = fnQuery.tsqGenXXX;").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.CommandType = CommandType.StoredProcedure;").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Accion\", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;").AppendLine();
                query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Opcion\", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;").AppendLine();
                for (int i = 0; i < gvDatos.DataRowCount; i++){
                    entColumna objE = (entColumna)gvDatos.GetRow(i);
                    if (objE.Search.Equals(fnConst.ListaCondUpd) || objE.Search.Equals(fnConst.ListaCondSelUpd)){
                        query.Append("\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@" + objE.Propiedad + "\", SqlDbType.VarChar)).Value = " + objE.Propiedad + ";").AppendLine();
                    }
                }
                query.AppendLine();
                query.Append("\t\t\t\t" + "SqlDataAdapter adapter = new SqlDataAdapter();").AppendLine();
                query.Append("\t\t\t\t" + "adapter.SelectCommand = Cmd;").AppendLine();
                query.Append("\t\t\t\t" + "adapter.Fill(dt);").AppendLine();
                query.Append("\t\t\t\t" + "if (Cmd.Connection.State == ConnectionState.Open)").AppendLine();
                query.Append("\t\t\t\t" + "{").AppendLine();
                query.Append("\t\t\t\t\t" + "Cmd.Connection.Close();").AppendLine();
                query.Append("\t\t\t\t\t" + "Cmd.Connection.Dispose();").AppendLine();
                query.Append("\t\t\t\t\t" + "Cnx.Close();").AppendLine();
                query.Append("\t\t\t\t\t" + "Cnx.Dispose();").AppendLine();
                query.Append("\t\t\t\t\t" + "GC.SuppressFinalize(Cnx);").AppendLine();
                query.Append("\t\t\t\t" + "}").AppendLine();
                query.Append("\t\t\t" + "}").AppendLine();
                query.Append("\t\t\t" + "return dt;").AppendLine();
                query.Append("\t\t" + "}").AppendLine();
                query.AppendLine();
            }

            //Mantenimineto
            query.Append("\t\t" + "public static entErrores MantFormID(ent" + sEntidad + " Data)").AppendLine();
            query.Append("\t\t{").AppendLine();
            query.Append("\t\t\t" + "SqlCommand Cmd = new SqlCommand();").AppendLine();
            query.Append("\t\t\t" + "entErrores entErr = new entErrores();").AppendLine();
            query.Append("\t\t\t" + "String sMsj = \"\";").AppendLine();
            query.AppendLine();
            query.Append("\t\t\t" + "using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){").AppendLine();
            query.Append("\t\t\t\t" + "SqlTransaction Trs = null;").AppendLine();
            query.Append("\t\t\t\t" + "try{").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Connection = Cnx;").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Connection.Open();").AppendLine();
            query.Append("\t\t\t\t\t" + "Trs = Cnx.BeginTransaction();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Transaction = Trs;").AppendLine();
            query.AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.CommandType = CommandType.StoredProcedure;").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Parameters.Clear();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.CommandText = fnQuery.tsqGenXXX;").AppendLine();
            query.AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Accion\", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@Opcion\", SqlDbType.VarChar)).Value = Data.Opcion;").AppendLine();
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                sValue = objE.Propiedad;
                if(objE.FlagNull.Equals("S")){
                    switch (objE.Tipo){
                    case "varchar":
                    case "char":
                    case "nvarchar":
                    case "text":
                        sValue = "fnParmCmd.StrDBNull(Data." + sValue + ",\"\")";
                        break;
                    case "int":
                        sValue = "fnParmCmd.intDBNull(Data." + sValue + ")";
                        break;
                    case "decimal":
                    case "numeric":
                        sValue = "fnParmCmd.DecDBNull(Data." + sValue + ")";
                        break;
                    case "datetime":
                        sValue = "fnParmCmd.DatDBNull(Data." + sValue + ")";
                        break;
                    }
                }else{
                    sValue = "Data." + objE.Propiedad;
                }

                if (objE.Nombre.ToUpper().Contains("FECHAMOD") && objE.Nombre.ToUpper().Contains("ULT")) {
                    sValue = "";
                }else{
                    query.Append("\t\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@" + objE.Propiedad + "\", SqlDbType." + objE.TipoNetParam +")).Value = " + sValue + ";").AppendLine();
                }
            }            
            query.Append("\t\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@AudEstacion\", SqlDbType.VarChar)).Value = Data.EstacionSys;").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Parameters.Add(new SqlParameter(\"@AudFechaEst\", SqlDbType.DateTime)).Value = Data.FechaSys;").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.ExecuteNonQuery();").AppendLine();
            query.AppendLine();
            query.Append("\t\t\t\t\t" + "Trs.Commit();").AppendLine();
            query.Append("\t\t\t\t\t" + "entErr.Resultado = true;").AppendLine();
            query.Append("\t\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t\t" + "catch (Exception ex)").AppendLine();
            query.Append("\t\t\t\t" + "{").AppendLine();
            query.Append("\t\t\t\t\t" + "Trs.Rollback();").AppendLine();
            query.Append("\t\t\t\t\t" + "sMsj = ex.Message;").AppendLine();
            query.Append("\t\t\t\t\t" + "entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = sMsj });").AppendLine();
            query.Append("\t\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t\t" + "finally").AppendLine();
            query.Append("\t\t\t\t" + "{").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Connection.Close();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cmd.Connection.Dispose();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cnx.Close();").AppendLine();
            query.Append("\t\t\t\t\t" + "Cnx.Dispose();").AppendLine();
            query.Append("\t\t\t\t\t" + "Trs.Dispose();").AppendLine();
            query.Append("\t\t\t\t\t" + "Data = null;").AppendLine();
            query.Append("\t\t\t\t\t" + "GC.SuppressFinalize(Cnx);").AppendLine();
            query.Append("\t\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t" + "}").AppendLine();
            query.Append("\t\t\t" + "return entErr;").AppendLine();
            query.Append("\t\t" + "}").AppendLine();

            //Cerrando Clase y NameSpace
            query.Append("\t }").AppendLine();
            query.Append("}");
            txtQueryData.Text = query.ToString();
        }

        private void fxGenerarStoreProc()
        {
            String sTabla = ((entTabla)cmbTabla.GetSelectedDataRow()).TableName.ToLower();
            String sFolder = txtFolder.Text.Trim();
            String sEntidad = txtEntidad.Text.Trim();
            StringBuilder query = new StringBuilder();
            String sSelect = "" ,sWhere="";
            Int32 nContSelect = 0, nDivisorSelect = 7, nSelect = 0, nMax = 0, nMaxLenght = 0, nMaxTab = 0; 
            Boolean bInicio = true;
            int nCount = gvDatos.DataRowCount;

            //Maximo Ancho
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (!(objE.Nombre.ToUpper().Contains("FECHAMOD") && objE.Nombre.ToUpper().Contains("ULT"))) {
                    nMax = objE.Nombre.Length;
                    if (nMaxLenght < nMax) { nMaxLenght = nMax; }
                }
            }
            nMaxTab = (nMaxLenght / 4) + 1;

            //Parametros
            query.Append("create proc UP_" + sTabla.Substring(0,2).ToUpper() + "_MANT_" + sEntidad.ToUpper()).AppendLine();
            query.Append(fnTabGen("@Accion",nMaxTab) + "varchar(5)  = null,").AppendLine();
            query.Append(fnTabGen("@Opcion",nMaxTab) + "varchar(10) = null,").AppendLine();
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (!(objE.Nombre.ToUpper().Contains("FECHAMOD") && objE.Nombre.ToUpper().Contains("ULT"))) {
                    query.Append(fnTabGen("@" + objE.Propiedad.Trim(), nMaxTab) + objE.Tipo + objE.AnchoSP + " = null,").AppendLine();
                }
            }
            query.Append(fnTabGen("@AudEstacion",nMaxTab) + "varchar(10) = null,").AppendLine();
            query.Append(fnTabGen("@AudFechaEst", nMaxTab) +"datetime = null").AppendLine();
            query.Append("as").AppendLine();
            query.Append("SET NOCOUNT ON").AppendLine();
            query.Append("Declare @FechaServ datetime,@ErrCod varchar(20),@ErrMsj varchar(max),@Mensaje varchar(max)").AppendLine();
            query.AppendLine();
            query.Append("Set @FechaServ = getdate()").AppendLine();
            query.Append("Set @Mensaje = ''").AppendLine();
            query.AppendLine();
            query.Append("/**********************************************/").AppendLine();
            query.Append("/**************LISTADO GENERALES***************/").AppendLine();
            query.Append("/**********************************************/").AppendLine();
            query.Append("if @Accion = 'LST'").AppendLine();
            query.Append("Begin").AppendLine();

            //Lista Maestra
            sSelect = "";
            nSelect = 0;
            sWhere = "";
            nContSelect = 0;
            query.Append("\t" + "if @Opcion = 'LSTMAE'").AppendLine();
            query.Append("\t" + "Begin").AppendLine();

            query.Append("\t\t" + "Select ");
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.Sel.Equals(fnConst.ListaCondSel) || objE.Sel.Equals(fnConst.ListaCondSelUpd)){nContSelect++;}
            }

            bInicio = true;
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);                
                if(objE.Sel.Equals(fnConst.ListaCondSel)|| objE.Sel.Equals(fnConst.ListaCondSelUpd)){
                    sSelect = sSelect + objE.Nombre;
                    nSelect = nSelect + 1;
                    if (nSelect < nContSelect) { sSelect = sSelect + ","; }
                    if((nSelect % nDivisorSelect)==0){                        
                        if (bInicio) { query.Append(sSelect).AppendLine(); sSelect = ""; bInicio = false; }
                        else { query.Append("\t\t\t   " + sSelect).AppendLine(); sSelect = ""; }
                    }
                    if (nSelect == nContSelect && (nSelect % nDivisorSelect) != 0){                        
                        if (nSelect > nDivisorSelect) { query.Append("\t\t\t   "); }
                        query.Append(sSelect).AppendLine();
                    }
                }
            }
            query.Append("\t\t" + "from " + sTabla).AppendLine();
            bInicio = true;
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);                
                if(objE.Sel.Equals(fnConst.ListaCondUpd)|| objE.Sel.Equals(fnConst.ListaCondSelUpd)){
                    sWhere = "\t\t";
                    if (bInicio) { sWhere = sWhere + "where " + objE.Nombre + " = @" + objE.Propiedad; bInicio = false; }
                    else {
                        sWhere = sWhere + "and " + objE.Nombre + " = @" + objE.Propiedad;
                    }
                    query.Append(sWhere).AppendLine();
                }
            }
            
            query.Append("\t" + "End").AppendLine();
            query.AppendLine();

            //Lista ID
            sSelect = "";
            nSelect = 0;
            sWhere = "";
            nContSelect = 0;
            query.Append("\t" + "if @Opcion = 'GETID'").AppendLine();
            query.Append("\t" + "Begin").AppendLine();

            query.Append("\t\t" + "Select ");
            for (int i = 0; i < gvDatos.DataRowCount; i++){nContSelect++;}

            bInicio = true;
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                sSelect = sSelect + objE.Nombre;
                nSelect = nSelect + 1;
                if (nSelect < nContSelect) { sSelect = sSelect + ","; }
                if ((nSelect % nDivisorSelect) == 0){                    
                    if (bInicio) { query.Append(sSelect).AppendLine(); sSelect = ""; bInicio = false; }
                    else { query.Append("\t\t\t   " + sSelect).AppendLine(); sSelect = ""; }
                }
                if (nSelect == nContSelect && (nSelect % nDivisorSelect) != 0){                    
                    if (nSelect > nDivisorSelect) { query.Append("\t\t\t   "); }
                    query.Append(sSelect).AppendLine();
                }
            }
            query.Append("\t\t" + "from " + sTabla).AppendLine();
            bInicio = true;
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.PkId.Equals("S")){
                    sWhere = "\t\t";
                    if (bInicio) { sWhere = sWhere + "where " + objE.Nombre + " = @" + objE.Propiedad; bInicio = false; }
                    else{
                        sWhere = sWhere + "and " + objE.Nombre + " = @" + objE.Propiedad;
                    }
                    query.Append(sWhere).AppendLine();
                }
            }

            query.Append("\t" + "End").AppendLine();
            
            //Lista Combo
            sSelect = "";
            nSelect = 0;
            sWhere = "";
            nContSelect = 0;
            for (int i = 0; i < gvDatos.DataRowCount; i++) { 
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if(!objE.Combo.Equals("")){nContSelect++;}
            }

            if(nContSelect>0){
                query.AppendLine();
                nContSelect = 0;
                query.Append("\t" + "if @Opcion = 'LSTCMB'").AppendLine();
                query.Append("\t" + "Begin").AppendLine();

                query.Append("\t\t" + "Select ");
                for (int i = 0; i < gvDatos.DataRowCount; i++){
                    entColumna objE = (entColumna)gvDatos.GetRow(i);
                    if (objE.Combo.Equals(fnConst.ListaCondSel) || objE.Combo.Equals(fnConst.ListaCondSelUpd)) { nContSelect++; }
                }

                bInicio = true;
                for (int i = 0; i < gvDatos.DataRowCount; i++){
                    entColumna objE = (entColumna)gvDatos.GetRow(i);
                    if (objE.Combo.Equals(fnConst.ListaCondSel) || objE.Combo.Equals(fnConst.ListaCondSelUpd)){
                        sSelect = sSelect + objE.Nombre;
                        nSelect = nSelect + 1;
                        if (nSelect < nContSelect) { sSelect = sSelect + ","; }
                        if ((nSelect % nDivisorSelect) == 0){                            
                            if (bInicio) { query.Append(sSelect).AppendLine(); sSelect = ""; bInicio = false; }
                            else { query.Append("\t\t\t   " + sSelect).AppendLine(); sSelect = ""; }
                        }
                        if (nSelect == nContSelect && (nSelect % nDivisorSelect) != 0){                            
                            if (nSelect > nDivisorSelect) { query.Append("\t\t\t   "); }
                            query.Append(sSelect).AppendLine();
                        }
                    }
                }
                query.Append("\t\t" + "from " + sTabla).AppendLine();
                bInicio = true;
                for (int i = 0; i < gvDatos.DataRowCount; i++){
                    entColumna objE = (entColumna)gvDatos.GetRow(i);
                    if (objE.Combo.Equals(fnConst.ListaCondUpd) || objE.Combo.Equals(fnConst.ListaCondSelUpd)){
                        sWhere = "\t\t";
                        if (bInicio) { sWhere = sWhere + "where " + objE.Nombre + " = @" + objE.Propiedad; bInicio = false; }
                        else{
                            sWhere = sWhere + "and " + objE.Nombre + " = @" + objE.Propiedad;
                        }
                        query.Append(sWhere).AppendLine();
                    }
                }

                query.Append("\t" + "End").AppendLine();                
            }

            //Lista Busqueda
            sSelect = "";
            nSelect = 0;
            sWhere = "";
            nContSelect = 0;
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (!objE.Search.Equals("")) { nContSelect++; }
            }

            if (nContSelect > 0){
                query.AppendLine();
                nContSelect = 0;
                query.Append("\t" + "if @Opcion = 'LSTBUS'").AppendLine();
                query.Append("\t" + "Begin").AppendLine();

                query.Append("\t\t" + "Select ");
                for (int i = 0; i < gvDatos.DataRowCount; i++){
                    entColumna objE = (entColumna)gvDatos.GetRow(i);
                    if (objE.Search.Equals(fnConst.ListaCondSel) || objE.Search.Equals(fnConst.ListaCondSelUpd)) { nContSelect++; }
                }

                bInicio = true;
                for (int i = 0; i < gvDatos.DataRowCount; i++){
                    entColumna objE = (entColumna)gvDatos.GetRow(i);
                    if (objE.Search.Equals(fnConst.ListaCondSel) || objE.Search.Equals(fnConst.ListaCondSelUpd)){
                        sSelect = sSelect + objE.Nombre;
                        nSelect = nSelect + 1;
                        if (nSelect < nContSelect) { sSelect = sSelect + ","; }
                        if ((nSelect % nDivisorSelect) == 0){                           
                            if (bInicio) { query.Append(sSelect).AppendLine(); sSelect = ""; bInicio = false; }
                            else { query.Append("\t\t\t   " + sSelect).AppendLine(); sSelect = ""; }
                        }
                        if (nSelect == nContSelect && (nSelect % nDivisorSelect) != 0){                            
                            if (nSelect > nDivisorSelect) { query.Append("\t\t\t   "); }
                            query.Append(sSelect).AppendLine();
                        }
                    }
                }
                query.Append("\t\t" + "from " + sTabla).AppendLine();
                bInicio = true;
                for (int i = 0; i < gvDatos.DataRowCount; i++){
                    entColumna objE = (entColumna)gvDatos.GetRow(i);
                    if (objE.Search.Equals(fnConst.ListaCondUpd) || objE.Search.Equals(fnConst.ListaCondSelUpd)){
                        sWhere = "\t\t";
                        if (bInicio) { sWhere = sWhere + "where " + objE.Nombre + " = @" + objE.Propiedad; bInicio = false; }
                        else{
                            sWhere = sWhere + "and " + objE.Nombre + " = @" + objE.Propiedad;
                        }
                        query.Append(sWhere).AppendLine();
                    }
                }

                query.Append("\t" + "End").AppendLine();
                query.AppendLine();
            }

            query.Append("End").AppendLine();
            query.AppendLine();
            query.Append("/**********************************************/").AppendLine();
            query.Append("/************PROCESO DE INSERCION**************/").AppendLine();
            query.Append("/**********************************************/").AppendLine();
            query.Append("if @Accion = 'INS'").AppendLine();
            query.Append("Begin").AppendLine();
            query.Append("\t" + "if @Opcion = 'ID'").AppendLine();
            query.Append("\t" + "Begin").AppendLine();
		    query.Append("\t\t" + "BEGIN TRY").AppendLine();
            query.Append("\t\t\t" + "Insert into " + sTabla + "(").AppendLine();

            sSelect = "";
            nSelect = 0;
            nContSelect = 0;            
            for (int i = 0; i < gvDatos.DataRowCount; i++){nContSelect++;}

            bInicio = true;
            query.Append("\t\t\t");
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                sSelect = sSelect + objE.Nombre;
                nSelect = nSelect + 1;
                if (nSelect < nContSelect) { sSelect = sSelect + ","; }
                if ((nSelect % nDivisorSelect) == 0){                    
                    if (bInicio) { query.Append(sSelect + ((nSelect == nContSelect)?")":"")).AppendLine(); sSelect = ""; bInicio = false; }
                    else { query.Append("\t\t\t" + sSelect + ((nSelect == nContSelect) ? ")" : "")).AppendLine(); sSelect = ""; }
                }
                if (nSelect == nContSelect && (nSelect % nDivisorSelect) != 0){                    
                    if (nSelect > nDivisorSelect) { query.Append("\t\t\t"); }
                    query.Append(sSelect + ")").AppendLine();
                }                
            }
            query.Append("\t\t\t" + "Values(");
            bInicio = true;
            nSelect = 0;
            sSelect = "";
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.Nombre.ToUpper().Contains("FECHAMOD") && objE.Nombre.ToUpper().Contains("ULT")){
                    sSelect = sSelect + "@FechaServ";
                }
                else {
                    sSelect = sSelect + "@" + objE.Propiedad;
                }
                nSelect = nSelect + 1;
                if (nSelect < nContSelect) { sSelect = sSelect + ","; }
                if ((nSelect % nDivisorSelect) == 0){                    
                    if (bInicio) { query.Append(sSelect + ((nSelect == nContSelect)?")":"")).AppendLine(); sSelect = ""; bInicio = false; }
                    else { query.Append("\t\t\t" + sSelect + ((nSelect == nContSelect) ? ")" : "")).AppendLine(); sSelect = ""; }
                }
                if (nSelect == nContSelect && (nSelect % nDivisorSelect) != 0){                    
                    if (nSelect > nDivisorSelect) { query.Append("\t\t\t"); }
                    query.Append(sSelect + ")").AppendLine();
                }
            }
            query.Append("\t\t" + "END TRY").AppendLine();
		    query.Append("\t\t" + "BEGIN CATCH").AppendLine();
			query.Append("\t\t\t" + "Set @ErrCod = convert(varchar,ERROR_NUMBER())").AppendLine();
			query.Append("\t\t\t" + "Set @ErrMsj = convert(varchar,ERROR_MESSAGE())").AppendLine();
			query.Append("\t\t\t" + "Set @Mensaje = dbo.uf_ErrorSQLDefinido(@ErrCod,@ErrMsj)").AppendLine();
			query.Append("\t\t\t" + "raiserror(@Mensaje,16,1)").AppendLine();
		    query.Append("\t\t" + "END CATCH").AppendLine();
	        query.Append("\t" + "End").AppendLine();
            query.Append("End").AppendLine();
            query.AppendLine();

            query.Append("/**********************************************/").AppendLine();
            query.Append("/**********PROCESO DE ACTUALIZACION************/").AppendLine();
            query.Append("/**********************************************/").AppendLine();
            query.Append("if @Accion = 'UPD'").AppendLine();
            query.Append("Begin").AppendLine();
            query.Append("\t" + "if @Opcion = 'ID'").AppendLine();
            query.Append("\t" + "Begin").AppendLine();
		    query.Append("\t\t" + "BEGIN TRY").AppendLine();
            query.Append("\t\t\t" + "Update " + sTabla).AppendLine();
            query.Append("\t\t\t" + "Set ");

            bInicio = true;
            sSelect = "";
            nSelect = 0;
            nContSelect = 0;
            for (int i = 0; i < gvDatos.DataRowCount; i++) {
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if(!objE.PkId.Equals("S")){nContSelect++;}
            }

            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if(!objE.PkId.Equals("S")){
                    nSelect = nSelect + 1;
                    if (bInicio) {
                        if (objE.Nombre.ToUpper().Contains("FECHAMOD") && objE.Nombre.ToUpper().Contains("ULT")){
                            sSelect = fnTabGen(objE.Nombre.Trim(), nMaxTab) + " = @FechaServ" + ((nSelect == nContSelect ? "" : ",")); bInicio = false;
                        }else{
                            sSelect = fnTabGen(objE.Nombre.Trim(), nMaxTab) + " = @" + objE.Propiedad + ((nSelect == nContSelect ? "" : ",")); bInicio = false;
                        }
                    }else{
                        if (objE.Nombre.ToUpper().Contains("FECHAMOD") && objE.Nombre.ToUpper().Contains("ULT")){
                            sSelect = "\t\t\t\t" + fnTabGen(objE.Nombre.Trim(), nMaxTab) + " = @FechaServ" + ((nSelect == nContSelect ? "" : ","));
                        }else{
                            sSelect = "\t\t\t\t" + fnTabGen(objE.Nombre.Trim(), nMaxTab) + " = @" + objE.Propiedad + ((nSelect == nContSelect ? "" : ","));
                        }
                    }
                    query.Append(sSelect).AppendLine();
                }  
            }
            query.Append("\t\t\t" + "where ");

            bInicio = true;
            sSelect = "";
            nSelect = 0;
            nContSelect = 0;
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.PkId.Equals("S")) { nContSelect++; }
            }

            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if(objE.PkId.Equals("S")){
                    nSelect = nSelect + 1;
                    if (bInicio) { sSelect = objE.Nombre + " = @" + objE.Propiedad + ((nSelect==nContSelect?"":"")); bInicio = false; }
                    else { sSelect = "\t\t\t" + "and " + objE.Nombre + " = @" + objE.Propiedad + ((nSelect == nContSelect ? "" : "")); }
                    query.Append(sSelect).AppendLine();
                }
            }
            query.Append("\t\t" + "END TRY").AppendLine();
		    query.Append("\t\t" + "BEGIN CATCH").AppendLine();
			query.Append("\t\t\t" + "Set @ErrCod = convert(varchar,ERROR_NUMBER())").AppendLine();
			query.Append("\t\t\t" + "Set @ErrMsj = convert(varchar,ERROR_MESSAGE())").AppendLine();
			query.Append("\t\t\t" + "Set @Mensaje = dbo.uf_ErrorSQLDefinido(@ErrCod,@ErrMsj)").AppendLine();
			query.Append("\t\t\t" + "raiserror(@Mensaje,16,1)").AppendLine();
		    query.Append("\t\t" + "END CATCH").AppendLine();	
	        query.Append("\t" + "End").AppendLine();
            query.Append("End").AppendLine();
            query.AppendLine();

            /**********************************************/
            /************PROCESO DE ELIMINACIÓN************/
            /**********************************************/
            query.Append("if @Accion = 'DEL'").AppendLine();
            query.Append("Begin").AppendLine();
            query.Append("\t" + "if @Opcion = 'ID'").AppendLine();
            query.Append("\t" + "Begin").AppendLine();
		    query.Append("\t\t" + "BEGIN TRY").AppendLine();
            query.Append("\t\t\t" + "Delete " + sTabla).AppendLine();

            query.Append("\t\t\t" + "where ");

            bInicio = true;
            sSelect = "";
            nSelect = 0;
            nContSelect = 0;
            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.PkId.Equals("S")) { nContSelect++; }
            }

            for (int i = 0; i < gvDatos.DataRowCount; i++){
                entColumna objE = (entColumna)gvDatos.GetRow(i);
                if (objE.PkId.Equals("S")){
                    nSelect = nSelect + 1;
                    if (bInicio) { sSelect = objE.Nombre + " = @" + objE.Propiedad + ((nSelect == nContSelect ? "" : "")); bInicio = false; }
                    else { sSelect = "\t\t\t" + "and " + objE.Nombre + " = @" + objE.Propiedad + ((nSelect == nContSelect ? "" : "")); }
                    query.Append(sSelect).AppendLine();
                }
            }

            query.Append("\t\t" + "END TRY").AppendLine();
		    query.Append("\t\t" + "BEGIN CATCH").AppendLine();
			query.Append("\t\t\t" + "Set @ErrCod = convert(varchar,ERROR_NUMBER())").AppendLine();
			query.Append("\t\t\t" + "Set @ErrMsj = convert(varchar,ERROR_MESSAGE())").AppendLine();
			query.Append("\t\t\t" + "Set @Mensaje = dbo.uf_ErrorSQLDefinido(@ErrCod,@ErrMsj)").AppendLine();
			query.Append("\t\t\t" + "raiserror(@Mensaje,16,1)").AppendLine();
		    query.Append("\t\t" + "END CATCH").AppendLine();
	        query.Append("\t" + "End").AppendLine();
            query.Append("End").AppendLine();

            txtQueryStore.Text = query.ToString();
        }

        private String fnTabGen(String xTxt, Int32 nMax)
        {
            Int32 nRangoTab = 4;
            String sRet = xTxt;
            Int32 nTabs = xTxt.Length / nRangoTab;

            sRet = sRet.PadRight(xTxt.Length + nMax - nTabs, '\t');
            return sRet;
        }

        #endregion

        
        

    }
}
