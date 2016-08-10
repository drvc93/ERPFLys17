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
    public class datCargo
    {
        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCargo;
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

        public static DataTable GetFormID(String Compania, String Cargo)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCargo;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = Cargo;

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
                Cmd.CommandText = fnQuery.tsqCargo;
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

        public static DataTable ListaSearch(String Compania, String Cargo, String Descripcion, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCargo;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = Cargo;
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

        public static entErrores MantFormID(entCargo Data)
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
                    Cmd.CommandText = fnQuery.tsqCargo;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Cargo", SqlDbType.VarChar)).Value = Data.Cargo;
                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@Grupo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Grupo,"");
                    Cmd.Parameters.Add(new SqlParameter("@Organo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Organo,"");
                    Cmd.Parameters.Add(new SqlParameter("@Educacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Educacion,"");
                    Cmd.Parameters.Add(new SqlParameter("@NivelSupervision", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NivelSupervision,"");
                    Cmd.Parameters.Add(new SqlParameter("@Experiencia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Experiencia,"");
                    Cmd.Parameters.Add(new SqlParameter("@ObjetivoCargo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObjetivoCargo, "");
                    Cmd.Parameters.Add(new SqlParameter("@EdadMaxima", SqlDbType.VarChar)).Value = fnParmCmd.intDBNull(Data.EdadMaxina);
                    Cmd.Parameters.Add(new SqlParameter("@AutoriadadCargo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.AutoridadCargo,"");
                    Cmd.Parameters.Add(new SqlParameter("@ExperenciaCargo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ExperienciaCargo, "");
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@FlagPonderacionC", SqlDbType.VarChar)).Value = Data.FlagPonderacion_c;
                    Cmd.Parameters.Add(new SqlParameter("@FormacionC", SqlDbType.VarChar)).Value = Data.Formacion_c;
                    Cmd.Parameters.Add(new SqlParameter("@HabilidadC", SqlDbType.VarChar)).Value = Data.Habilidad_c;
                    Cmd.Parameters.Add(new SqlParameter("@ActitudC", SqlDbType.VarChar)).Value = Data.Actitud_c;
                    Cmd.Parameters.Add(new SqlParameter("@GradoEducacionC", SqlDbType.VarChar)).Value = Data.GradoEducacion_c;
                    Cmd.Parameters.Add(new SqlParameter("@FlagSinFormacion", SqlDbType.VarChar)).Value = Data.FlagsInformacion;
                    Cmd.Parameters.Add(new SqlParameter("@FlagSinHabilidad", SqlDbType.VarChar)).Value = Data.FlagsInhabilidad;
                    Cmd.Parameters.Add(new SqlParameter("@FlagSinActitud", SqlDbType.VarChar)).Value = Data.FlagsInactitud;
                    Cmd.Parameters.Add(new SqlParameter("@CompetenciaGeneralC", SqlDbType.VarChar)).Value = Data.CompetenciaGeneral_c;
                    Cmd.Parameters.Add(new SqlParameter("@FlagSinCompGeneral", SqlDbType.VarChar)).Value = Data.FlagsIncompgeneral;
                    Cmd.Parameters.Add(new SqlParameter("@FlagReqImpSeG", SqlDbType.VarChar)).Value = Data.FlagReqImpSeg;
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
