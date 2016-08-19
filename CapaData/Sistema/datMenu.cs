using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Model.Sistema;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Sistema
{
    public class datMenu{

        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqMenuSys;
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

        public static DataTable GetFormID(String AplicacionCodigo, Int32 Nivel1, Int32 Nivel2, Int32 Nivel3, Int32 Nivel4, Int32 Nivel5)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqMenuSys;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar)).Value = AplicacionCodigo;
                Cmd.Parameters.Add(new SqlParameter("@Nivel1", SqlDbType.Int)).Value = Nivel1;
                Cmd.Parameters.Add(new SqlParameter("@Nivel2", SqlDbType.Int)).Value = Nivel2;
                Cmd.Parameters.Add(new SqlParameter("@Nivel3", SqlDbType.Int)).Value = Nivel3;
                Cmd.Parameters.Add(new SqlParameter("@Nivel4", SqlDbType.Int)).Value = Nivel4;
                Cmd.Parameters.Add(new SqlParameter("@Nivel5", SqlDbType.Int)).Value = Nivel5;

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
        
        public static entErrores MantFormID(entMenu Data)
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
                    Cmd.CommandText = fnQuery.tsqMenuSys;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar)).Value = Data.AplicacionCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Nivel1", SqlDbType.Int)).Value = Data.Nivel1;
                    Cmd.Parameters.Add(new SqlParameter("@Nivel2", SqlDbType.Int)).Value = Data.Nivel2;
                    Cmd.Parameters.Add(new SqlParameter("@Nivel3", SqlDbType.Int)).Value = Data.Nivel3;
                    Cmd.Parameters.Add(new SqlParameter("@Nivel4", SqlDbType.Int)).Value = Data.Nivel4;
                    Cmd.Parameters.Add(new SqlParameter("@Nivel5", SqlDbType.Int)).Value = Data.Nivel5;
                    Cmd.Parameters.Add(new SqlParameter("@NombreMenu", SqlDbType.VarChar)).Value = Data.NombreMenu;
                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                    Cmd.Parameters.Add(new SqlParameter("@ObjetoPrincipal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObjetoPrincipal, "");
                    Cmd.Parameters.Add(new SqlParameter("@ObjetoLlamado", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObjetosLlamados, "");
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
        
    }
}
