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
    public class datParametro
    {
        public static DataTable ListaFormID(String Aplicacion)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqParametro;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstMaestra;
                Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar)).Value = Aplicacion;

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

        public static DataTable GetFormID(String Compania, String Aplicacion, String Parametro)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqParametro;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar)).Value = Aplicacion;
                Cmd.Parameters.Add(new SqlParameter("@Parametro", SqlDbType.VarChar)).Value = Parametro;
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

        public static DataTable ListaCombo(String Compania, String Aplicacion, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqParametro;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstCombo;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar)).Value = Aplicacion;
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

        public static DataTable ListaSearch(String Compania, String Aplicacion, String Parametro, String Descripcion, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqParametro;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar)).Value = Aplicacion;
                Cmd.Parameters.Add(new SqlParameter("@Parametro", SqlDbType.VarChar)).Value = Parametro;
                Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Descripcion;
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

        public static entErrores MantFormID(entParametro Data)
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
                    Cmd.CommandText = fnQuery.tsqParametro;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar)).Value = Data.Aplicacion;
                    Cmd.Parameters.Add(new SqlParameter("@Parametro", SqlDbType.VarChar)).Value = Data.ParametroCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                    Cmd.Parameters.Add(new SqlParameter("@Explicacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Explicacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.VarChar)).Value = Data.Tipo;
                    Cmd.Parameters.Add(new SqlParameter("@Texto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Texto, "");
                    Cmd.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int)).Value = fnParmCmd.DecDBNull(Data.Numero);
                    Cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.Fecha);
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@Texto2", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Texto2, "");
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