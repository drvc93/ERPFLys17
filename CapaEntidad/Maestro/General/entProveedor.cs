using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entProveedor : entBase
    {
        private String c_Compania, c_TipoPersona, c_ApellidosPaterno, c_ApellidosMaterno, c_Nombres, c_RazonSocial, c_NombreBusqueda, c_DocumentoFiscal;
        private String c_Mail, c_Direccion, c_Pais, c_DepartamentoCodigo, c_ProvinciaCodigo, c_DistritoCodigo, c_ModalidadCodigo, c_TipoEmpresa, c_RepresentanteLegal;
        private String c_DocumentoRepresentante, c_Contacto, c_DocumentoContacto, c_Observaciones, c_Carta = "N", c_FichaInscripcion = "N";
        private String c_LicenciaFuncionamiento = "N", c_FormularioRuc = "N", c_Categoria = "C", c_Critico = "C", c_MotivoInactivacion, c_LineaComercializacion;
        private String c_Procedencia = "N", c_Estado = "A", c_UltimoUsuario, c_TipoDocumento, c_Impuesto, c_MonedaPago, c_CriticoServicio = "N", c_TipoDocumentoOB;
        private String c_FlagTrigger = "S", c_Agente = "N", c_CuentaDetraccion, c_Unico = "N", c_CriticoFinanzas = "N", c_TipoDoc_Sunat, c_ProveedorLogistico = "N";
        private String c_ProveedorLogisticoServicio = "N", c_IncotermCodigo, c_TipoPension, c_CodigoAfp, c_NumeroAfp, c_RutaDni, c_AfpVariableMixta = "N", c_NumeroDni;
        private String c_FlagAgenteRet = "N", c_FlagBuenContrib = "N", c_FlagAgentePer = "N", c_FlagValidoRet = "N", c_UsuarioValidoRet, c_FlagTipoAmpRet = "A";
        private String c_FlagNoHabido = "N", c_FlagNoHallado = "N", c_UsuarioActNoHabido, c_UsuarioActNoHallado;
        private int n_Proveedor, n_UltimaVisita = 0, n_DiasPrevioEmbarque = 0;
        private Decimal n_FactorReposicion = 0, n_PorcentajeAbono, n_PorcentajeGanancia;
        private DateTime d_FechaNacimiento, d_FechaInscripcion, d_UltimaFechaModificacion = DateTime.Now, d_FechaInicioVigencia, d_FechaFinVigencia;
        private DateTime d_FechaIngresoPension, d_FechaValidoRet, d_FechaNoHabido, d_FechaActNoHabido, d_FechaActNoHallado;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public Int32 Proveedor
        {
            get { return n_Proveedor; }
            set { n_Proveedor = value; }
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

        public String DocumentoFiscal
        {
            get { return c_DocumentoFiscal; }
            set { c_DocumentoFiscal = value; }
        }

        public String Mail
        {
            get { return c_Mail; }
            set { c_Mail = value; }
        }

        public String Direccion
        {
            get { return c_Direccion; }
            set { c_Direccion = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return d_FechaNacimiento; }
            set { d_FechaNacimiento = value; }
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

        public String ModalidadCodigo
        {
            get { return c_ModalidadCodigo; }
            set { c_ModalidadCodigo = value; }
        }

        public String TipoEmpresa
        {
            get { return c_TipoEmpresa; }
            set { c_TipoEmpresa = value; }
        }

        public String RepresentanteLegal
        {
            get { return c_RepresentanteLegal; }
            set { c_RepresentanteLegal = value; }
        }

        public String DocumentoRepresentante
        {
            get { return c_DocumentoRepresentante; }
            set { c_DocumentoRepresentante = value; }
        }

        public String Contacto
        {
            get { return c_Contacto; }
            set { c_Contacto = value; }
        }

        public String DocumentoContacto
        {
            get { return c_DocumentoContacto; }
            set { c_DocumentoContacto = value; }
        }

        public String Observaciones
        {
            get { return c_Observaciones; }
            set { c_Observaciones = value; }
        }

        public DateTime FechaInscripcion
        {
            get { return d_FechaInscripcion; }
            set { d_FechaInscripcion = value; }
        }

        public String Carta
        {
            get { return c_Carta; }
            set { c_Carta = value; }
        }

        public String FichaInscripcion
        {
            get { return c_FichaInscripcion; }
            set { c_FichaInscripcion = value; }
        }

        public String LicenciaFuncionamiento
        {
            get { return c_LicenciaFuncionamiento; }
            set { c_LicenciaFuncionamiento = value; }
        }

        public String FormularioRuc
        {
            get { return c_FormularioRuc; }
            set { c_FormularioRuc = value; }
        }

        public Int32 UltimaVisita
        {
            get { return n_UltimaVisita; }
            set { n_UltimaVisita = value; }
        }

        public String Categoria
        {
            get { return c_Categoria; }
            set { c_Categoria = value; }
        }

        public String Critico
        {
            get { return c_Critico; }
            set { c_Critico = value; }
        }

        public String MotivoInactivacion
        {
            get { return c_MotivoInactivacion; }
            set { c_MotivoInactivacion = value; }
        }

        public String LineaComercializacion
        {
            get { return c_LineaComercializacion; }
            set { c_LineaComercializacion = value; }
        }

        public String Procedencia
        {
            get { return c_Procedencia; }
            set { c_Procedencia = value; }
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

        public String TipoDocumento
        {
            get { return c_TipoDocumento; }
            set { c_TipoDocumento = value; }
        }

        public String Impuesto
        {
            get { return c_Impuesto; }
            set { c_Impuesto = value; }
        }

        public DateTime FechaInicioVigencia
        {
            get { return d_FechaInicioVigencia; }
            set { d_FechaInicioVigencia = value; }
        }

        public DateTime FechaFinVigencia
        {
            get { return d_FechaFinVigencia; }
            set { d_FechaFinVigencia = value; }
        }

        public String MonedaPago
        {
            get { return c_MonedaPago; }
            set { c_MonedaPago = value; }
        }

        public String CriticoServicio
        {
            get { return c_CriticoServicio; }
            set { c_CriticoServicio = value; }
        }

        public String TipoDocumentoOB
        {
            get { return c_TipoDocumentoOB; }
            set { c_TipoDocumentoOB = value; }
        }

        public String FlagTrigger
        {
            get { return c_FlagTrigger; }
            set { c_FlagTrigger = value; }
        }

        public String Agente
        {
            get { return c_Agente; }
            set { c_Agente = value; }
        }

        public Decimal FactorReposicion
        {
            get { return n_FactorReposicion; }
            set { n_FactorReposicion = value; }
        }

        public String CuentaDetraccion
        {
            get { return c_CuentaDetraccion; }
            set { c_CuentaDetraccion = value; }
        }

        public Decimal PorcentajeAbono
        {
            get { return n_PorcentajeAbono; }
            set { n_PorcentajeAbono = value; }
        }

        public Decimal PorcentajeGanancia
        {
            get { return n_PorcentajeGanancia; }
            set { n_PorcentajeGanancia = value; }
        }

        public String Unico
        {
            get { return c_Unico; }
            set { c_Unico = value; }
        }

        public String CriticoFinanzas
        {
            get { return c_CriticoFinanzas; }
            set { c_CriticoFinanzas = value; }
        }

        public String TipoDoc_Sunat
        {
            get { return c_TipoDoc_Sunat; }
            set { c_TipoDoc_Sunat = value; }
        }

        public Int32 DiasPrevioEmbarque
        {
            get { return n_DiasPrevioEmbarque; }
            set { n_DiasPrevioEmbarque = value; }
        }

        public String ProveedorLogistico
        {
            get { return c_ProveedorLogistico; }
            set { c_ProveedorLogistico = value; }
        }

        public String ProveedorLogisticoServicio
        {
            get { return c_ProveedorLogisticoServicio; }
            set { c_ProveedorLogisticoServicio = value; }
        }

        public String IncotermCodigo
        {
            get { return c_IncotermCodigo; }
            set { c_IncotermCodigo = value; }
        }

        public String TipoPension
        {
            get { return c_TipoPension; }
            set { c_TipoPension = value; }
        }

        public String CodigoAfp
        {
            get { return c_CodigoAfp; }
            set { c_CodigoAfp = value; }
        }

        public String NumeroAfp
        {
            get { return c_NumeroAfp; }
            set { c_NumeroAfp = value; }
        }

        public String RutaDni
        {
            get { return c_RutaDni; }
            set { c_RutaDni = value; }
        }

        public String AfpVariableMixta
        {
            get { return c_AfpVariableMixta; }
            set { c_AfpVariableMixta = value; }
        }

        public DateTime FechaIngresoPension
        {
            get { return d_FechaIngresoPension; }
            set { d_FechaIngresoPension = value; }
        }

        public String NumeroDni
        {
            get { return c_NumeroDni; }
            set { c_NumeroDni = value; }
        }

        public String FlagAgenteRet
        {
            get { return c_FlagAgenteRet; }
            set { c_FlagAgenteRet = value; }
        }

        public String FlagBuenContrib
        {
            get { return c_FlagBuenContrib; }
            set { c_FlagBuenContrib = value; }
        }

        public String FlagAgentePer
        {
            get { return c_FlagAgentePer; }
            set { c_FlagAgentePer = value; }
        }

        public String FlagValidoRet
        {
            get { return c_FlagValidoRet; }
            set { c_FlagValidoRet = value; }
        }

        public String UsuarioValidoRet
        {
            get { return c_UsuarioValidoRet; }
            set { c_UsuarioValidoRet = value; }
        }

        public DateTime FechaValidoRet
        {
            get { return d_FechaValidoRet; }
            set { d_FechaValidoRet = value; }
        }

        public String FlagTipoAmpRet
        {
            get { return c_FlagTipoAmpRet; }
            set { c_FlagTipoAmpRet = value; }
        }

        public String FlagNoHabido
        {
            get { return c_FlagNoHabido; }
            set { c_FlagNoHabido = value; }
        }

        public String FlagNoHallado
        {
            get { return c_FlagNoHallado; }
            set { c_FlagNoHallado = value; }
        }

        public DateTime FechaNoHabido
        {
            get { return d_FechaNoHabido; }
            set { d_FechaNoHabido = value; }
        }

        public String UsuarioActNoHabido
        {
            get { return c_UsuarioActNoHabido; }
            set { c_UsuarioActNoHabido = value; }
        }

        public DateTime FechaActNoHabido
        {
            get { return d_FechaActNoHabido; }
            set { d_FechaActNoHabido = value; }
        }

        public String UsuarioActNoHallado
        {
            get { return c_UsuarioActNoHallado; }
            set { c_UsuarioActNoHallado = value; }
        }

        public DateTime FechaActNoHallado
        {
            get { return d_FechaActNoHallado; }
            set { d_FechaActNoHallado = value; }
        }

    }
}