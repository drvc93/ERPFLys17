using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Maestro.Contabilidad
{
    public class datCorrelativoVoucher
    {
        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCorrVoucher;
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

        public static DataTable GetFormID(String Compania, Int32 Anual, String TipoVoucher)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCorrVoucher;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Anual", SqlDbType.Int)).Value = Anual;
                Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = TipoVoucher;

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

        public static DataTable ListaCombo(String Compania, Int32 Anual)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCorrVoucher;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstCombo;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Anual", SqlDbType.Int)).Value = Anual;
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

        public static DataTable ListaSearch(String Compania, Int32 Anual, String TipoVoucher)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCorrVoucher;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Anual", SqlDbType.Int)).Value = Anual;
                Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = TipoVoucher;
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

        public static entErrores MantFormID(entCorrelativoVoucher Data)
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
                    Cmd.CommandText = fnQuery.tsqCorrVoucher;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Anual", SqlDbType.Int)).Value = Data.Anio;
                    Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@Mes00", SqlDbType.Int)).Value = Data.Mes00;
                    Cmd.Parameters.Add(new SqlParameter("@Mes01", SqlDbType.Int)).Value = Data.Mes01;
                    Cmd.Parameters.Add(new SqlParameter("@Mes02", SqlDbType.Int)).Value = Data.Mes02;
                    Cmd.Parameters.Add(new SqlParameter("@Mes03", SqlDbType.Int)).Value = Data.Mes03;
                    Cmd.Parameters.Add(new SqlParameter("@Mes04", SqlDbType.Int)).Value = Data.Mes04;
                    Cmd.Parameters.Add(new SqlParameter("@Mes05", SqlDbType.Int)).Value = Data.Mes05;
                    Cmd.Parameters.Add(new SqlParameter("@Mes06", SqlDbType.Int)).Value = Data.Mes06;
                    Cmd.Parameters.Add(new SqlParameter("@Mes07", SqlDbType.Int)).Value = Data.Mes07;
                    Cmd.Parameters.Add(new SqlParameter("@Mes08", SqlDbType.Int)).Value = Data.Mes08;
                    Cmd.Parameters.Add(new SqlParameter("@Mes09", SqlDbType.Int)).Value = Data.Mes09;
                    Cmd.Parameters.Add(new SqlParameter("@Mes10", SqlDbType.Int)).Value = Data.Mes10;
                    Cmd.Parameters.Add(new SqlParameter("@Mes11", SqlDbType.Int)).Value = Data.Mes11;
                    Cmd.Parameters.Add(new SqlParameter("@Mes12", SqlDbType.Int)).Value = Data.Mes12;
                    Cmd.Parameters.Add(new SqlParameter("@Mes13", SqlDbType.Int)).Value = Data.Mes13;
                    Cmd.Parameters.Add(new SqlParameter("@Mes14", SqlDbType.Int)).Value = Data.Mes14;
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

        public static Int32 GetUltimoCorrelativo(String Compania, String Periodo, String TipoVoucher)
        {
            Int32 nCorrelativo = 0;
            SqlCommand Cmd = new SqlCommand();
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCorrVoucherGet;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar)).Value = TipoVoucher;
                Cmd.Parameters.Add(new SqlParameter("@Correlativo", SqlDbType.Int));
                Cmd.Parameters["@Correlativo"].Direction = ParameterDirection.Output;

                SqlDataReader dr = null;
                dr = Cmd.ExecuteReader();
                nCorrelativo = Convert.ToInt32(Cmd.Parameters["@Correlativo"].Value);
                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return nCorrelativo;
        }

        public static entErrores SetUltimoCorrelativo(entCorrelativoVoucher oEnt)
        {
            SqlCommand Cmd = new SqlCommand();           
            entErrores entErr = new entErrores();
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
                    Cmd.CommandText = fnQuery.tsqCorrVoucherSet;

                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = oEnt.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = oEnt.Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar)).Value = oEnt.TipoVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@Correlativo", SqlDbType.Int)).Value = oEnt.Correlativo;
                    Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = oEnt.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar,50)).Value = "";
                    Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.Output;

                    Cmd.ExecuteNonQuery();
                    if (!Cmd.Parameters["@Mensaje"].Value.ToString().Equals("OK"))
                    {
                        entErr.Errores.Add(new entFail() { Codigo = "ER", Descripcion = Cmd.Parameters["@Mensaje"].Value.ToString() });
                        Trs.Rollback();
                    }
                    else
                    {
                        Trs.Commit();
                        entErr.Resultado = true;
                    }
                }
                catch (Exception ex)
                {
                    Trs.Rollback();
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = ex.Message });
                }
                finally
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return entErr;
        }

    }
}