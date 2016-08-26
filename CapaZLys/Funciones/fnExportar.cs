using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiltroLys.Type;
using System.Data;
using System.IO;
using FiltroLys.Domain.Sistema;

namespace FiltroLys.ZLys.Funciones
{
    public class fnExportar
    {
        public static Int32 CreateXLSFile(DataTable Tabla, String RutaGuardar, Boolean ConCabecera = true){
            StreamWriter sWFile = null;
            Int32 nCols,nReturn = 1;

            if(Tabla==null){ return -1;}
            if(Tabla.Rows.Count==0){ return 0;}

            nCols = Tabla.Columns.Count;
            sWFile = new StreamWriter(RutaGuardar, false, Encoding.Unicode);
            
            if(ConCabecera){
                for (int i = 0; i < nCols; i++){
                    sWFile.Write(Tabla.Columns[i]);
                    if (i < nCols - 1) { sWFile.Write("\t"); }
                }
                sWFile.Write(sWFile.NewLine);
            }

            foreach (DataRow dr in Tabla.Rows){
                for (int i = 0; i < nCols; i++){
                    if (!Convert.IsDBNull(dr[i])){
                        sWFile.Write(dr[i].ToString());
                    }
                    if (i < nCols - 1) { sWFile.Write("\t"); }
                }
                sWFile.Write(sWFile.NewLine);
            }
            sWFile.Close();            
            return nReturn;
        }

        public static Int32 CreateTXTFile(DataTable Tabla, String RutaGuardar, Boolean ConCabecera = true){
            StreamWriter sWFile = null;
            Int32 nCols,nReturn = 1;

            if(Tabla==null){ return -1;}
            if(Tabla.Rows.Count==0){ return 0;}

            nCols = Tabla.Columns.Count;
            sWFile = new StreamWriter(RutaGuardar, false, Encoding.Unicode);
            
            if(ConCabecera){
                for (int i = 0; i < nCols; i++){
                    sWFile.Write(Tabla.Columns[i]);
                    if (i < nCols - 1) { sWFile.Write("\t"); }
                }
                sWFile.Write(sWFile.NewLine);
            }

            foreach (DataRow dr in Tabla.Rows){
                for (int i = 0; i < nCols; i++){
                    if (!Convert.IsDBNull(dr[i])){
                        sWFile.Write(dr[i].ToString());
                    }
                    if (i < nCols - 1) { sWFile.Write("\t"); }
                }
                sWFile.Write(sWFile.NewLine);
            }
            sWFile.Close();            
            return nReturn;
        }

        public static Int32 CreateXLSFile(String Query, String RutaGuardar, Boolean ConCabecera = true)
        {
            return CreateXLSFile(negBaseDatos.ListaDatosOfStoreProc(Query), RutaGuardar, ConCabecera);
        }

        public static Int32 CreateTXTFile(String Query, String RutaGuardar, Boolean ConCabecera = true)
        {
            return CreateTXTFile(negBaseDatos.ListaDatosOfStoreProc(Query), RutaGuardar, ConCabecera);
        }

        public static String MensajeError(Int32 CodError,fnEnum.TipoArchivo oTipoArchivo = fnEnum.TipoArchivo.XLS) {
            String sErr = "";
            switch (CodError) { 
                case 0:
                    sErr = "No existen registros a exportar, verificar.";
                    break;                
            }
            return sErr;
        }

    }
}
