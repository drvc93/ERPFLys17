using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Model.Seguridad;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Seguridad
{
    public class datUsuario{

        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqUsuario;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstMaestra;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.Fill(dt);
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return dt;
        }

        public static DataTable GetFormID(String Codigo)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqUsuario;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.VarChar)).Value = Codigo;
                
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.Fill(dt);
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return dt;
        }

        public static DataTable ListaCombo(String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqUsuario;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstCombo;                
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.Fill(dt);
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return dt;
        }

        public static DataTable ListaSearch(String Codigo, String Nombre, String CentroCosto, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqUsuario;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.VarChar)).Value = Codigo;
                Cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar)).Value = Nombre;
                Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = CentroCosto;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Cmd;
                adapter.Fill(dt);
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return dt;
        }

        public static entErrores MantFormID(entUsuario Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            String sMsj = "";

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                SqlTransaction Trs = null;
                try
                {
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Clear();
                    Cmd.CommandText = fnQuery.tsqUsuario;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.VarChar)).Value = Data.CodigoUsuario;
                    Cmd.Parameters.Add(new SqlParameter("@Perfil", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Perfil, "");
                    Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.Persona);
                    Cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Nombre, "");
                    Cmd.Parameters.Add(new SqlParameter("@Clave", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Clave, "");
                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Centrocosto, "");
                    Cmd.Parameters.Add(new SqlParameter("@Supervisor", SqlDbType.VarChar)).Value = Data.Supervisor;
                    Cmd.Parameters.Add(new SqlParameter("@EsCobranza", SqlDbType.VarChar)).Value = Data.EsCobranza;
                    Cmd.Parameters.Add(new SqlParameter("@Esventa", SqlDbType.VarChar)).Value = Data.EsVenta;
                    Cmd.Parameters.Add(new SqlParameter("@Consultor", SqlDbType.VarChar)).Value = Data.Consultor;
                    Cmd.Parameters.Add(new SqlParameter("@Sac", SqlDbType.VarChar)).Value = Data.Sac;
                    Cmd.Parameters.Add(new SqlParameter("@ClaveCat", SqlDbType.VarChar)).Value = Data.ClaveCat;
                    Cmd.Parameters.Add(new SqlParameter("@Firma", SqlDbType.VarChar)).Value = Data.Firma;
                    Cmd.Parameters.Add(new SqlParameter("@Serie", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Serie, "");
                    Cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Correo, "");
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.EsVenta;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UltimoUsuario, "");
                    Cmd.Parameters.Add(new SqlParameter("@PedidoExterior", SqlDbType.VarChar)).Value = Data.PedidoExterior;
                    Cmd.Parameters.Add(new SqlParameter("@PedidoNacional", SqlDbType.VarChar)).Value = Data.PedidoNacional;
                    Cmd.Parameters.Add(new SqlParameter("@ImprimeTransaccion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ImprimeTransaccion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Logistica", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Logistica, "");
                    Cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Cargo, "");
                    Cmd.Parameters.Add(new SqlParameter("@ParametroFormatoOrden", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.ParametroFormatoOrden);
                    Cmd.Parameters.Add(new SqlParameter("@FlagEvaluacion", SqlDbType.VarChar)).Value = Data.FlagEvaluacion;
                    Cmd.Parameters.Add(new SqlParameter("@CompEvaluacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CompEvaluacion,"");
                    Cmd.Parameters.Add(new SqlParameter("@FlagEvaluar", SqlDbType.VarChar)).Value = Data.FlagEvaluar;
                    Cmd.Parameters.Add(new SqlParameter("@FlagIngenieria", SqlDbType.VarChar)).Value = Data.FlagIngenieria;
                    Cmd.Parameters.Add(new SqlParameter("@FlagFirmaCarta", SqlDbType.VarChar)).Value = Data.FlagFirmaCarta;
                    Cmd.Parameters.Add(new SqlParameter("@NombreFirmaCarta", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NombreFirmaCarta, "");
                    Cmd.Parameters.Add(new SqlParameter("@PersonaEntregaRendir", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.PersonaEntregaRendir);
                    Cmd.Parameters.Add(new SqlParameter("@FlagVend_Rep", SqlDbType.VarChar)).Value = Data.FlagVend_Rep;
                    Cmd.Parameters.Add(new SqlParameter("@TipoAccesoRepG", SqlDbType.VarChar)).Value = Data.TipoAccesoRepG;
                    Cmd.Parameters.Add(new SqlParameter("@FlagTodo_ReqP", SqlDbType.VarChar)).Value = Data.FlagTodo_ReqP;
                    Cmd.Parameters.Add(new SqlParameter("@FlagTodo_CapP", SqlDbType.VarChar)).Value = Data.FlagTodo_CapP;
                    Cmd.Parameters.Add(new SqlParameter("@FlagModif_Eval", SqlDbType.VarChar)).Value = Data.FlagModif_Eval;
                    Cmd.Parameters.Add(new SqlParameter("@Flag_TodasMarcaciones", SqlDbType.VarChar)).Value = Data.Flag_TodasMarcaciones;
                    Cmd.Parameters.Add(new SqlParameter("@Flag_TodaProgvacacion", SqlDbType.VarChar)).Value = Data.Flag_TodaProgVacacion;
                    Cmd.Parameters.Add(new SqlParameter("@Flag_DerivacionMC", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Flag_DerivacionMC, "");
                    Cmd.Parameters.Add(new SqlParameter("@Flag_TodasSolicitudMtto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Flag_TodasSolicitudMtto, "");
                    Cmd.Parameters.Add(new SqlParameter("@Flag_Emp_Mtto", SqlDbType.VarChar)).Value = Data.Flag_Emp_Mtto;
                    Cmd.Parameters.Add(new SqlParameter("@FlagTranslado_Prod", SqlDbType.VarChar)).Value = Data.FlagTranslado_Prod;
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoIdentidad", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoIdentidad, "");
                    Cmd.Parameters.Add(new SqlParameter("@Flag_AccesoProv", SqlDbType.VarChar)).Value = Data.Flag_AccesoProv;
                    Cmd.Parameters.Add(new SqlParameter("@Supervisor_Iso", SqlDbType.VarChar)).Value = Data.Supervisor_Iso;
                    Cmd.Parameters.Add(new SqlParameter("@Conformidad_Doc", SqlDbType.VarChar)).Value = Data.Conformidad_Doc;
                    Cmd.Parameters.Add(new SqlParameter("@Rd_Iso", SqlDbType.VarChar)).Value = Data.Rd_Iso;
                    Cmd.Parameters.Add(new SqlParameter("@Ver_Todas_Area", SqlDbType.VarChar)).Value = Data.Ver_Todas_Area;
                    Cmd.Parameters.Add(new SqlParameter("@Flag_TodaAgenda", SqlDbType.VarChar)).Value = Data.Flag_TodaAgenda;
                    Cmd.Parameters.Add(new SqlParameter("@AccesoRepComision", SqlDbType.VarChar)).Value = Data.AccesoRepComision;
                    Cmd.Parameters.Add(new SqlParameter("@Flag_TodoMemo", SqlDbType.VarChar)).Value = Data.Flag_TodoMemo;
                    Cmd.Parameters.Add(new SqlParameter("@Anexo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Anexo, "");
                    Cmd.Parameters.Add(new SqlParameter("@Movil", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Movil, "");
                    Cmd.Parameters.Add(new SqlParameter("@Movil2", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Movil2, "");
                    Cmd.Parameters.Add(new SqlParameter("@Flag_TodoVisita", SqlDbType.VarChar)).Value = Data.Flag_TodoVisita;
                    Cmd.Parameters.Add(new SqlParameter("@CompComision", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CompComision,"");
                    Cmd.Parameters.Add(new SqlParameter("@EmpComision", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.EmpComision);
                    Cmd.Parameters.Add(new SqlParameter("@Flag_TodoIndicador", SqlDbType.VarChar)).Value = Data.Flag_TodoIndicador;
                    Cmd.Parameters.Add(new SqlParameter("@AccesoRepVenta", SqlDbType.VarChar)).Value = Data.AccesoRepVenta;
                    Cmd.Parameters.Add(new SqlParameter("@FlagAPT", SqlDbType.VarChar)).Value = Data.FlagAPT;
                    Cmd.Parameters.Add(new SqlParameter("@FlagSuperAPT", SqlDbType.VarChar)).Value = Data.FlagSuperAPT;
                    Cmd.Parameters.Add(new SqlParameter("@FlagDerivaCotiza", SqlDbType.VarChar)).Value = Data.FlagDerivaCotiza;                
                    Cmd.Parameters.Add(new SqlParameter("@AudEstacion", SqlDbType.VarChar)).Value = Data.EstacionSys;
                    Cmd.Parameters.Add(new SqlParameter("@AudFechaEst", SqlDbType.DateTime)).Value = Data.FechaSys;
                    Cmd.ExecuteNonQuery();

                    Trs.Commit();
                    entErr.Resultado = true;
                }
                catch (Exception ex)
                {
                    Trs.Rollback();
                    sMsj = ex.Message;
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = sMsj });
                }
                finally
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    Data = null;
                    GC.SuppressFinalize(Cnx);
                }
            }
            return entErr;
        }

        public static Int32 GetValidarAcceso(String Usuario, String Clave)
        {
            Int32 nResult = -1;
            SqlCommand Cmd = new SqlCommand();
            String sClave = "";
            sClave = datEncriptar.fnEncriptar(Clave);

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqUsuario;
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.Clear();
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "VALIDA";
                Cmd.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.VarChar)).Value = Usuario;
                Cmd.Parameters.Add(new SqlParameter("@Clave", SqlDbType.VarChar)).Value = sClave;
                nResult = (Int32)(Cmd.ExecuteScalar());

                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return nResult;
        }

    }
}
