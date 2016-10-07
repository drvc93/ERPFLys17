using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Model.Maestro.Mantenimiento;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Maestro.Mantenimiento
{
    public class datMaquina
    {
        public static DataTable ListaFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqMaquina;
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

        public static DataTable GetFormID(String Compania, String Maquina)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqMaquina;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Maquina", SqlDbType.VarChar)).Value = Maquina;

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
                Cmd.CommandText = fnQuery.tsqMaquina;
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

        public static DataTable ListaSearch(String Compania, String Maquina, String Descripcion,String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqMaquina;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Maquina", SqlDbType.VarChar)).Value = Maquina;
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

        public static entErrores MantFormID(entMaquina Data)
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
                    Cmd.CommandText = fnQuery.tsqMaquina;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Maquina", SqlDbType.VarChar)).Value = Data.Maquina;
                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                    Cmd.Parameters.Add(new SqlParameter("@TipoMaquina", SqlDbType.VarChar)).Value = Data.TipoMaquina;
                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CentroCosto,"");
                    Cmd.Parameters.Add(new SqlParameter("@Potencia", SqlDbType.Decimal)).Value = Data.Potencia;
                    Cmd.Parameters.Add(new SqlParameter("@PiezasMax", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.PiezasMax);
                    Cmd.Parameters.Add(new SqlParameter("@CostoMaquinaHora", SqlDbType.Decimal)).Value = Data.CostoMaquinaHora;
                    Cmd.Parameters.Add(new SqlParameter("@CodMarca", SqlDbType.VarChar)).Value = Data.CodMarca;
                    Cmd.Parameters.Add(new SqlParameter("@CodModelo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodModelo,"");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroSerie", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroSerie, "");
                    Cmd.Parameters.Add(new SqlParameter("@AnoFabricacion", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.AnoFabricacion);
                    Cmd.Parameters.Add(new SqlParameter("@AnoPuestaMarcha", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.AnoPuestaMarcha);
                    Cmd.Parameters.Add(new SqlParameter("@ProvFabricante", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.ProvFabricante);
                    Cmd.Parameters.Add(new SqlParameter("@ProvRepresentante", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.ProvRepresentante);
                    Cmd.Parameters.Add(new SqlParameter("@PesoTotal", SqlDbType.Decimal)).Value = Data.PesoTotal;
                    Cmd.Parameters.Add(new SqlParameter("@Largo", SqlDbType.Decimal)).Value = Data.Largo;
                    Cmd.Parameters.Add(new SqlParameter("@Ancho", SqlDbType.Decimal)).Value = Data.Ancho;
                    Cmd.Parameters.Add(new SqlParameter("@Altura", SqlDbType.Decimal)).Value = Data.Altura;
                    Cmd.Parameters.Add(new SqlParameter("@PotencialTotal", SqlDbType.Decimal)).Value = Data.PotencialTotal;
                    Cmd.Parameters.Add(new SqlParameter("@PromedioHoraDia", SqlDbType.Decimal)).Value = Data.PromedioHoraDia;
                    Cmd.Parameters.Add(new SqlParameter("@MonedaCosto", SqlDbType.VarChar)).Value = Data.MonedaCosto;
                    Cmd.Parameters.Add(new SqlParameter("@Costo", SqlDbType.Decimal)).Value = Data.Costo;
                    Cmd.Parameters.Add(new SqlParameter("@MonedaCostoParada", SqlDbType.VarChar)).Value = Data.MonedaCostoParada;
                    Cmd.Parameters.Add(new SqlParameter("@CostoParada", SqlDbType.Decimal)).Value = Data.CostoParada;
                    Cmd.Parameters.Add(new SqlParameter("@Criticidad", SqlDbType.VarChar)).Value = Data.Criticidad;
                    Cmd.Parameters.Add(new SqlParameter("@TiempoGarantia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TiempoGarantia,"");
                    Cmd.Parameters.Add(new SqlParameter("@InformacionTecnica", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.InformacionTecnica,"");
                    Cmd.Parameters.Add(new SqlParameter("@Planos", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Planos,"");
                    Cmd.Parameters.Add(new SqlParameter("@CaracteristicasOperacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CaracteristicasOperacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UltimoUsuario;
                    Cmd.Parameters.Add(new SqlParameter("@UltimaFechaModificacion", SqlDbType.DateTime)).Value = Data.UltimaFechaModificacion;
                    Cmd.Parameters.Add(new SqlParameter("@Turno1", SqlDbType.Decimal)).Value = Data.Turno1;
                    Cmd.Parameters.Add(new SqlParameter("@Turno2", SqlDbType.Decimal)).Value = Data.Turno2;
                    Cmd.Parameters.Add(new SqlParameter("@Turno3", SqlDbType.Decimal)).Value = Data.Turno3;
                    Cmd.Parameters.Add(new SqlParameter("@TiempoPreparacion", SqlDbType.Decimal)).Value = Data.TiempoPreparacion;
                    Cmd.Parameters.Add(new SqlParameter("@TiempoRegulacion", SqlDbType.Decimal)).Value = Data.TiempoRegulacion;
                    Cmd.Parameters.Add(new SqlParameter("@Gas", SqlDbType.VarChar)).Value = Data.Gas;
                    Cmd.Parameters.Add(new SqlParameter("@OtroRepresentante", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.OtroRepresentante, "");
                    Cmd.Parameters.Add(new SqlParameter("@AnoPuestaMarcha", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaAnoPuestaMarcha);
                    Cmd.Parameters.Add(new SqlParameter("@Critica", SqlDbType.VarChar)).Value = Data.Critica;
                    Cmd.Parameters.Add(new SqlParameter("@NivelCriticidad", SqlDbType.Int)).Value = Data.NivelCriticidad;
                    Cmd.Parameters.Add(new SqlParameter("@Paralelo", SqlDbType.VarChar)).Value = Data.Paralelo;
                    Cmd.Parameters.Add(new SqlParameter("@Alquiler", SqlDbType.VarChar)).Value = Data.Alquiler;
                    Cmd.Parameters.Add(new SqlParameter("@OpAU", SqlDbType.VarChar)).Value = Data.OpAU;
                    Cmd.Parameters.Add(new SqlParameter("@OpSA", SqlDbType.VarChar)).Value = Data.OpSA;
                    Cmd.Parameters.Add(new SqlParameter("@OpMN", SqlDbType.VarChar)).Value = Data.OpMN;
                    Cmd.Parameters.Add(new SqlParameter("@CodigoBarra", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodigoBarra, "");
                    Cmd.Parameters.Add(new SqlParameter("@FamiliaInspeccion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.FamiliaInspeccion, "");
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
