using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Repository.Objeto;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using System.Transactions;

namespace FiltroLys.Repository.Contabilidad
{
    public class datVoucherDet{

        public static DataTable GetFormID(String Compania, String Periodo, String TipoVoucher, String NumeroVoucher)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqVoucherDet;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = TipoVoucher;
                Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = NumeroVoucher;

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

        public static DataTable LstSaldoCuenta(String Compania, String Periodo, String Cuenta)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqVoucherDet;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "RESCTA";
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

        public static entErrores MantFormID(entVoucherDet Data)
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
                    Cmd.CommandText = fnQuery.tsqVoucherDet;
                    
                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@Linea", SqlDbType.Int)).Value = Data.Linea;
                    Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = Data.Cuenta;
                    Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.Persona,0);
                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CentroCosto,"");
                    Cmd.Parameters.Add(new SqlParameter("@FlujoCaja", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.FlujoCaja,"");
                    Cmd.Parameters.Add(new SqlParameter("@OrigenDoc", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.OrigenDoc,String.Empty);
                    Cmd.Parameters.Add(new SqlParameter("@CodigoDoc", SqlDbType.Int)).Value = fnParmCmd.DecDBNull(Data.CodigoDoc,0);
                    Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Documento);
                    Cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.Fecha);
                    Cmd.Parameters.Add(new SqlParameter("@Proyecto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Proyecto,"");
                    Cmd.Parameters.Add(new SqlParameter("@OrdenCompra", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.OrdenCompra,"");
                    Cmd.Parameters.Add(new SqlParameter("@Secuencia_OC", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.Secuencia_OC,0);
                    Cmd.Parameters.Add(new SqlParameter("@MontoLocal", SqlDbType.Decimal)).Value = Data.MontoLocal;
                    Cmd.Parameters.Add(new SqlParameter("@MontoExt", SqlDbType.Decimal)).Value = Data.MontoExt;
                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Descripcion);
                    Cmd.Parameters.Add(new SqlParameter("@FlagAutomatico", SqlDbType.VarChar)).Value = Data.FlagAutomatico;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuarioMod", SqlDbType.VarChar)).Value = Data.UltimoUsuarioMod;
                    Cmd.Parameters.Add(new SqlParameter("@UltimaFechaMod", SqlDbType.DateTime)).Value = Data.UltimaFechaMod;
                    Cmd.Parameters.Add(new SqlParameter("@CodMaquina", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodMaquina,"");
                    Cmd.Parameters.Add(new SqlParameter("@GrupoCC", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.GrupoCC,"");
                    Cmd.Parameters.Add(new SqlParameter("@ClasificacionGCC", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ClasificacionGCC,"");
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
