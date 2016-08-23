using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FiltroLys.Model.Tesoreria;
using FiltroLys.Model.Objeto;
using FiltroLys.Repository.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Repository.Tesoreria
{
    public class datObligacion{

        public static DataTable ListaFormID(String Compania)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqObligacion;
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

        public static DataTable GetFormID(String Compania, String Obligacion)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqObligacion;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstID;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Obligacion", SqlDbType.Int)).Value = Obligacion;

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

        public static DataTable ListaSearch(String Compania, String TipoDocumento, String NumeroDocumento, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqObligacion;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstBusqueda;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar)).Value = TipoDocumento;
                Cmd.Parameters.Add(new SqlParameter("@NumeroDocumento", SqlDbType.VarChar)).Value = NumeroDocumento;
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

        public static DataTable ListaToVoucher(String Compania,Int32 CodProveedor, String TipoDocumento, String NumeroDocumento, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqObligacion;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "LSTTOVOUC";
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@CodProveedor", SqlDbType.Int)).Value = CodProveedor;
                Cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar)).Value = TipoDocumento;
                Cmd.Parameters.Add(new SqlParameter("@NumeroDocumento", SqlDbType.VarChar)).Value = NumeroDocumento;
                Cmd.Parameters.Add(new SqlParameter("@EstadoDoc", SqlDbType.VarChar)).Value = Estado;
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

        public static Int32 GetNumObligacion(String Compania, Int32 CodProveedor, String TipoDocumento, String NumeroDocumento)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();
            Int32 nOb = 0;

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqObligacion;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "GETNUMOBL";
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@CodProveedor", SqlDbType.Int)).Value = CodProveedor;
                Cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar)).Value = TipoDocumento;
                Cmd.Parameters.Add(new SqlParameter("@NumeroDocumento", SqlDbType.VarChar)).Value = NumeroDocumento;
                try { nOb = (Int32)Cmd.ExecuteScalar(); }
                catch (Exception e) { nOb = 0; }

                if (Cmd.Connection.State == ConnectionState.Open)
                {
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    GC.SuppressFinalize(Cnx);
                }
            }
            return nOb;
        }

        public static entErrores MantFormID(entObligacion Data)
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
                    Cmd.CommandText = fnQuery.tsqObligacion;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Obligacion", SqlDbType.Int)).Value = Data.Obligacion;
                    Cmd.Parameters.Add(new SqlParameter("@TipoDocumento", SqlDbType.VarChar)).Value = Data.TipoDocumento;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroDocumento", SqlDbType.VarChar)).Value = Data.NumeroDocumento;
                    Cmd.Parameters.Add(new SqlParameter("@CodProveedor", SqlDbType.Int)).Value = Data.CodProveedor;
                    Cmd.Parameters.Add(new SqlParameter("@CodPagarANombre", SqlDbType.Int)).Value = Data.CodPagarANombre;
                    Cmd.Parameters.Add(new SqlParameter("@NumDocFiscal", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumDocFiscal,"");
                    Cmd.Parameters.Add(new SqlParameter("@NombreProveedor", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NombreProveedor,"");
                    Cmd.Parameters.Add(new SqlParameter("@PagoANombre", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.PagoANombre,"");
                    Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CentroCosto,"");
                    Cmd.Parameters.Add(new SqlParameter("@CodIng", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodIng,"");
                    Cmd.Parameters.Add(new SqlParameter("@CodAPrueba", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CodAPrueba, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaRegistro", SqlDbType.DateTime)).Value = Data.FechaRegistro;
                    Cmd.Parameters.Add(new SqlParameter("@FechaEmision", SqlDbType.DateTime)).Value = Data.FechaEmision;
                    Cmd.Parameters.Add(new SqlParameter("@FechaRecepcion", SqlDbType.DateTime)).Value = Data.FechaRecepcion;
                    Cmd.Parameters.Add(new SqlParameter("@FechaVencimiento", SqlDbType.DateTime)).Value = Data.FechaVencimiento;
                    Cmd.Parameters.Add(new SqlParameter("@FechaPago", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaPago);
                    Cmd.Parameters.Add(new SqlParameter("@FechaAprobacion", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaAprobacion);
                    Cmd.Parameters.Add(new SqlParameter("@FechaVencOrigen", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaVencOrigen);
                    Cmd.Parameters.Add(new SqlParameter("@MonedaDoc", SqlDbType.VarChar)).Value = Data.MonedaDoc;
                    Cmd.Parameters.Add(new SqlParameter("@TipoCambio", SqlDbType.Decimal)).Value = Data.TipoCambio;
                    Cmd.Parameters.Add(new SqlParameter("@MontoAfecto", SqlDbType.Decimal)).Value = Data.MontoAfecto;
                    Cmd.Parameters.Add(new SqlParameter("@MontoNoAfecto", SqlDbType.Decimal)).Value = Data.MontoNoAfecto;
                    Cmd.Parameters.Add(new SqlParameter("@MontoIgv", SqlDbType.Decimal)).Value = Data.MontoIgv;
                    Cmd.Parameters.Add(new SqlParameter("@MontoOtroImpuesto", SqlDbType.Decimal)).Value = Data.MontoOtroImpuesto;
                    Cmd.Parameters.Add(new SqlParameter("@MontoTotal", SqlDbType.Decimal)).Value = Data.MontoTotal;
                    Cmd.Parameters.Add(new SqlParameter("@MontoAdelanto", SqlDbType.Decimal)).Value = Data.MontoAdelanto;
                    Cmd.Parameters.Add(new SqlParameter("@MontoPagoParcial", SqlDbType.Decimal)).Value = Data.MontoPagoParcial;
                    Cmd.Parameters.Add(new SqlParameter("@Mora", SqlDbType.Decimal)).Value = Data.Mora;
                    Cmd.Parameters.Add(new SqlParameter("@SaldoAPagar", SqlDbType.Decimal)).Value = Data.SaldoAPagar;
                    Cmd.Parameters.Add(new SqlParameter("@Saldo", SqlDbType.Decimal)).Value = Data.Saldo;
                    Cmd.Parameters.Add(new SqlParameter("@TipoServicio", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoServicio, "");
                    Cmd.Parameters.Add(new SqlParameter("@MonedaPago", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.MonedaPago, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoPago", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoPago, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlujoCaja", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.FlujoCaja, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlujoCajaPago", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.FlujoCajaPago, "");
                    Cmd.Parameters.Add(new SqlParameter("@Compania_Rel", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Compania_Rel, "");
                    Cmd.Parameters.Add(new SqlParameter("@Obligacion_Rel", SqlDbType.Int)).Value = fnParmCmd.DecDBNull(Data.Obligacion_Rel);
                    Cmd.Parameters.Add(new SqlParameter("@TipoDocumento_Rel", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoDocumento_Rel, "");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroDoc_Rel", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroDoc_Rel, "");
                    Cmd.Parameters.Add(new SqlParameter("@BancoCodigoPago", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.BancoCodigoPago, "");
                    Cmd.Parameters.Add(new SqlParameter("@CtaBancariaPago", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CtaBancariaPago, "");
                    Cmd.Parameters.Add(new SqlParameter("@CptoContable", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CptoContable, "");
                    Cmd.Parameters.Add(new SqlParameter("@BancoCodigoCobro", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.BancoCodigoCobro, "");
                    Cmd.Parameters.Add(new SqlParameter("@CAgenciaCobro", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CAgenciaCobro, "");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroPago", SqlDbType.Int)).Value = fnParmCmd.DecDBNull(Data.NumeroPago);
                    Cmd.Parameters.Add(new SqlParameter("@SecuenciaPago", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.SecuenciaPago);
                    Cmd.Parameters.Add(new SqlParameter("@FlagGenPago", SqlDbType.VarChar)).Value = Data.FlagGenPago;
                    Cmd.Parameters.Add(new SqlParameter("@FlagAgruparPago", SqlDbType.VarChar)).Value = Data.FlagAgruparPago;
                    Cmd.Parameters.Add(new SqlParameter("@FlagPagoDiferido", SqlDbType.VarChar)).Value = Data.FlagPagoDiferido;
                    Cmd.Parameters.Add(new SqlParameter("@FlagContabilizado", SqlDbType.VarChar)).Value = Data.FlagContabilizado;
                    Cmd.Parameters.Add(new SqlParameter("@FlagAdelanto", SqlDbType.VarChar)).Value = Data.FlagAdelanto;
                    Cmd.Parameters.Add(new SqlParameter("@PeriodoVoucher", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.PeriodoVoucher, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaProvision", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaProvision);
                    Cmd.Parameters.Add(new SqlParameter("@TipoCambioProv", SqlDbType.Decimal)).Value = fnParmCmd.DecDBNull(Data.TipoCambioProv);
                    Cmd.Parameters.Add(new SqlParameter("@Voucher", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.Voucher);
                    Cmd.Parameters.Add(new SqlParameter("@PeriodoVoucherAN", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.PeriodoVoucherAN, "");
                    Cmd.Parameters.Add(new SqlParameter("@VoucherAnulacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.VoucherAnulacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Origen", SqlDbType.VarChar)).Value = Data.Origen;
                    Cmd.Parameters.Add(new SqlParameter("@PeriodoRegCompra", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.PeriodoRegCompra, "");
                    Cmd.Parameters.Add(new SqlParameter("@EstadoDoc", SqlDbType.VarChar)).Value = Data.EstadoDoc;
                    Cmd.Parameters.Add(new SqlParameter("@GlosaVoucher", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.GlosaVoucher, "");
                    Cmd.Parameters.Add(new SqlParameter("@CObservacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.CObservacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@ObsAnulacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObsAnulacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@Advalorem", SqlDbType.Decimal)).Value = Data.Advalorem;
                    Cmd.Parameters.Add(new SqlParameter("@FlagImportacion", SqlDbType.VarChar)).Value = Data.FlagImportacion;
                    Cmd.Parameters.Add(new SqlParameter("@BancoCustodia", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.BancoCustodia, "");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroBanco", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroBanco, "");
                    Cmd.Parameters.Add(new SqlParameter("@TipoNegociacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoNegociacion, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaEnvioBanco", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaEnvioBanco);
                    Cmd.Parameters.Add(new SqlParameter("@RegistroOB", SqlDbType.Int)).Value = fnParmCmd.DecDBNull(Data.RegistroOB);
                    Cmd.Parameters.Add(new SqlParameter("@VoucherPend", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.VoucherPend, "");
                    Cmd.Parameters.Add(new SqlParameter("@ObsPendiente", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ObsPendiente, "");
                    Cmd.Parameters.Add(new SqlParameter("@FlagPercepcion", SqlDbType.VarChar)).Value = Data.FlagPercepcion;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroImportacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroImportacion,"");
                    Cmd.Parameters.Add(new SqlParameter("@FlagDetraccion", SqlDbType.VarChar)).Value = Data.FlagDetraccion;
                    Cmd.Parameters.Add(new SqlParameter("@CodBienServDet", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.CodBienServDet);
                    Cmd.Parameters.Add(new SqlParameter("@CodTipoOpeDet", SqlDbType.Int)).Value = fnParmCmd.intDBNull(Data.CodTipoOpeDet);
                    Cmd.Parameters.Add(new SqlParameter("@PorcentajeDet", SqlDbType.Decimal)).Value = fnParmCmd.DecDBNull(Data.PorcentajeDet);
                    Cmd.Parameters.Add(new SqlParameter("@FlagMontoRefDet", SqlDbType.VarChar)).Value = Data.FlagMontoRefDet;
                    Cmd.Parameters.Add(new SqlParameter("@MontoRefDet", SqlDbType.Decimal)).Value = fnParmCmd.DecDBNull(Data.MontoRefDet);
                    Cmd.Parameters.Add(new SqlParameter("@BaseImponible", SqlDbType.Decimal)).Value = Data.BaseImponible;
                    Cmd.Parameters.Add(new SqlParameter("@MontoIvgImp", SqlDbType.Decimal)).Value = Data.MontoIvgImp;
                    Cmd.Parameters.Add(new SqlParameter("@FlagHabilitaVisto", SqlDbType.VarChar)).Value = Data.FlagHabilitaVisto;
                    Cmd.Parameters.Add(new SqlParameter("@FlagVisto", SqlDbType.VarChar)).Value = Data.FlagVisto;
                    Cmd.Parameters.Add(new SqlParameter("@FlagRecepcionDoc", SqlDbType.VarChar)).Value = Data.FlagRecepcionDoc;
                    Cmd.Parameters.Add(new SqlParameter("@PeriodoPlanilla", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.PeriodoPlanilla,"");
                    Cmd.Parameters.Add(new SqlParameter("@FactoryAnt", SqlDbType.VarChar)).Value = Data.FactoryAnt;
                    Cmd.Parameters.Add(new SqlParameter("@MontoRetencion", SqlDbType.Decimal)).Value = Data.MontoRetencion;
                    Cmd.Parameters.Add(new SqlParameter("@DocSunatDet", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocSunatDet, "");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioConstDetraccion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioConstDetraccion,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaConstDetraccion", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaConstDetraccion);
                    Cmd.Parameters.Add(new SqlParameter("@FlagConstancia", SqlDbType.VarChar)).Value = Data.FlagConstancia;
                    Cmd.Parameters.Add(new SqlParameter("@DocSunatDet_Otro", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.DocSunatDet_Otro,"");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioConstDetraccion_Otro", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioConstDetraccion_Otro,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaConstDetraccion_Otro", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaConstDetraccion_Otro);
                    Cmd.Parameters.Add(new SqlParameter("@FlagConstancia_Otro", SqlDbType.VarChar)).Value = Data.FlagConstancia_Otro;
                    Cmd.Parameters.Add(new SqlParameter("@FechaSunatDet", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaSunatDet);
                    Cmd.Parameters.Add(new SqlParameter("@FechaSunatDet_Otro", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaSunatDet_Otro);
                    Cmd.Parameters.Add(new SqlParameter("@FlagFactoring", SqlDbType.VarChar)).Value = Data.FlagFactoring;
                    Cmd.Parameters.Add(new SqlParameter("@DiasPlazo", SqlDbType.Decimal)).Value = fnParmCmd.DecDBNull(Data.DiasPlazo);
                    Cmd.Parameters.Add(new SqlParameter("@FechaVencimiento_Fact", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaVencimiento_Fact);
                    Cmd.Parameters.Add(new SqlParameter("@MontoFactoring", SqlDbType.Decimal)).Value = fnParmCmd.DecDBNull(Data.MontoFactoring);
                    Cmd.Parameters.Add(new SqlParameter("@FechaRecepcion_Fact", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaRecepcion_Fact);
                    Cmd.Parameters.Add(new SqlParameter("@TipoDocumento_Fact", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.TipoDocumento_Fact,"");
                    Cmd.Parameters.Add(new SqlParameter("@NumeroDocumento_Fact", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.NumeroDocumento_Fact, "");
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioSubida_Fact", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioSubida_Fact, "");
                    Cmd.Parameters.Add(new SqlParameter("@FechaSubida_Fact", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaSubida_Fact);
                    Cmd.Parameters.Add(new SqlParameter("@ImporteSunatDet", SqlDbType.Decimal)).Value = Data.ImporteSunatDet;
                    Cmd.Parameters.Add(new SqlParameter("@ImporteSunatDet_Otro", SqlDbType.Decimal)).Value = Data.ImporteSunatDet_Otro;
                    Cmd.Parameters.Add(new SqlParameter("@ClasificacionBienServ", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.ClasificacionBienServ,"");
                    Cmd.Parameters.Add(new SqlParameter("@FlagAutoDetraccion", SqlDbType.VarChar)).Value = Data.FlagAutoDetraccion;
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
