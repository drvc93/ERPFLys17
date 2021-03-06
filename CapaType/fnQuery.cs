﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Type
{
    public static class fnQuery
    {
        public const String tsqCompania = "UP_MA_MANT_COMPANIA";
        public const String tsqPaises = "UP_MA_MANT_PAISES";
        public const String tsqDepartamento = "UP_MA_MANT_DEPARTAMENTO";
        public const String tsqProvincia = "UP_MA_MANT_PROVINCIA";
        public const String tsqDistrito = "UP_MA_MANT_DISTRITO";
        public const String tsqArea = "UP_MA_MANT_AREA";
        public const String tsqClasifCCosto = "UP_MA_MANT_CLASIFCCOSTO";
        public const String tsqCompaniaXUsu = "SP_MA_COMPANIA_ACCESO";
        public const String tsqTipoCuentaBalance = "UP_MA_MANT_TIPOCUENTABALANCE";
        public const String tsqClasifMayor = "UP_MA_MANT_CLASIFIMAYOR";
        public const String tsqCuentaMayor = "UP_MA_MANT_CUENTAMAYOR";
        public const String tsqCuentaMayor04 = "UP_MA_MANT_CUENTAMAYOR04DIG";
        public const String tsqCuentaMayor05 = "UP_MA_MANT_CUENTAMAYOR05DIG";
        public const String tsqCuentaContableRel = "UP_MA_MANT_CUENTACONTABLE_REL";
        public const String tsqSucursal = "UP_MA_MANT_SUCURSAL";
        public const String tsqDepartCia = "UP_MA_MANT_DEPARTAMENTOCIA";
        public const String tsqEmpleado = "UP_MA_MANT_EMPLEADO";
        public const String tsqGrupoElemGasto = "UP_MA_MANT_GRUPOELEMENTOGASTO";
        public const String tsqElemGasto = "UP_MA_MANT_ELEMENTOGASTO";
        public const String tsqTipoGasto = "UP_MA_MANT_TIPOGASTO";
        public const String tsqParametro = "UP_MA_MANT_PARAMETRO";
        public const String tsqPeriodoCierreCia = "UP_MA_MANT_PERIODOCIERRECIA";
        public const String tsqTipoPersonaUsu = "UP_MA_MANT_TIPOPERSONAUSUARIO";
        public const String tsqProyecto = "UP_MA_MANT_PROYECTO";
        public const String tsqRubroGasto = "UP_MA_MANT_RUBROGASTO";
        public const String tsqTipoActivo = "UP_MA_MANT_TIPOACTIVO";
        public const String tsqTipoCambio = "UP_MA_MANT_TIPOCAMBIO";
        public const String tsqTipoCambioPeriodo = "UP_MA_MANT_TIPOCAMBIOPERIODO";
        public const String tsqTipoPago = "UP_MA_MANT_TIPOPAGO";
        public const String tsqRegimenFiscal = "UP_MA_MANT_REGIMENFISCAL";
        public const String tsqTipoServicio = "UP_MA_MANT_TIPOSERVICIO";
        public const String tsqTipoVoucher = "UP_MA_MANT_TIPOVOUCHER";
        public const String tsqGrupoCCosto = "UP_MA_MANT_GRUPOCCOSTO";
        public const String tsqClasifGCCosto = "UP_MA_MANT_CLASIFIGCCOSTO";
        public const String tsqCargo = "UP_MA_MANT_CARGO";
        public const String tsqUsuario = "UP_MA_MANT_USUARIO";
        public const String tsqCentroCosto = "UP_MA_MANT_CENTROCOSTO";
        public const String tsqCorrVoucher = "UP_MA_MANT_CORRELATIVOVOUCHER";
        public const String tsqCorrVoucherGet = "SP_CB_GETULTIMOCORRELATIVO";
        public const String tsqCorrVoucherSet = "SP_CB_SETULTIMOCORRELATIVO";
        public const String tsqLineaProducto = "UP_MA_MANT_LINEAPRODUCTO";
        public const String tsqFlujoCajaCB = "UP_MA_MANT_FLUJOCAJACB";
        public const String tsqRubroCtaContable = "UP_MA_MANT_RUBROCTACONTABLE";
        public const String tsqCliente = "UP_MA_MANT_CLIENTE";
        public const String tsqPersona = "UP_MA_MANT_PERSONA";
        public const String tsqProveedor = "UP_MA_MANT_PROVEEDOR";
        public const String tsqFechaServidor = "USP_FECHASERVIDOR";
        public const String tsqAuditoria = "UP_MA_MANT_AUDITORIA";
        public const String tsqCuentaContable = "UP_MA_MANT_CUENTACONTABLE";
        public const String tsqCompCContable = "UP_MA_MANT_COMPCCONTABLE";
        public const String tsqAsientoModelo = "UP_MA_MANT_ASIENTOMODELO";
        public const String tsqAsientoModeloDet = "UP_MA_MANT_ASIENTOMODELODET";
        public const String tsqVoucher = "UP_MA_MANT_VOUCHER";
        public const String tsqVoucherDet = "UP_MA_MANT_VOUCHERDET";
        public const String tsqVoucherAprob = "SP_CB_VOUCHER_APROBACION";
        public const String tsqVoucherPend = "SP_CB_VOUCHER_PENDIENTE";
        public const String tsqMaquina = "UP_MA_MANT_MAQUINA";
        public const String tsqObligacion = "UP_TR_MANT_OBLIGACION";
        public const String tsqOrdenesCompra = "UP_LO_MANT_ORDENCOMPRA";
        public const String tsqOrdenesCompraDet = "UP_LO_MANT_ORDENCOMPRADET";
        public const String tsqCierreMensualCB = "UP_CB_MANT_CIERREMENSUAL";
        public const String tsqSaldoContableMay = "SP_SALDO_CONTABLE_MAYOR";
        public const String tsqSaldoContableCta = "SP_SALDO_CONTABLE_MAYOR1";
        public const String tsqCierreMensualRevision = "SP_CB_CIERREMENSUAL_REVISION";
        public const String tsqCierreMensualProcesar = "SP_CB_CIERREMENSUAL_CUENTA";
        public const String tsqPeriodoSiguienteCB = "SP_CB_PERIODOSIGUIENTE";
        public const String tsqMenuSys = "UP_SYS_MANT_MENUS";
        public const String tsqAccesoMenuSys = "UP_SYS_MANT_ACCESOMENU";
        public const String tsqAccesoModuloSys = "UP_SYS_MANT_ACCESOMODULO";
        public const String tsqAccesoListMaestroSys = "UP_SYS_LIST_ACCESOMENUMAESTRONET";
        public const String tsqReporteSys = "UP_SYS_MANT_REPORTE";
        public const String tsqAccesoReporteSys = "UP_SYS_MANT_ACCESOREPORTE";
        public const String tsqAccesoListReporteSys = "UP_SYS_LIST_ACCESOREPORTENET";
        public const String tsqSchemaBDSys = "UP_SYS_LIST_ESQUEMABD";

    }
}
