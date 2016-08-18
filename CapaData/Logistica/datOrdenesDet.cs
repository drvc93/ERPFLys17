using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Query.Logistica;
using FiltroLys.Model.Logistica;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Logistica
{
    public class datOrdenesDet
    {
        public static DataTable ListaFormID(String Compania, String NumeroOrden)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqOrdenesCompraDet;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstMaestra;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@NumeroOrden", SqlDbType.VarChar)).Value = NumeroOrden;

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

        public static DataTable GetFormID(String Compania, String @NumeroOrden, Int32 Ampliacion)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqOrdenesCompraDet;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@NumeroOrden", SqlDbType.VarChar)).Value = @NumeroOrden;
                Cmd.Parameters.Add(new SqlParameter("@Ampliacion", SqlDbType.Int)).Value = @Ampliacion;

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

        public static DataTable ListaToVoucher(String Compania, String @NumeroOrden, Int32 Ampliacion)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqOrdenesCompraDet;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "LSTTOVOUC";
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@NumeroOrden", SqlDbType.VarChar)).Value = @NumeroOrden;
                Cmd.Parameters.Add(new SqlParameter("@Ampliacion", SqlDbType.Int)).Value = @Ampliacion;
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

        public static entErrores MantFormID(entOrdenesDet Data)
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
                    Cmd.CommandText = fnQuery.tsqOrdenesCompraDet;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroOrden", SqlDbType.VarChar)).Value = Data.NumeroOrden;
                    Cmd.Parameters.Add(new SqlParameter("@Ampliacion", SqlDbType.Int)).Value = Data.Ampliacion;
                    Cmd.Parameters.Add(new SqlParameter("@Secuencia", SqlDbType.Int)).Value = Data.Secuencia;
                    Cmd.Parameters.Add(new SqlParameter("@Item", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Item,"");
                    Cmd.Parameters.Add(new SqlParameter("@CommodityCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CommodityCodigo, "");
                    Cmd.Parameters.Add(new SqlParameter("@UnidadCodigo", SqlDbType.VarChar)).Value = Data.UnidadCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                    Cmd.Parameters.Add(new SqlParameter("@OtrosDatos", SqlDbType.VarChar)).Value = Data.OtrosDatos;
                    Cmd.Parameters.Add(new SqlParameter("@CantidadPedida", SqlDbType.Decimal)).Value = Data.CantidadPedida;
                    Cmd.Parameters.Add(new SqlParameter("@CantidadRecibida", SqlDbType.Decimal)).Value = Data.CantidadRecibida;
                    Cmd.Parameters.Add(new SqlParameter("@PrecioUnitario", SqlDbType.Decimal)).Value = Data.PrecioUnitario;
                    Cmd.Parameters.Add(new SqlParameter("@FechaEntrega", SqlDbType.DateTime)).Value = Data.FechaEntrega;
                    Cmd.Parameters.Add(new SqlParameter("@FechaEntregaReal", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaEntregaReal);
                    Cmd.Parameters.Add(new SqlParameter("@Terminado", SqlDbType.VarChar)).Value = Data.Terminado;
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = Data.CentroCosto;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UltimoUsuario;
                    Cmd.Parameters.Add(new SqlParameter("@UltimaFechaModificacion", SqlDbType.DateTime)).Value = Data.UltimaFechaModificacion;
                    Cmd.Parameters.Add(new SqlParameter("@PartidaCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.PartidaCodigo,"");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioAprobacionDesv", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioAprobacionDesv,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaAprobacionDesv", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaAprobacionDesv);
                    Cmd.Parameters.Add(new SqlParameter("@PermisoDesviacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.PermisoDesviacion,"");
                    Cmd.Parameters.Add(new SqlParameter("@PermisoAprobado", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.PermisoAprobado,"");
                    Cmd.Parameters.Add(new SqlParameter("@ObservacionesPermiso", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObservacionesPermiso,"");
                    Cmd.Parameters.Add(new SqlParameter("@ObservacionesAprobacionP", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObservacionesAprobacionP,"");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioPermiso", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioPermiso, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagCambioPrecio", SqlDbType.VarChar)).Value = Data.FlagCambioPrecio;
                    Cmd.Parameters.Add(new SqlParameter("@PrecioAnterior", SqlDbType.Decimal)).Value = fnParmCmd.DecDBNull(Data.PrecioAnterior,0);
                    Cmd.Parameters.Add(new SqlParameter("@MotivoCambio", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.MotivoCambio,"");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioCambio", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioCambio,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaModificacion", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaModificacion);
                    Cmd.Parameters.Add(new SqlParameter("@Embarque", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.Embarque);
                    Cmd.Parameters.Add(new SqlParameter("@FlagSaldoNoPendiente", SqlDbType.VarChar)).Value = Data.FlagSaldoNoPendiente;
                    Cmd.Parameters.Add(new SqlParameter("@ObsSaldoNoPendiente", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObsSaldoNoPendiente,"");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioSaldoNoPendiente", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioSaldoNoPendiente,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaSaldoNoPendiente", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaSaldoNoPendiente);
                    Cmd.Parameters.Add(new SqlParameter("@PrecioImp_Ant", SqlDbType.Decimal)).Value = Data.PrecioImp_Ant;
                    Cmd.Parameters.Add(new SqlParameter("@Procedencia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Procedencia, "");
                    Cmd.Parameters.Add(new SqlParameter("@Garantias", SqlDbType.VarChar)).Value =fnParmCmd.StrDBNull( Data.Garantias,"");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioCierre", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioCierre,"");
                    Cmd.Parameters.Add(new SqlParameter("@TipoCierre", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoCierre,"");
                    Cmd.Parameters.Add(new SqlParameter("@MotivoCierre", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.MotivoCierre,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaCierre", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaCierre);
                    Cmd.Parameters.Add(new SqlParameter("@Muestra", SqlDbType.VarChar)).Value = Data.Muestra;
                    Cmd.Parameters.Add(new SqlParameter("@LoteMuestra", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.LoteMuestra, "");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioSaldoNP_Rev", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioSaldoNP_Rev,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaSaldoNP_Rev", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaSaldoNP_Rev);
                    Cmd.Parameters.Add(new SqlParameter("@ObsSaldoNP_Rev", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObsSaldoNP_Rev,"");
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
