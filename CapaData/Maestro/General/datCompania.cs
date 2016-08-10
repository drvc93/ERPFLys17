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
    public class datCompania{

        public static DataTable ListaFormID()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCompania;
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

        public static DataTable GetFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCompania;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
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

        public static DataTable ListaCombo(String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCompania;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstCombo;
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

        public static DataTable ListaSearch(String Compania, String Nombre, String DocumentoFiscal, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCompania;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar)).Value = Nombre;
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

        public static DataTable ListaXUsuario(String App,String Usuario,String SoloActivo)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqCompaniaXUsu;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Aplicacion", SqlDbType.VarChar)).Value = App;
                Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Usuario;
                Cmd.Parameters.Add(new SqlParameter("@FlagSoloActivo", SqlDbType.VarChar)).Value = SoloActivo;
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

        public static entErrores MantCompania(entCompania Data)
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
                    Cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar)).Value = Data.Nombres;
                    Cmd.Parameters.Add(new SqlParameter("@NombreTeleCredito", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NombreTelecredito, "");
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Telefono, "");
                    Cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Direccion, "");
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocumentoFiscal, "");
                    Cmd.Parameters.Add(new SqlParameter("@Pais", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Pais, "");
                    Cmd.Parameters.Add(new SqlParameter("@DepartamentoCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DepartamentoCodigo, "");
                    Cmd.Parameters.Add(new SqlParameter("@ProvinciaCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ProvinciaCodigo, "");
                    Cmd.Parameters.Add(new SqlParameter("@DistritoCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DistritoCodigo, "");
                    Cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Fax, "");
                    Cmd.Parameters.Add(new SqlParameter("@ActividadEconomica", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ActividadEconomica, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoSunat_Condicion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoSunat_Condicion, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoSunat_Via", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoSunat_Via, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoSunat_Zona", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoSunat_Zona, "");
                    Cmd.Parameters.Add(new SqlParameter("@CodigoSunat_TipoEstab", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoSunat_TipoEstab, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagEndoso", SqlDbType.VarChar)).Value = Data.FlagEndoso;
                    Cmd.Parameters.Add(new SqlParameter("@CompaniaEndoso", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CompaniaEndoso, "");
                    Cmd.Parameters.Add(new SqlParameter("@SerieLetra", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.SerieLetra, "");
                    Cmd.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.Codigo,0);
                    Cmd.Parameters.Add(new SqlParameter("@SectorCompania", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.SectorCompania, "");
                    Cmd.Parameters.Add(new SqlParameter("@Aplica_Ret", SqlDbType.VarChar)).Value = Data.Aplica_Ret;
                    Cmd.Parameters.Add(new SqlParameter("@MonedaMnt_Ret", SqlDbType.VarChar)).Value = Data.MonedaMnt_Ret;
                    Cmd.Parameters.Add(new SqlParameter("@MntLimite_Ret", SqlDbType.VarChar)).Value = Data.MntLimite_Ret;
                    Cmd.Parameters.Add(new SqlParameter("@Porcent_Ret", SqlDbType.VarChar)).Value = Data.Porcent_Ret;
                    Cmd.Parameters.Add(new SqlParameter("@Serie_Ret", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Serie_Ret, "");
                    Cmd.Parameters.Add(new SqlParameter("@Limite_Ret", SqlDbType.VarChar)).Value = Data.Limite_Ret;
                    Cmd.Parameters.Add(new SqlParameter("@FlagReplica", SqlDbType.VarChar)).Value = Data.FlagReplica;
                    Cmd.Parameters.Add(new SqlParameter("@CompReplica", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CompReplica, "");
                    Cmd.Parameters.Add(new SqlParameter("@NameBD_O", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NameBd_d, "");
                    Cmd.Parameters.Add(new SqlParameter("@NameBD_D", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NameBd_o, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagCofilsa", SqlDbType.VarChar)).Value = Data.FlagCofilsa;
                    Cmd.Parameters.Add(new SqlParameter("@Org_Hoshin", SqlDbType.VarChar)).Value = fnParmCmd.intDBNull(Data.Org_Hoshin, 0);
                    Cmd.Parameters.Add(new SqlParameter("@MontoMinSolesBack", SqlDbType.VarChar)).Value = Data.MontoMinSolesBack; ;
                    Cmd.Parameters.Add(new SqlParameter("@CompBaseComision", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CompBaseComision, "");
                    Cmd.Parameters.Add(new SqlParameter("@ValidaNoHabNohall", SqlDbType.VarChar)).Value = Data.ValidaNoHabNoHall;
                    Cmd.Parameters.Add(new SqlParameter("@MailDocElec", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.MailDocElec, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagFactElec", SqlDbType.VarChar)).Value = Data.FlagFactElec;
                    Cmd.Parameters.Add(new SqlParameter("@AudEstacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Pais, "");
                    Cmd.Parameters.Add(new SqlParameter("@AudFechaEst", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Pais, "");
                    Cmd.ExecuteNonQuery();
                    
                    Trs.Commit();
                    entErr.Resultado = true;                    
                }
                catch (Exception ex){
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
