using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Sistema
{   
	public class entMenu : entBase 
	{
		 private String c_AplicacionCodigo, c_NombreMenu, c_Descripcion, c_ObjetoPrincipal, c_ObjetosLlamados, c_UltimoUsuario;
		 private int n_Nivel1, n_Nivel2, n_Nivel3, n_Nivel4, n_Nivel5;
		 private DateTime d_UltimaFechaModificacion;

		 public String AplicacionCodigo{
			 get { return c_AplicacionCodigo;}
			 set { c_AplicacionCodigo= value;}
		 }

		 public Int32 Nivel1{
			 get { return n_Nivel1;}
			 set { n_Nivel1= value;}
		 }

		 public Int32 Nivel2{
			 get { return n_Nivel2;}
			 set { n_Nivel2= value;}
		 }

		 public Int32 Nivel3{
			 get { return n_Nivel3;}
			 set { n_Nivel3= value;}
		 }

		 public Int32 Nivel4{
			 get { return n_Nivel4;}
			 set { n_Nivel4= value;}
		 }

		 public Int32 Nivel5{
			 get { return n_Nivel5;}
			 set { n_Nivel5= value;}
		 }

		 public String NombreMenu{
			 get { return c_NombreMenu;}
			 set { c_NombreMenu= value;}
		 }

		 public String Descripcion{
			 get { return c_Descripcion;}
			 set { c_Descripcion= value;}
		 }

		 public String ObjetoPrincipal{
			 get { return c_ObjetoPrincipal;}
			 set { c_ObjetoPrincipal= value;}
		 }

		 public String ObjetosLlamados{
			 get { return c_ObjetosLlamados;}
			 set { c_ObjetosLlamados= value;}
		 }

		 public String UltimoUsuario{
			 get { return c_UltimoUsuario;}
			 set { c_UltimoUsuario= value;}
		 }

		 public DateTime UltimaFechaModificacion{
			 get { return d_UltimaFechaModificacion;}
			 set { d_UltimaFechaModificacion= value;}
		 }

	 }
}

