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
    public class datProveedor
    {
        public static DataTable ListaFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqProveedor;
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

        public static DataTable GetFormID(String Compania, Int32 Proveedor)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqProveedor;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Proveedor", SqlDbType.Int)).Value = Proveedor;

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
                Cmd.CommandText = fnQuery.tsqProveedor;
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

        public static DataTable ListaSearch(String Compania, Int32 Proveedor, String RazonSocial, String DocumentoFiscal, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqProveedor;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Proveedor", SqlDbType.Int)).Value = Proveedor;
                Cmd.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.VarChar)).Value = RazonSocial;                
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

        public static entErrores MantFormID(entProveedor Data)
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
                    Cmd.CommandText = fnQuery.tsqProveedor;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Proveedor", SqlDbType.Int)).Value = Data.Proveedor;
                    Cmd.Parameters.Add(new SqlParameter("@TipoPersona", SqlDbType.VarChar)).Value = Data.TipoPersona;
                    Cmd.Parameters.Add(new SqlParameter("@ApellidosPaterno", SqlDbType.VarChar)).Value = Data.ApellidosPaterno;
                    Cmd.Parameters.Add(new SqlParameter("@ApellidosMaterno", SqlDbType.VarChar)).Value = Data.ApellidosMaterno;
                    Cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar)).Value = Data.Nombres;
                    Cmd.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.VarChar)).Value = Data.RazonSocial;
                    Cmd.Parameters.Add(new SqlParameter("@NombreBusqueda", SqlDbType.VarChar)).Value = Data.NombreBusqueda;
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoFiscal,"");
                    Cmd.Parameters.Add(new SqlParameter("@Mail", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Mail,"");
                    Cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar)).Value = Data.Direccion;
                    Cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaNacimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = Data.Pais;
                    Cmd.Parameters.Add(new SqlParameter("@DepartamentoCodigo", SqlDbType.VarChar)).Value = Data.DepartamentoCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@ProvinciaCodigo", SqlDbType.VarChar)).Value = Data.ProvinciaCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@DistritoCodigo", SqlDbType.VarChar)).Value = Data.DistritoCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@ModalidadCodigo", SqlDbType.VarChar)).Value = Data.ModalidadCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@TipoEmpresa", SqlDbType.VarChar)).Value = Data.TipoEmpresa;
                    Cmd.Parameters.Add(new SqlParameter("@RepresentanteLegal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RepresentanteLegal,"");
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoRepresentante", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoRepresentante,"");
                    Cmd.Parameters.Add(new SqlParameter("@Contacto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Contacto,"");
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoContacto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoContacto,"");
                    Cmd.Parameters.Add(new SqlParameter("@Observaciones", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Observaciones, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaInscripcion", SqlDbType.DateTime)).Value = Data.FechaInscripcion;
                    Cmd.Parameters.Add(new SqlParameter("@Carta", SqlDbType.VarChar)).Value = Data.Carta;
                    Cmd.Parameters.Add(new SqlParameter("@FichaInscripcion", SqlDbType.VarChar)).Value = Data.FichaInscripcion;
                    Cmd.Parameters.Add(new SqlParameter("@LicenciaFuncionamiento", SqlDbType.VarChar)).Value = Data.LicenciaFuncionamiento;
                    Cmd.Parameters.Add(new SqlParameter("@FormularioRuc", SqlDbType.VarChar)).Value = Data.FormularioRuc;
                    Cmd.Parameters.Add(new SqlParameter("@UltimaVisita", SqlDbType.Int)).Value = Data.UltimaVisita;
                    Cmd.Parameters.Add(new SqlParameter("@Categoria", SqlDbType.VarChar)).Value = Data.Categoria;
                    Cmd.Parameters.Add(new SqlParameter("@Critico", SqlDbType.VarChar)).Value = Data.Critico;
                    Cmd.Parameters.Add(new SqlParameter("@MotivoInactivacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.MotivoInactivacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@LineaComercializacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.LineaComercializacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Procedencia", SqlDbType.VarChar)).Value = Data.Procedencia;
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@UltimaFechaModificacion", SqlDbType.DateTime)).Value = Data.UltimaFechaModificacion;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar)).Value = Data.TipoDocumento;
                    Cmd.Parameters.Add(new SqlParameter("@Impuesto", SqlDbType.VarChar)).Value = Data.Impuesto;
                    Cmd.Parameters.Add(new SqlParameter("@FechaInicioVigencia", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaInicioVigencia);
                    Cmd.Parameters.Add(new SqlParameter("@FechaFinVigencia", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaFinVigencia);
                    Cmd.Parameters.Add(new SqlParameter("@MonedaPago", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.MonedaPago, "");
                    Cmd.Parameters.Add(new SqlParameter("@CriticoServicio", SqlDbType.VarChar)).Value = Data.CriticoServicio;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDocumentoOB", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoDocumentoOB, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagTrigger", SqlDbType.VarChar)).Value = Data.FlagTrigger;
                    Cmd.Parameters.Add(new SqlParameter("@Agente", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Agente, "");
                    Cmd.Parameters.Add(new SqlParameter("@FactorReposicion", SqlDbType.Decimal)).Value = Data.FactorReposicion;
                    Cmd.Parameters.Add(new SqlParameter("@CuentaDetraccion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CuentaDetraccion, "");
                    Cmd.Parameters.Add(new SqlParameter("@PorcentajeAbono", SqlDbType.Decimal)).Value = fnParmCmd.DecDBNull(Data.PorcentajeAbono);
                    Cmd.Parameters.Add(new SqlParameter("@PorcentajeGanancia", SqlDbType.Decimal)).Value = fnParmCmd.DecDBNull(Data.PorcentajeGanancia);
                    Cmd.Parameters.Add(new SqlParameter("@Unico", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Unico,"");
                    Cmd.Parameters.Add(new SqlParameter("@CriticoFinanzas", SqlDbType.VarChar)).Value = Data.CriticoFinanzas;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDoc_Sunat", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoDoc_Sunat, "");
                    Cmd.Parameters.Add(new SqlParameter("@DiasPrevioEmbarque", SqlDbType.Int)).Value = Data.DiasPrevioEmbarque;
                    Cmd.Parameters.Add(new SqlParameter("@ProveedorLogistico", SqlDbType.VarChar)).Value = Data.ProveedorLogistico;
                    Cmd.Parameters.Add(new SqlParameter("@ProveedorLogisticoServicio", SqlDbType.VarChar)).Value = Data.ProveedorLogisticoServicio;
                    Cmd.Parameters.Add(new SqlParameter("@IncotermCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.IncotermCodigo, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoPension", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoPension, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoAfp", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoAfp, "");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroAfp", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroAfp, "");
                    Cmd.Parameters.Add(new SqlParameter("@RutaDni", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RutaDni, "");
                    Cmd.Parameters.Add(new SqlParameter("@AfpVariableMixta", SqlDbType.VarChar)).Value = Data.AfpVariableMixta;
                    Cmd.Parameters.Add(new SqlParameter("@FechaIngresoPension", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaIngresoPension);
                    Cmd.Parameters.Add(new SqlParameter("@NumeroDni", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroDni, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagAgenteRet", SqlDbType.VarChar)).Value = Data.FlagAgenteRet;
                    Cmd.Parameters.Add(new SqlParameter("@FlagBuenContrib", SqlDbType.VarChar)).Value = Data.FlagBuenContrib;
                    Cmd.Parameters.Add(new SqlParameter("@FlagAgentePer", SqlDbType.VarChar)).Value = Data.FlagAgentePer;
                    Cmd.Parameters.Add(new SqlParameter("@FlagValidoRet", SqlDbType.VarChar)).Value = Data.FlagValidoRet;
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioValidoRet", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioValidoRet,"");
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
