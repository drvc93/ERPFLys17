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
    public class datPersona
    {
        public static DataTable ListaFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqPersona;
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

        public static DataTable GetFormID(String Compania, Int32 Persona)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqPersona;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = Persona;

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
                Cmd.CommandText = fnQuery.tsqPersona;
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

        public static DataTable ListaSearch(String Compania, Int32 Persona, String NombreCompleto, String DocumentoIdentidad, String DocumentoFiscal, String Estado,
                                            String EsEmpleado, String EsProveedor, String EsCliente)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqPersona;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = Persona;
                Cmd.Parameters.Add(new SqlParameter("@NombreCompleto", SqlDbType.VarChar)).Value = NombreCompleto;
                Cmd.Parameters.Add(new SqlParameter("@DocumentoIdentidad", SqlDbType.VarChar)).Value = DocumentoIdentidad;
                Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = DocumentoFiscal;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
                Cmd.Parameters.Add(new SqlParameter("@EsEmpleado", SqlDbType.VarChar)).Value = EsEmpleado;
                Cmd.Parameters.Add(new SqlParameter("@EsProveedor", SqlDbType.VarChar)).Value = EsProveedor;
                Cmd.Parameters.Add(new SqlParameter("@EsCliente", SqlDbType.VarChar)).Value = EsCliente;
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

        public static entErrores MantFormID(entPersona Data)
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
                    Cmd.CommandText = fnQuery.tsqPersona;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = Data.Persona;
                    Cmd.Parameters.Add(new SqlParameter("@TipoPersona", SqlDbType.VarChar)).Value = Data.TipoPersona;
                    Cmd.Parameters.Add(new SqlParameter("@ApellidosPaterno", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ApellidosPaterno,"");
                    Cmd.Parameters.Add(new SqlParameter("@ApellidosMaterno", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ApellidosMaterno,"");
                    Cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Nombres,"");
                    Cmd.Parameters.Add(new SqlParameter("@NombreCompleto", SqlDbType.VarChar)).Value = Data.NombreCompleto;
                    Cmd.Parameters.Add(new SqlParameter("@NombreBusqueda", SqlDbType.VarChar)).Value = Data.NombreBusqueda;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDocumentoPersona", SqlDbType.VarChar)).Value = Data.TipoDocumentoPersona;
                    Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Documento,"");
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoFiscal,"");
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoIdentidad", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoIdentidad,"");
                    Cmd.Parameters.Add(new SqlParameter("@CarnetExtranjeria", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CarnetExtranjeria, "");
                    Cmd.Parameters.Add(new SqlParameter("@Pasaporte", SqlDbType.VarChar)).Value = Data.Pasaporte;
                    Cmd.Parameters.Add(new SqlParameter("@Procedencia", SqlDbType.VarChar)).Value = Data.Procedencia;
                    Cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar)).Value = Data.Direccion;
                    Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = Data.Pais;
                    Cmd.Parameters.Add(new SqlParameter("@DepartamentoCodigo", SqlDbType.VarChar)).Value = Data.DepartamentoCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@ProvinciaCodigo", SqlDbType.VarChar)).Value = Data.ProvinciaCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@DistritoCodigo", SqlDbType.VarChar)).Value = Data.DistritoCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Mail", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Mail, "");
                    Cmd.Parameters.Add(new SqlParameter("@Nacionalidad", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Nacionalidad, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaNacimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Educacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Educacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Sexo, "");
                    Cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Telefono, "");
                    Cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Fax, "");
                    Cmd.Parameters.Add(new SqlParameter("@EstadoCivil", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.EstadoCivil, "");
                    Cmd.Parameters.Add(new SqlParameter("@NombreEmergencia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NombreEmergencia, "");
                    Cmd.Parameters.Add(new SqlParameter("@TelefonoEmergencia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TelefonoEmergencia, "");
                    Cmd.Parameters.Add(new SqlParameter("@DireccionEmergencia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DireccionEmergencia, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoCuenta", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoCuenta, "");
                    Cmd.Parameters.Add(new SqlParameter("@MonedaCuenta", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.MonedaCuenta, "");
                    Cmd.Parameters.Add(new SqlParameter("@BancoCuenta", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.BancoCuenta, "");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroCuenta", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroCuenta, "");
                    Cmd.Parameters.Add(new SqlParameter("@EsEmpleado", SqlDbType.VarChar)).Value = Data.EsEmpleado;
                    Cmd.Parameters.Add(new SqlParameter("@EsProveedor", SqlDbType.VarChar)).Value = Data.EsProveedor;
                    Cmd.Parameters.Add(new SqlParameter("@EsCliente", SqlDbType.VarChar)).Value = Data.EsCliente;
                    Cmd.Parameters.Add(new SqlParameter("@EsOtro", SqlDbType.VarChar)).Value = Data.EsOtro;
                    Cmd.Parameters.Add(new SqlParameter("@PersonaAnterior", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.PersonaAnterior);
                    Cmd.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoUsuario, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoPersonaUsuario", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoPersonaUsuario, "");
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@FechaRegistro", SqlDbType.DateTime)).Value = Data.FechaRegistro;
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioRegistro", SqlDbType.VarChar)).Value = Data.UsuarioRegistro;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@UltimaFechaModificacion", SqlDbType.DateTime)).Value = Data.UltimaFechaModificacion;
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoMilitarFA", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoMilitarFA, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoVia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoVia, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoZona", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoZona, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagAgenteRet", SqlDbType.VarChar)).Value = Data.FlagAgenteRet;
                    Cmd.Parameters.Add(new SqlParameter("@FlagBuenContrib", SqlDbType.VarChar)).Value = Data.FlagBuenContrib;
                    Cmd.Parameters.Add(new SqlParameter("@FlagAgentePer", SqlDbType.VarChar)).Value = Data.FlagAgentePer;
                    Cmd.Parameters.Add(new SqlParameter("@FlagValidoRet", SqlDbType.VarChar)).Value = Data.FlagValidoRet;
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioValidoRet", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioValidoRet, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaValidoRet", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaValidoRet);
                    Cmd.Parameters.Add(new SqlParameter("@FlagTipoAmpRet", SqlDbType.VarChar)).Value = Data.FlagTipoAmpRet;
                    Cmd.Parameters.Add(new SqlParameter("@FlagNoHabido", SqlDbType.VarChar)).Value = Data.FlagNoHabido;
                    Cmd.Parameters.Add(new SqlParameter("@FlagNoHallado", SqlDbType.VarChar)).Value = Data.FlagNoHallado;
                    Cmd.Parameters.Add(new SqlParameter("@FechaNoHabido", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaNoHabido);
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioActNoHabido", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioActNoHabido, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaActNoHabido", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaActNoHabido);
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioActNoHallado", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioActNoHallado, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaActNoHallado", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaActNoHallado);
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
