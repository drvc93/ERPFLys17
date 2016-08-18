using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Contabilidad;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Contabilidad
{
    public class datCierreMesCuenta{

        public static DataTable ListaFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCierreMensualCB;
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

        public static DataTable GetFormID(String Compania,String Periodo, String Cuenta)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCierreMensualCB;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = Cuenta;

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

        public static entErrores MantFormID(entCierreMesCuenta Data)
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
                    Cmd.CommandText = fnQuery.tsqCierreMensualCB;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = Data.Cuenta;
                    Cmd.Parameters.Add(new SqlParameter("@SaldoInicialLocal", SqlDbType.Decimal)).Value = Data.SaldoInicialLocal;
                    Cmd.Parameters.Add(new SqlParameter("@SaldoInicialExt", SqlDbType.Decimal)).Value = Data.SaldoInicialExt;
                    Cmd.Parameters.Add(new SqlParameter("@MovimientoLocal", SqlDbType.Decimal)).Value = Data.MovimientoLocal;
                    Cmd.Parameters.Add(new SqlParameter("@MovimientoExt", SqlDbType.Decimal)).Value = Data.MovimientoExt;
                    Cmd.Parameters.Add(new SqlParameter("@SaldoFinalLocal", SqlDbType.Decimal)).Value = Data.SaldoFinalLocal;
                    Cmd.Parameters.Add(new SqlParameter("@SaldoFinalExt", SqlDbType.Decimal)).Value = Data.SaldoFinalExt;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
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

        public static DataTable ListSaldoToMayor(String Compania, String Periodo)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqSaldoContableMay;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@c_compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@c_periodo", SqlDbType.VarChar)).Value = Periodo;
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

        public static DataTable ListSaldoToCuenta(String Compania, String Periodo, String Mayor)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqSaldoContableCta;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@c_compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@c_periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@c_mayor", SqlDbType.VarChar)).Value = Mayor;
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

        public static DataTable GetRevisionMensual(String Compania, String Periodo, String Operacion)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCierreMensualRevision;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Operacion", SqlDbType.VarChar)).Value = Operacion;
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

        public static String SetProcesoMensual(String Compania, String Periodo, String Usuario)
        {
            String sResult = "";
            SqlCommand Cmd = new SqlCommand();            

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandText = fnQuery.tsqCierreMensualProcesar;
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Usuario;
                    sResult = (String)Cmd.ExecuteScalar();
                    Trs.Commit();
                    if (!sResult.Equals("OK")){
                        Trs.Rollback();
                    }
                }catch (Exception ex){
                    Trs.Rollback();
                    sResult = "[" + ex.GetHashCode().ToString() + "] - " + ex.Message;
                }
                finally {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return sResult;
        }

        public static String GetPeriodoSiguiente(String Periodo)
        {
            String sPeriodoSig = "";
            SqlCommand Cmd = new SqlCommand();
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = fnQuery.tsqPeriodoSiguienteCB;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@PeriodoSig", SqlDbType.VarChar,6)).Value = "";
                Cmd.Parameters["@PeriodoSig"].Direction = ParameterDirection.Output;
                Cmd.ExecuteNonQuery();
                sPeriodoSig = (String) Cmd.Parameters["@PeriodoSig"].Value;

                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
                Cmd = null;
            }
            return sPeriodoSig;
        }

    }
}
