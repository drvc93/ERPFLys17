using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Maestro.RRHH
{
    public class datEmpleado
    {
        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqEmpleado;
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

        public static DataTable GetFormID(String Compania, Int32 Empleado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqEmpleado;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.Int)).Value = Empleado;

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
                Cmd.CommandText = fnQuery.tsqEmpleado;
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

        public static DataTable ListaSearch(String Compania, Int32 Empleado, String Nombre, String Documento, String DocumentoFiscal, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqEmpleado;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.Int)).Value = Empleado;
                Cmd.Parameters.Add(new SqlParameter("@NombreCompleto", SqlDbType.VarChar)).Value = Nombre;
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

        public static entErrores MantFormID(entEmpleado Data)
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
                    Cmd.CommandText = fnQuery.tsqDistrito;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Empleado", SqlDbType.Int)).Value = Data.Empleado;
                    Cmd.Parameters.Add(new SqlParameter("@TipoPersona", SqlDbType.VarChar)).Value = Data.TipoPersona;
                    Cmd.Parameters.Add(new SqlParameter("@ApellidosPaterno", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ApellidosPaterno, "");
                    Cmd.Parameters.Add(new SqlParameter("@ApellidosMaterno", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ApellidosMaterno,"");
                    Cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Nombres,"");
                    Cmd.Parameters.Add(new SqlParameter("@NombreCompleto", SqlDbType.VarChar)).Value = Data.NombreCompleto;
                    Cmd.Parameters.Add(new SqlParameter("@NombreBusqueda", SqlDbType.VarChar)).Value = Data.NombreBusqueda;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDocumentoPersona", SqlDbType.VarChar)).Value = Data.TipoDocumentoPersona;
                    Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = Data.Documento;
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoFiscal,"");
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoIdentidad", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoIdentidad,"");
                    Cmd.Parameters.Add(new SqlParameter("@CarnetExtranjeria", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CarnetExtranjeria,"");
                    Cmd.Parameters.Add(new SqlParameter("@Pasaporte", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Pasaporte, "");
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
                    Cmd.Parameters.Add(new SqlParameter("@MonedaCuenta", SqlDbType.VarChar)).Value =fnParmCmd.StrDBNull( Data.MonedaCuenta, "");
                    Cmd.Parameters.Add(new SqlParameter("@BancoCuenta", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.BancoCuenta, "");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroCuenta", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroCuenta, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoAnterior", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.CodigoAnterior);
                    Cmd.Parameters.Add(new SqlParameter("@CodigoUsuario", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoUsuario, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaUltimoIngreso", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaUltimoIngreso);
                    Cmd.Parameters.Add(new SqlParameter("@Raza", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Raza, "");
                    Cmd.Parameters.Add(new SqlParameter("@Religion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Religion, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoTrabajador", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoTrabajador, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoPension", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoPension, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaInicioPension", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaInicioPension);
                    Cmd.Parameters.Add(new SqlParameter("@FechaFinPension", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaFinPension);
                    Cmd.Parameters.Add(new SqlParameter("@CodigoAfp", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoAfp, "");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroAfp", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroAfp, "");
                    Cmd.Parameters.Add(new SqlParameter("@BancoCTS", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.BancoCTS, "");
                    Cmd.Parameters.Add(new SqlParameter("@MonedaCTS", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.MonedaCTS, "");
                    Cmd.Parameters.Add(new SqlParameter("@CuentaCTS", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CuentaCTS, "");
                    Cmd.Parameters.Add(new SqlParameter("@DepartamentoCiaCodigo", SqlDbType.VarChar)).Value = Data.DepartamentoCiaCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = Data.Cargo;
                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = Data.CentroCosto;
                    Cmd.Parameters.Add(new SqlParameter("@TipoContrato", SqlDbType.VarChar)).Value = Data.TipoContrato;
                    Cmd.Parameters.Add(new SqlParameter("@TipoPlanilla", SqlDbType.VarChar)).Value = Data.TipoPlanilla;
                    Cmd.Parameters.Add(new SqlParameter("@TipoHorario", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoHorario, "");
                    Cmd.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Celular, "");
                    Cmd.Parameters.Add(new SqlParameter("@RutaFoto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RutaFoto, "");
                    Cmd.Parameters.Add(new SqlParameter("@SituacionEmpleado", SqlDbType.VarChar)).Value = Data.SituacionEmpleado;
                    Cmd.Parameters.Add(new SqlParameter("@FechaUltimoCese", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaUltimoCese);
                    Cmd.Parameters.Add(new SqlParameter("@Postulante", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.Postulante);
                    Cmd.Parameters.Add(new SqlParameter("@Perfil", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.Perfil);
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@FechaRegistro", SqlDbType.DateTime)).Value = Data.FechaRegistro;
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioRegistro", SqlDbType.VarChar)).Value = Data.UsuarioRegistro;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoMilitarFA", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoMilitarFA, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoCarnetAsistencia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoCarnetAsistencia, "");
                    Cmd.Parameters.Add(new SqlParameter("@CarnetAsistencia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CarnetAsistencia, "");
                    Cmd.Parameters.Add(new SqlParameter("@ReferenciaDireccion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ReferenciaDireccion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Grupo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Grupo, "");
                    Cmd.Parameters.Add(new SqlParameter("@NivelEducativo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NivelEducativo, "");
                    Cmd.Parameters.Add(new SqlParameter("@Seguro", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Seguro, "");
                    Cmd.Parameters.Add(new SqlParameter("@CentroFormacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CentroFormacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagMadreRF", SqlDbType.VarChar)).Value = Data.FlagMadreRF;
                    Cmd.Parameters.Add(new SqlParameter("@FlagBeneficiarioCD", SqlDbType.VarChar)).Value = Data.FlagBeneficiarioCD;
                    Cmd.Parameters.Add(new SqlParameter("@FotoCheck", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.FotoCheck, "");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioEvaluacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioEvaluacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagEsSaludVida", SqlDbType.VarChar)).Value = Data.FlagEsSaludVida;
                    Cmd.Parameters.Add(new SqlParameter("@CodigoVia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoVia, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoZona", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoZona, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagPensionista", SqlDbType.VarChar)).Value = Data.FlagPensionista;
                    Cmd.Parameters.Add(new SqlParameter("@Ocupacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Ocupacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@RegimenPensionario", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RegimenPensionario, "");
                    Cmd.Parameters.Add(new SqlParameter("@SctrSalud", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.SctrSalud, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoModalidadFormativa", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoModalidadFormativa, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodEstablecimiento", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodEstablecimiento, "");
                    Cmd.Parameters.Add(new SqlParameter("@CategoriaEsp", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CategoriaEsp, "");
                    Cmd.Parameters.Add(new SqlParameter("@ObsCts", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObsCts, "");
                    Cmd.Parameters.Add(new SqlParameter("@ComisionVarMixta", SqlDbType.VarChar)).Value = Data.ComisionVarMixta;
                    Cmd.Parameters.Add(new SqlParameter("@FlagOtroCuentaBanco", SqlDbType.VarChar)).Value = Data.FlagOtroCuentaBanco;
                    Cmd.Parameters.Add(new SqlParameter("@AudEstacion", SqlDbType.VarChar)).Value = Data.EstacionSys;
                    Cmd.Parameters.Add(new SqlParameter("@AudFechaEst", SqlDbType.DateTime)).Value = Data.FechaSys;
                    Cmd.ExecuteNonQuery();                    

                    Trs.Commit();
                    entErr.Resultado = true;
                }catch (Exception ex){
                    Trs.Rollback();
                    sMsj = ex.Message;
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = sMsj });
                }finally{
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
