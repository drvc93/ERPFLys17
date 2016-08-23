using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Sistema
{
    public class entColumna
    {
        private String c_Nombre, c_IsNull, c_Tipo, c_Default, c_Propiedad;
        private String c_DefaultNet,c_TipoNetProp,c_TipoNetParam,c_AnchoSP,c_FlagNull,c_VB;
        private String c_PkId = "S", c_Sel = "N", c_Combo = "N", c_Search = "N";
        private int n_Posicion, n_QCaract, n_Precision, n_Scale;

        public String Nombre {
            get { return c_Nombre; }
            set { c_Nombre = value; }
        }

        public int Posicion
        {
            get { return n_Posicion; }
            set { n_Posicion = value; }
        }

        public String IsNull
        {
            get { return c_IsNull; }
            set { c_IsNull = value; }
        }

        public String Tipo
        {
            get { return c_Tipo; }
            set { c_Tipo = value; }
        }

        public int QCaract
        {
            get { return n_QCaract; }
            set { n_QCaract = value; }
        }

        public int Precision
        {
            get { return n_Precision; }
            set { n_Precision = value; }
        }

        public int Scale
        {
            get { return n_Scale; }
            set { n_Scale = value; }
        }

        public String Default
        {
            get { return c_Default; }
            set { c_Default = value; }
        }

        public String Propiedad
        {
            get { return c_Propiedad; }
            set { c_Propiedad = value; }
        }

        public String DefaultNet
        {
            get { return c_DefaultNet; }
            set { c_DefaultNet = value; }
        }

        public String TipoNetProp
        {
            get { return c_TipoNetProp; }
            set { c_TipoNetProp = value; }
        }

        public String TipoNetParam
        {
            get { return c_TipoNetParam; }
            set { c_TipoNetParam = value; }
        }

        public String AnchoSP
        {
            get { return c_AnchoSP; }
            set { c_AnchoSP = value; }
        }

        public String FlagNull
        {
            get { return c_FlagNull; }
            set { c_FlagNull = value; }
        }

        public String VB
        {
            get { return c_VB; }
            set { c_VB = value; }
        }

        public String PkId
        {
            get { return c_PkId; }
            set { c_PkId = value; }
        }

        public String Sel
        {
            get { return c_Sel; }
            set { c_Sel = value; }
        }

        public String Combo
        {
            get { return c_Combo; }
            set { c_Combo = value; }
        }

        public String Search
        {
            get { return c_Search; }
            set { c_Search = value; }
        }
        
    }
}
