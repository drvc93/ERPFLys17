using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entCliente : entBase
    {
        private String c_Compania, c_TipoPersona, c_ApellidosPaterno, c_ApellidosMaterno, c_Nombres, c_RazonSocial, c_NombreBusqueda, c_TipoDocumentoPersona;
        private String c_Documento, c_DocumentoFiscal, c_DocumentoIdentidad, c_CarnetExtranjeria, c_Pasaporte, c_Nacionalidad, c_DireccionFiscal, c_Pais;
        private String c_DepartamentoCodigo, c_ProvinciaCodigo, c_DistritoCodigo, c_Mail, c_EstadoRuteo = "A", c_EstadoCobranza = "A", c_CategoriaVentas;
        private String c_CategoriaCobranzas = "NO", c_UnidadNegocio, c_TipoNegocio, c_CanalDistribucion, c_TipoVenta, c_TipoDespacho, c_Estado = "A";
        private String c_UltimoUsuario, c_GestionCobranza = "N", c_Puerto, c_ReqFactImpGuia = "N", c_AgenteRetencion = "N", c_Provincia = "N", c_Reintegro = "N";
        private String c_FlagTrigger = "S", c_Motivo_Inactivar_Ruteo, c_FlagVinculado = "N", c_FlagTipoEmisionDoc = "FA", c_CompaniaAplicacion;
        private String c_TipoCliente = "NO", c_SituacionCli = "PM", c_FlagVentaConfComp = "N";
        private int n_Cliente, n_ClienteAnterior, n_CorrelMobirut, n_EncuestaMob;
        private Decimal n_IngresoMensual = 0, n_CuotaVenta = 0, n_Latitud = 0, n_Longitud = 0;
        private DateTime d_FechaInicioOperaciones, d_FechaRegistro = DateTime.Now, d_UltimaFechaModificacion, d_Fecha_Inact_Ruteo;
        private String c_CompaniaNombre, c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public Int32 Cliente
        {
            get { return n_Cliente; }
            set { n_Cliente = value; }
        }

        public String TipoPersona
        {
            get { return c_TipoPersona; }
            set { c_TipoPersona = value; }
        }

        public String ApellidosPaterno
        {
            get { return c_ApellidosPaterno; }
            set { c_ApellidosPaterno = value; }
        }

        public String ApellidosMaterno
        {
            get { return c_ApellidosMaterno; }
            set { c_ApellidosMaterno = value; }
        }

        public String Nombres
        {
            get { return c_Nombres; }
            set { c_Nombres = value; }
        }

        public String RazonSocial
        {
            get { return c_RazonSocial; }
            set { c_RazonSocial = value; }
        }

        public String NombreBusqueda
        {
            get { return c_NombreBusqueda; }
            set { c_NombreBusqueda = value; }
        }

        public String TipoDocumentoPersona
        {
            get { return c_TipoDocumentoPersona; }
            set { c_TipoDocumentoPersona = value; }
        }

        public String Documento
        {
            get { return c_Documento; }
            set { c_Documento = value; }
        }

        public String DocumentoFiscal
        {
            get { return c_DocumentoFiscal; }
            set { c_DocumentoFiscal = value; }
        }

        public String DocumentoIdentidad
        {
            get { return c_DocumentoIdentidad; }
            set { c_DocumentoIdentidad = value; }
        }

        public String CarnetExtranjeria
        {
            get { return c_CarnetExtranjeria; }
            set { c_CarnetExtranjeria = value; }
        }

        public String Pasaporte
        {
            get { return c_Pasaporte; }
            set { c_Pasaporte = value; }
        }

        public DateTime FechaInicioOperaciones
        {
            get { return d_FechaInicioOperaciones; }
            set { d_FechaInicioOperaciones = value; }
        }

        public String Nacionalidad
        {
            get { return c_Nacionalidad; }
            set { c_Nacionalidad = value; }
        }

        public String DireccionFiscal
        {
            get { return c_DireccionFiscal; }
            set { c_DireccionFiscal = value; }
        }

        public String Pais
        {
            get { return c_Pais; }
            set { c_Pais = value; }
        }

        public String DepartamentoCodigo
        {
            get { return c_DepartamentoCodigo; }
            set { c_DepartamentoCodigo = value; }
        }

        public String ProvinciaCodigo
        {
            get { return c_ProvinciaCodigo; }
            set { c_ProvinciaCodigo = value; }
        }

        public String DistritoCodigo
        {
            get { return c_DistritoCodigo; }
            set { c_DistritoCodigo = value; }
        }

        public String Mail
        {
            get { return c_Mail; }
            set { c_Mail = value; }
        }

        public Int32 ClienteAnterior
        {
            get { return n_ClienteAnterior; }
            set { n_ClienteAnterior = value; }
        }

        public String EstadoRuteo
        {
            get { return c_EstadoRuteo; }
            set { c_EstadoRuteo = value; }
        }

        public String EstadoCobranza
        {
            get { return c_EstadoCobranza; }
            set { c_EstadoCobranza = value; }
        }

        public String CategoriaVentas
        {
            get { return c_CategoriaVentas; }
            set { c_CategoriaVentas = value; }
        }

        public String CategoriaCobranzas
        {
            get { return c_CategoriaCobranzas; }
            set { c_CategoriaCobranzas = value; }
        }

        public String UnidadNegocio
        {
            get { return c_UnidadNegocio; }
            set { c_UnidadNegocio = value; }
        }

        public String TipoNegocio
        {
            get { return c_TipoNegocio; }
            set { c_TipoNegocio = value; }
        }

        public String CanalDistribucion
        {
            get { return c_CanalDistribucion; }
            set { c_CanalDistribucion = value; }
        }

        public Decimal IngresoMensual
        {
            get { return n_IngresoMensual; }
            set { n_IngresoMensual = value; }
        }

        public String TipoVenta
        {
            get { return c_TipoVenta; }
            set { c_TipoVenta = value; }
        }

        public DateTime FechaRegistro
        {
            get { return d_FechaRegistro; }
            set { d_FechaRegistro = value; }
        }

        public String TipoDespacho
        {
            get { return c_TipoDespacho; }
            set { c_TipoDespacho = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String UltimoUsuario
        {
            get { return c_UltimoUsuario; }
            set { c_UltimoUsuario = value; }
        }

        public DateTime UltimaFechaModificacion
        {
            get { return d_UltimaFechaModificacion; }
            set { d_UltimaFechaModificacion = value; }
        }

        public String GestionCobranza
        {
            get { return c_GestionCobranza; }
            set { c_GestionCobranza = value; }
        }

        public String Puerto
        {
            get { return c_Puerto; }
            set { c_Puerto = value; }
        }

        public String ReqFactImpGuia
        {
            get { return c_ReqFactImpGuia; }
            set { c_ReqFactImpGuia = value; }
        }

        public String AgenteRetencion
        {
            get { return c_AgenteRetencion; }
            set { c_AgenteRetencion = value; }
        }

        public String Provincia
        {
            get { return c_Provincia; }
            set { c_Provincia = value; }
        }

        public String Reintegro
        {
            get { return c_Reintegro; }
            set { c_Reintegro = value; }
        }

        public Decimal CuotaVenta
        {
            get { return n_CuotaVenta; }
            set { n_CuotaVenta = value; }
        }

        public String FlagTrigger
        {
            get { return c_FlagTrigger; }
            set { c_FlagTrigger = value; }
        }

        public String Motivo_Inactivar_Ruteo
        {
            get { return c_Motivo_Inactivar_Ruteo; }
            set { c_Motivo_Inactivar_Ruteo = value; }
        }

        public DateTime Fecha_Inact_Ruteo
        {
            get { return d_Fecha_Inact_Ruteo; }
            set { d_Fecha_Inact_Ruteo = value; }
        }

        public String FlagVinculado
        {
            get { return c_FlagVinculado; }
            set { c_FlagVinculado = value; }
        }

        public String FlagTipoEmisionDoc
        {
            get { return c_FlagTipoEmisionDoc; }
            set { c_FlagTipoEmisionDoc = value; }
        }

        public String CompaniaAplicacion
        {
            get { return c_CompaniaAplicacion; }
            set { c_CompaniaAplicacion = value; }
        }

        public String TipoCliente
        {
            get { return c_TipoCliente; }
            set { c_TipoCliente = value; }
        }

        public String SituacionCli
        {
            get { return c_SituacionCli; }
            set { c_SituacionCli = value; }
        }

        public String FlagVentaConfComp
        {
            get { return c_FlagVentaConfComp; }
            set { c_FlagVentaConfComp = value; }
        }

        public Int32 CorrelMobirut
        {
            get { return n_CorrelMobirut; }
            set { n_CorrelMobirut = value; }
        }

        public Int32 EncuestaMob
        {
            get { return n_EncuestaMob; }
            set { n_EncuestaMob = value; }
        }

        public Decimal Latitud
        {
            get { return n_Latitud; }
            set { n_Latitud = value; }
        }

        public Decimal Longitud
        {
            get { return n_Longitud; }
            set { n_Longitud = value; }
        }

        public String CompaniaNombre
        {
            get { return c_CompaniaNombre; }
            set { c_CompaniaNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}