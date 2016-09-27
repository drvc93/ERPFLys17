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

namespace FiltroLys.Repository.Contabilidad
{
    public class datVoucher{

        public static DataTable ListaFormID(String Compania, String FlagDepartCia, String DepartCia, String FlagPeriodo,
        String Periodo,String FlagEstado,String Estado,String FlagVoucher,String TipoVoucher,String VoucherIni,String VoucherFin)
        {
            DataTable dt=new DataTable();
            SqlCommand Cmd = new SqlCommand();
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqVoucher;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = fnConst.OperLstMaestra;
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@FlagDepartCia", SqlDbType.VarChar)).Value = FlagDepartCia;
                Cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar)).Value = DepartCia;
                Cmd.Parameters.Add(new SqlParameter("@FlagPeriodo", SqlDbType.VarChar)).Value = FlagPeriodo;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
                Cmd.Parameters.Add(new SqlParameter("@FlagEstado", SqlDbType.VarChar)).Value = FlagEstado;
                Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Estado;
                Cmd.Parameters.Add(new SqlParameter("@FlagVoucher", SqlDbType.VarChar)).Value = FlagVoucher;
                Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = TipoVoucher;
                Cmd.Parameters.Add(new SqlParameter("@VoucherIni", SqlDbType.VarChar)).Value = VoucherIni;
                Cmd.Parameters.Add(new SqlParameter("@VoucherFin", SqlDbType.VarChar)).Value = VoucherFin;
                
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

        public static DataTable GetFormID(String Compania, String Periodo, String TipoVoucher, String NumeroVoucher)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqVoucher;
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

        public static DataTable LstSaldoMayor(String Compania, String Periodo, String Estado)
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion()))
            {
                Cmd.Connection = Cnx;
                Cmd.Connection.Open();
                Cmd.CommandText = fnQuery.tsqVoucher;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnConst.OperaAccionLst;
                Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "RESMAY";
                Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Compania;
                Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Periodo;
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

        public static entErrores MantFormID(entVoucher Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();            
            String sMsj = "",sCod = "";

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;

                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Clear();
                    Cmd.CommandText = fnQuery.tsqVoucher;

                    //Grabando Cabecera Cuenta Contable
                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(Data.OperMantenimiento);
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = Data.Opcion;
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar,4)).Value = Data.NumeroVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar)).Value = Data.Departamento;
                    Cmd.Parameters.Add(new SqlParameter("@Moneda", SqlDbType.VarChar)).Value = Data.Moneda;
                    Cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = Data.Fecha;
                    Cmd.Parameters.Add(new SqlParameter("@TipoCambio", SqlDbType.Decimal)).Value = Data.TipoCambio;
                    Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = Data.Descripcion;
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioRegistro", SqlDbType.VarChar)).Value = Data.UsuarioRegistro;
                    Cmd.Parameters.Add(new SqlParameter("@FechaRegistro", SqlDbType.DateTime)).Value = Data.FechaRegistro;
                    Cmd.Parameters.Add(new SqlParameter("@UsuarioAprobacion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(Data.UsuarioAprobacion,"");
                    Cmd.Parameters.Add(new SqlParameter("@FechaAprobacion", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(Data.FechaAprobacion);
                    Cmd.Parameters.Add(new SqlParameter("@Origen", SqlDbType.VarChar)).Value = Data.Origen;
                    Cmd.Parameters.Add(new SqlParameter("@FlagModManual", SqlDbType.VarChar)).Value = Data.FlagModManual;
                    Cmd.Parameters.Add(new SqlParameter("@FlagModRestringida", SqlDbType.VarChar)).Value = Data.FlagModRestringida;
                    Cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar)).Value = Data.Estado;
                    Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@AudEstacion", SqlDbType.VarChar)).Value = Data.EstacionSys;
                    Cmd.Parameters.Add(new SqlParameter("@AudFechaEst", SqlDbType.DateTime)).Value = Data.FechaSys;
                    Cmd.Parameters["@NumeroVoucher"].Direction = ParameterDirection.InputOutput;
                    Cmd.ExecuteNonQuery();

                    sCod = Cmd.Parameters["@NumeroVoucher"].Value.ToString();
                    Data.NumeroVoucher = sCod;
                    entErr.CodigoGeneradoText = sCod;

                    //Quitando Detalle por Compañia
                    if (Data.OperMantenimiento == fnEnum.OperacionMant.Insertar || Data.OperMantenimiento == fnEnum.OperacionMant.Modificar){
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.Clear();
                        Cmd.CommandText = fnQuery.tsqVoucherDet;

                        Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = "DEL";
                        Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "ALL";
                        Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                        Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                        Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@UltimoUsuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                        Cmd.Parameters.Add(new SqlParameter("@AudEstacion", SqlDbType.VarChar)).Value = Data.EstacionSys;
                        Cmd.Parameters.Add(new SqlParameter("@AudFechaEst", SqlDbType.DateTime)).Value = Data.FechaSys;
                        Cmd.ExecuteNonQuery();
                    }

                    //Grabando Detalle Voucher                    
                    foreach (entVoucherDet oEnt in Data.DetalleVoucher)
                    {
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.Clear();
                        Cmd.CommandText = fnQuery.tsqVoucherDet;

                        Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = fnGetOpera.getOperacion(oEnt.OperMantenimiento);
                        Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = oEnt.Opcion;
                        Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                        Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                        Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@Linea", SqlDbType.Int)).Value = oEnt.Linea;
                        Cmd.Parameters.Add(new SqlParameter("@Cuenta", SqlDbType.VarChar)).Value = oEnt.Cuenta;
                        Cmd.Parameters.Add(new SqlParameter("@Persona", SqlDbType.Int)).Value = fnParmCmd.intDBNull(oEnt.Persona,0);
                        Cmd.Parameters.Add(new SqlParameter("@CentroCosto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.CentroCosto,"");
                        Cmd.Parameters.Add(new SqlParameter("@FlujoCaja", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.FlujoCaja,"");
                        Cmd.Parameters.Add(new SqlParameter("@OrigenDoc", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.OrigenDoc,fnConst.StrNull);
                        Cmd.Parameters.Add(new SqlParameter("@CodigoDoc", SqlDbType.Int)).Value = fnParmCmd.DecDBNull(oEnt.CodigoDoc,0);
                        Cmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Documento);
                        Cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = fnParmCmd.DatDBNull(oEnt.Fecha);
                        Cmd.Parameters.Add(new SqlParameter("@Proyecto", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Proyecto,"");
                        Cmd.Parameters.Add(new SqlParameter("@OrdenCompra", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.OrdenCompra,"");
                        Cmd.Parameters.Add(new SqlParameter("@Secuencia_OC", SqlDbType.Int)).Value = fnParmCmd.intDBNull(oEnt.Secuencia_OC,0);
                        Cmd.Parameters.Add(new SqlParameter("@MontoLocal", SqlDbType.Decimal)).Value = oEnt.MontoLocal;
                        Cmd.Parameters.Add(new SqlParameter("@MontoExt", SqlDbType.Decimal)).Value = oEnt.MontoExt;
                        Cmd.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.Descripcion);
                        Cmd.Parameters.Add(new SqlParameter("@FlagAutomatico", SqlDbType.VarChar)).Value = oEnt.FlagAutomatico;
                        Cmd.Parameters.Add(new SqlParameter("@UltimoUsuarioMod", SqlDbType.VarChar)).Value = oEnt.UltimoUsuarioMod;
                        Cmd.Parameters.Add(new SqlParameter("@UltimaFechaMod", SqlDbType.DateTime)).Value = oEnt.UltimaFechaMod;
                        Cmd.Parameters.Add(new SqlParameter("@CodMaquina", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.CodMaquina,"");
                        Cmd.Parameters.Add(new SqlParameter("@GrupoCC", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.GrupoCC,"");
                        Cmd.Parameters.Add(new SqlParameter("@ClasificacionGCC", SqlDbType.VarChar)).Value = fnParmCmd.StrDBNull(oEnt.ClasificacionGCC,"");
                        Cmd.Parameters.Add(new SqlParameter("@AudEstacion", SqlDbType.VarChar)).Value = Data.EstacionSys;
                        Cmd.Parameters.Add(new SqlParameter("@AudFechaEst", SqlDbType.DateTime)).Value = Data.FechaSys;
                        Cmd.ExecuteNonQuery();
                    }

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

        public static entErrores AnularReg(entVoucher Data)
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
                    Cmd.CommandText = fnQuery.tsqVoucher;

                    Cmd.Parameters.Add(new SqlParameter("@Accion", SqlDbType.VarChar)).Value = "UPD";
                    Cmd.Parameters.Add(new SqlParameter("@Opcion", SqlDbType.VarChar)).Value = "ANUL";
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
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

        public static entErrores AprobarReg(entVoucher Data)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            String sMsj = "";

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
                    Cmd.Parameters.Clear();
                    Cmd.CommandText = fnQuery.tsqVoucherAprob;

                    //Grabando Cabecera Cuenta Contable
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar,255)).Value = "";
                    Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.InputOutput;
                    Cmd.ExecuteNonQuery();

                    sMsj = Cmd.Parameters["@Mensaje"].Value.ToString();
                    if (sMsj.Equals("OK")) {
                        Trs.Commit();
                        entErr.Resultado = true;
                    }else{
                        entErr.Errores.Add(new entFail() { Codigo = "X1", Descripcion = sMsj });
                        Trs.Rollback();
                        entErr.Resultado = false;
                    }
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

        public static entErrores PasarPendienteReg(entVoucher Data)
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
                    Cmd.CommandText = fnQuery.tsqVoucherPend;

                    //Grabando Cabecera Cuenta Contable
                    Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = Data.Compania;
                    Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = Data.Periodo;
                    Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = Data.TipoVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = Data.NumeroVoucher;
                    Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = Data.UsuarioSys;
                    Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar,250)).Value = "";
                    Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.InputOutput;
                    Cmd.ExecuteNonQuery();

                    sMsj = Cmd.Parameters["@Mensaje"].Value.ToString();
                    if (sMsj.Equals("OK")){
                        Trs.Commit();
                        entErr.Resultado = true;
                    }else{
                        entErr.Errores.Add(new entFail() { Codigo = "X1", Descripcion = sMsj });
                        Trs.Rollback();
                        entErr.Resultado = false;
                    }
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

        public static entErrores AprobarMasivo(List<entVoucher> Data, ref BackgroundWorker worker)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            Boolean bOk = true;
            String sMsj = "",sVoucher="";
            int nReg = 1, nRegTot = Data.Count;
            
            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = fnQuery.tsqVoucherAprob;

                    nReg = 1;
                    foreach (entVoucher objE in Data){
                        Cmd.Parameters.Clear();
                        Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = objE.Compania;
                        Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = objE.Periodo;
                        Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = objE.TipoVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = objE.NumeroVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = objE.UsuarioSys;
                        Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar, 250)).Value = "";
                        Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                        sVoucher = objE.TipoVoucher + "-" + objE.NumeroVoucher;

                        Cmd.ExecuteNonQuery();
                        sMsj = Cmd.Parameters["@Mensaje"].Value.ToString();
                        if (!sMsj.Equals("OK")){
                            entErr.Resultado = false;
                            entErr.Errores.Add(new entFail() { Codigo = "SQL", Descripcion = sVoucher + ": " +sMsj });
                            bOk = false;
                            break;
                        }
                        Int32 nPorc = (nReg * 100) / nRegTot;
                        String sStatus = nPorc.ToString();
                        worker.ReportProgress(nPorc, sStatus);
                        System.Threading.Thread.Sleep(25);
                        nReg++;
                    }

                    if (bOk){
                        Trs.Commit();
                        entErr.Resultado = true;
                    }else{
                        Trs.Rollback();
                    }
                }
                catch (Exception ex){
                    Trs.Rollback();
                    sMsj = ex.Message;
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = sVoucher + ": " + sMsj });
                }
                finally{
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                    nReg = Data.Count;
                    Data = null;
                }
            }
            return entErr;
        }

        public static entErrores PasarPendienteMasivo(List<entVoucher> Data, ref BackgroundWorker worker)
        {
            SqlCommand Cmd = new SqlCommand();
            entErrores entErr = new entErrores();
            Boolean bOk = true;
            String sMsj = "", sVoucher="";
            int nReg = 1, nRegTot = Data.Count;

            using (SqlConnection Cnx = new SqlConnection(Configuracion.getCadConexion())){
                SqlTransaction Trs = null;
                try{
                    Cmd.Connection = Cnx;
                    Cmd.Connection.Open();
                    Trs = Cnx.BeginTransaction();
                    Cmd.Transaction = Trs;
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = fnQuery.tsqVoucherPend;

                    nReg = 1;
                    foreach (entVoucher objE in Data){
                        Cmd.Parameters.Clear();
                        Cmd.Parameters.Add(new SqlParameter("@Compania", SqlDbType.VarChar)).Value = objE.Compania;
                        Cmd.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.VarChar)).Value = objE.Periodo;
                        Cmd.Parameters.Add(new SqlParameter("@TipoVoucher", SqlDbType.VarChar)).Value = objE.TipoVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@NumeroVoucher", SqlDbType.VarChar)).Value = objE.NumeroVoucher;
                        Cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = objE.UsuarioSys;
                        Cmd.Parameters.Add(new SqlParameter("@Mensaje", SqlDbType.VarChar, 250)).Value = "";
                        Cmd.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                        sVoucher = objE.TipoVoucher + "-" + objE.NumeroVoucher;

                        Cmd.ExecuteNonQuery();
                        sMsj = Cmd.Parameters["@Mensaje"].Value.ToString();
                        if (!sMsj.Equals("OK")){
                            entErr.Resultado = false;
                            entErr.Errores.Add(new entFail() { Codigo = "SQL", Descripcion = sVoucher + ": " + sMsj });
                            bOk = false;
                            break;
                        }
                        Int32 nPorc = (nReg * 100) / nRegTot;
                        String sStatus = nPorc.ToString();
                        worker.ReportProgress(nPorc, sStatus);
                        System.Threading.Thread.Sleep(25);
                        nReg++;
                    }

                    if (bOk){
                        Trs.Commit();
                        entErr.Resultado = true;
                    }else{
                        Trs.Rollback();
                    }
                }
                catch (Exception ex){
                    Trs.Rollback();
                    sMsj = ex.Message;
                    entErr.Errores.Add(new entFail() { Codigo = ex.GetHashCode().ToString(), Descripcion = sVoucher + ": " + sMsj });
                }
                finally{
                    Cmd.Connection.Close();
                    Cmd.Connection.Dispose();
                    Cnx.Close();
                    Cnx.Dispose();
                    Trs.Dispose();
                    GC.SuppressFinalize(Cnx);
                    nReg = Data.Count;
                    Data = null;
                }
            }
            return entErr;
        }

    }
}
