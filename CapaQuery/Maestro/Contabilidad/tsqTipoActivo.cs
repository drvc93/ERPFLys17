using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqTipoActivo
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_tipoactivo,c_descripcion,c_control,n_porcentaje,c_estado,c_ultimousuario,d_ultimafechamodificacion " +
                   "from ma_tipoactivo";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_tipoactivo,a.c_descripcion,a.c_control,a.n_porcentaje,a.c_estado,a.c_ultimousuario,a.d_ultimafechamodificacion, " +
                   "c_usernombreform = b.c_nombre " +
                   "from ma_tipoactivo a, ma_usuario b " +
                   "where a.c_ultimousuario *= b.c_codigousuario " +
                   "and a.c_tipoactivo = @TipoActivo ";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_tipoactivo,c_descripcion,c_estado " +
                   "from ma_tipoactivo " +
                   "where c_estado like @Estado";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_tipoactivo,c_descripcion,c_estado " +
                   "from ma_tipoactivo " +
                   "where c_tipoactivo like @TipoActivo " +
                   "and c_descripcion like @Descripcion " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_tipoactivo(" +
                           "c_tipoactivo,c_descripcion,c_control,n_porcentaje,c_estado,c_ultimousuario,d_ultimafechamodificacion) " +
                           "values(@TipoActivo,@Descripcion,@Control,@Porcentaje,@Estado,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_tipoactivo set " +
                           "c_descripcion = @Descripcion, " +
                           "c_control = @Control, " +
                           "n_porcentaje = @Porcentaje, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuario = @UltimoUsuario, " +
                           "d_ultimafechamodificacion = getdate() " +
                           "where c_tipoactivo = @TipoActivo ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_tipoactivo " +
                           "where c_tipoactivo = @TipoActivo ";
                    break;
            }
            return xsql;
        }

    }
}
