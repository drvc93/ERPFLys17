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
    public class datOrdenes
    {
        public static DataTable ListaFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqOrdenesCompra;
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

        public static DataTable GetFormID(String Compania, String NumeroOrden, Int32 Ampliacion)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqOrdenesCompra;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@NumeroOrden", SqlDbType.VarChar)).Value = NumeroOrden;
                Cmd.Parameters.Add(new SqlParameter("@Ampliacion", SqlDbType.Int)).Value = Ampliacion;

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

        public static DataTable ListaToVoucher(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqOrdenesCompra;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "LSTTOVOUC";
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

        public static entErrores MantFormID(entOrdenes Data)
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
                    Cmd.CommandText = fnQuery.tsqOrdenesCompra;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroOrden", SqlDbType.VarChar)).Value = Data.NumeroOrden;
                    Cmd.Parameters.Add(new SqlParameter("@Ampliacion", SqlDbType.Int)).Value = Data.Ampliacion;
                    Cmd.Parameters.Add(new SqlParameter("@Proveedor", SqlDbType.Int)).Value = Data.Proveedor;
                    Cmd.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.VarChar)).Value = Data.RazonSocial;
                    Cmd.Parameters.Add(new SqlParameter("@DocumentoFiscal", SqlDbType.VarChar)).Value = Data.DocumentoFiscal;
                    Cmd.Parameters.Add(new SqlParameter("@ClasificacionCodigo", SqlDbType.VarChar)).Value = Data.ClasificacionCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@FormaPago", SqlDbType.VarChar)).Value = Data.FormaPago;
                    Cmd.Parameters.Add(new SqlParameter("@FlagAdelanto", SqlDbType.VarChar)).Value = Data.FlagAdelanto;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroAdelanto", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.NumeroAdelanto,0);
                    Cmd.Parameters.Add(new SqlParameter("@TipoServicio", SqlDbType.VarChar)).Value = Data.TipoServicio;
                    Cmd.Parameters.Add(new SqlParameter("@Procedencia", SqlDbType.VarChar)).Value = Data.Procedencia;
                    Cmd.Parameters.Add(new SqlParameter("@FechaEntrega", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaEntrega);
                    Cmd.Parameters.Add(new SqlParameter("@AlmacenCodigo", SqlDbType.VarChar)).Value = Data.AlmacenCodigo;
                    Cmd.Parameters.Add(new SqlParameter("@Moneda", SqlDbType.VarChar)).Value = Data.Moneda;
                    Cmd.Parameters.Add(new SqlParameter("@MontoBruto", SqlDbType.Decimal)).Value = Data.MontoBruto;
                    Cmd.Parameters.Add(new SqlParameter("@MontoIGV", SqlDbType.Decimal)).Value = Data.MontoIGV;
                    Cmd.Parameters.Add(new SqlParameter("@MontoTotal", SqlDbType.Decimal)).Value = Data.MontoTotal;
                    Cmd.Parameters.Add(new SqlParameter("@MontoGastado", SqlDbType.Decimal)).Value = Data.MontoGastado;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDeCambio", SqlDbType.Decimal)).Value = Data.TipoDeCambio;
                    Cmd.Parameters.Add(new SqlParameter("@RazonAnulacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RazonAnulacion,"");
                    Cmd.Parameters.Add(new SqlParameter("@Observacion", SqlDbType.Text)).Value = fnParmCmd.StrDBNull(Data.Observacion,"");
                    Cmd.Parameters.Add(new SqlParameter("@Contrato", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Contrato,"");
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@PreparadoPor", SqlDbType.VarChar)).Value = Data.PreparadoPor;
                    Cmd.Parameters.Add(new SqlParameter("@FechaPreparacion", SqlDbType.DateTime)).Value = Data.FechaPreparacion;
                    Cmd.Parameters.Add(new SqlParameter("@AprobadoPor", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.AprobadoPor,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaAprobacion", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaAprobacion);
                    Cmd.Parameters.Add(new SqlParameter("@FlagImpresion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.FlagImpresion,"");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioImpresion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioImpresion,"");
                    Cmd.Parameters.Add(new SqlParameter("@FlagImpresionAdelanto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.FlagImpresionAdelanto,"");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioImpresionAdelanto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioImpresionAdelanto,"");
                    Cmd.Parameters.Add(new SqlParameter("@IncotermCodigo", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.IncotermCodigo,"");
                    Cmd.Parameters.Add(new SqlParameter("@RazonCierre", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RazonCierre,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaCierre", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaCierre);
                    Cmd.Parameters.Add(new SqlParameter("@TipoCierre", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoCierre,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaEmbarque", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaEmbarque);
                    Cmd.Parameters.Add(new SqlParameter("@FechaLlegada", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaLlegada);
                    Cmd.Parameters.Add(new SqlParameter("@FlagFlete", SqlDbType.VarChar)).Value = Data.FlagFlete;
                    Cmd.Parameters.Add(new SqlParameter("@MontoFlete", SqlDbType.Decimal)).Value = Data.MontoFlete;
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioFlete", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioFlete,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaFlete", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaFlete);
                    Cmd.Parameters.Add(new SqlParameter("@AdelantoFlete", SqlDbType.Int)).Value = fnParmCmd.DecDBNull(Data.AdelantoFlete);
                    Cmd.Parameters.Add(new SqlParameter("@FleteInt_Imp", SqlDbType.Decimal)).Value = Data.FleteInt_Imp;
                    Cmd.Parameters.Add(new SqlParameter("@Flete_Imp", SqlDbType.Decimal)).Value = Data.Flete_Imp;
                    Cmd.Parameters.Add(new SqlParameter("@Seguro_Imp", SqlDbType.Decimal)).Value = Data.Seguro_Imp;
                    Cmd.Parameters.Add(new SqlParameter("@FlagOrigen", SqlDbType.VarChar)).Value = Data.FlagOrigen;
                    Cmd.Parameters.Add(new SqlParameter("@FlagReplicado", SqlDbType.VarChar)).Value = Data.FlagReplicado;
                    Cmd.Parameters.Add(new SqlParameter("@CompaniaRep", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CompaniaRep,"");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroOrdenRep", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroOrdenRep,"");
                    Cmd.Parameters.Add(new SqlParameter("@Proveedor_Original", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.Proveedor_Original);
                    Cmd.Parameters.Add(new SqlParameter("@RazonOriginal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.RazonOriginal,"");
                    Cmd.Parameters.Add(new SqlParameter("@Garantia_Cab", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Garantia_Cab,"");
                    Cmd.Parameters.Add(new SqlParameter("@Operatividad_Cab", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Operatividad_Cab,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaCanalRojo", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaCanalRojo);
                    Cmd.Parameters.Add(new SqlParameter("@FechaCanalNaranja", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaCanalNaranja);
                    Cmd.Parameters.Add(new SqlParameter("@OrdenFirma", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.OrdenFirma);
                    Cmd.Parameters.Add(new SqlParameter("@EstadoFirma", SqlDbType.VarChar)).Value = Data.EstadoFirma;
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioFirma", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioFirma,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaFirma", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaFirma);
                    Cmd.Parameters.Add(new SqlParameter("@Via", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Via,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaPagoIni", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaPagoIni);
                    Cmd.Parameters.Add(new SqlParameter("@FlagSimOC", SqlDbType.VarChar)).Value = Data.FlagSimOC;
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
