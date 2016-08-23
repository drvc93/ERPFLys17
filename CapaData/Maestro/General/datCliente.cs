using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Maestro.General
{
    public class datCliente
    {
        public static DataTable ListaFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCliente;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstMaestra;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;

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

        public static DataTable GetFormID(String Compania, Int32 Cliente)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCliente;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Cliente", SqlDbType.Int)).Value = Cliente;
                
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

        public static DataTable ListaCombo(String Compania, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCliente;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstCombo;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
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

        public static DataTable ListaSearch(String Compania, Int32 Cliente, String RazonSocial, String Documento, String DocumentoFiscal, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCliente;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Cliente", SqlDbType.Int)).Value = Cliente;
                Cmd.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.VarChar)).Value = RazonSocial;
                Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = Documento;
                Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = DocumentoFiscal;
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

        public static entErrores MantFormID(entCliente Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            String sMsj = "";

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Clear();
                    Cmd.CommandText = fnQuery.tsqCliente;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = Data.Pais;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Cliente", SqlDbType.Int)).Value = Data.Cliente;
                    Cmd.Parameters.Add(new SqlParameter("@TipoPersona", SqlDbType.VarChar)).Value = Data.TipoPersona;
                    Cmd.Parameters.Add(new SqlParameter("@ApellidosPaterno", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ApellidosPaterno,"");
                    Cmd.Parameters.Add(new SqlParameter("@ApellidosMaterno", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ApellidosMaterno,"");
                    Cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Nombres,"");
                    Cmd.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.VarChar)).Value = Data.RazonSocial;
                    Cmd.Parameters.Add(new SqlParameter("@NombreBusqueda", SqlDbType.VarChar)).Value = Data.NombreBusqueda;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDocumentoPersona", SqlDbType.VarChar)).Value = Data.TipoDocumentoPersona;
                    Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Documento,"");
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoFiscal,"");
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoIdentidad", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoIdentidad,"");
                    Cmd.Parameters.Add(new SqlParameter("@CarnetExtranjeria", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CarnetExtranjeria,"");
                    Cmd.Parameters.Add(new SqlParameter("@Pasaporte", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Pasaporte,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaInicioOperaciones", SqlDbType.VarChar)).Value = fnParmCmd.DatDBNull(Data.FechaInicioOperaciones);
                    Cmd.Parameters.Add(new SqlParameter("@Nacionalidad", SqlDbType.VarChar)).Value = Data.Nacionalidad;
                    Cmd.Parameters.Add(new SqlParameter("@DireccionFiscal", SqlDbType.VarChar)).Value = Data.DireccionFiscal;
                    Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = Data.Pais;
                    Cmd.Parameters.Add(new SqlParameter("@DepartamentoCodigo", SqlDbType.VarChar)).Value = Data.DepartamentoCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@ProvinciaCodigo", SqlDbType.VarChar)).Value = Data.ProvinciaCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@DistritoCodigo", SqlDbType.VarChar)).Value = Data.DistritoCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Mail", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Mail,"");
                    Cmd.Parameters.Add(new SqlParameter("@ClienteAnterior", SqlDbType.VarChar)).Value = fnParmCmd.intDBNull(Data.ClienteAnterior);
                    Cmd.Parameters.Add(new SqlParameter("@EstadoRuteo", SqlDbType.VarChar)).Value = Data.EstadoRuteo;
                    Cmd.Parameters.Add(new SqlParameter("@EstadoCobranza", SqlDbType.VarChar)).Value = Data.EstadoCobranza;
                    Cmd.Parameters.Add(new SqlParameter("@CategoriaVentas", SqlDbType.VarChar)).Value = Data.CategoriaVentas;
                    Cmd.Parameters.Add(new SqlParameter("@CategoriaCobranzas", SqlDbType.VarChar)).Value = Data.CategoriaCobranzas;
                    Cmd.Parameters.Add(new SqlParameter("@UnidadNegocio", SqlDbType.VarChar)).Value = Data.UnidadNegocio;
                    Cmd.Parameters.Add(new SqlParameter("@TipoNegocio", SqlDbType.VarChar)).Value = Data.TipoNegocio;
                    Cmd.Parameters.Add(new SqlParameter("@CanalDistribucion", SqlDbType.VarChar)).Value = Data.CanalDistribucion;
                    Cmd.Parameters.Add(new SqlParameter("@IngresoMensual", SqlDbType.VarChar)).Value = Data.IngresoMensual;
                    Cmd.Parameters.Add(new SqlParameter("@TipoVenta", SqlDbType.VarChar)).Value = Data.TipoVenta;
                    Cmd.Parameters.Add(new SqlParameter("@FechaRegistro", SqlDbType.VarChar)).Value = Data.FechaRegistro;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDespacho", SqlDbType.VarChar)).Value = Data.TipoDespacho;
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@GestionCobranza", SqlDbType.VarChar)).Value = Data.GestionCobranza;
                    Cmd.Parameters.Add(new SqlParameter("@Puerto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Puerto,"");
                    Cmd.Parameters.Add(new SqlParameter("@ReqFactImpGuia", SqlDbType.VarChar)).Value = Data.ReqFactImpGuia;
                    Cmd.Parameters.Add(new SqlParameter("@AgenteRetencion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.AgenteRetencion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Provincia", SqlDbType.VarChar)).Value = Data.Provincia;
                    Cmd.Parameters.Add(new SqlParameter("@Reintegro", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Reintegro,"");
                    Cmd.Parameters.Add(new SqlParameter("@CuotaVenta", SqlDbType.VarChar)).Value = Data.CuotaVenta;
                    Cmd.Parameters.Add(new SqlParameter("@FlagTrigger", SqlDbType.VarChar)).Value = Data.FlagTrigger;
                    Cmd.Parameters.Add(new SqlParameter("@Motivo_Inactivar_Ruteo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Motivo_Inactivar_Ruteo,"");
                    Cmd.Parameters.Add(new SqlParameter("@Fecha_Inact_Ruteo", SqlDbType.VarChar)).Value = fnParmCmd.DatDBNull(Data.Fecha_Inact_Ruteo);
                    Cmd.Parameters.Add(new SqlParameter("@FlagVinculado", SqlDbType.VarChar)).Value = Data.FlagVinculado;
                    Cmd.Parameters.Add(new SqlParameter("@FlagTipoEmisionDoc", SqlDbType.VarChar)).Value = Data.FlagTipoEmisionDoc;
                    Cmd.Parameters.Add(new SqlParameter("@CompaniaAplicacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CompaniaAplicacion,"");
                    Cmd.Parameters.Add(new SqlParameter("@TipoCliente", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoCliente, "");
                    Cmd.Parameters.Add(new SqlParameter("@SituacionCli", SqlDbType.VarChar)).Value = Data.SituacionCli;
                    Cmd.Parameters.Add(new SqlParameter("@FlagVentaConfComp", SqlDbType.VarChar)).Value = Data.FlagVentaConfComp;
                    Cmd.Parameters.Add(new SqlParameter("@CorrelMobirut", SqlDbType.VarChar)).Value = fnParmCmd.intDBNull(Data.CorrelMobirut);
                    Cmd.Parameters.Add(new SqlParameter("@EncuestaMob", SqlDbType.VarChar)).Value = fnParmCmd.intDBNull(Data.EncuestaMob);
                    Cmd.Parameters.Add(new SqlParameter("@Latitud", SqlDbType.VarChar)).Value = Data.Latitud;
                    Cmd.Parameters.Add(new SqlParameter("@Longitud", SqlDbType.VarChar)).Value = Data.Longitud;
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

    }
}
