﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Domain.Seguridad;
using FiltroLys.Model.Seguridad;
using FiltroLys.Type;
using DevExpress.XtraEditors;

namespace FiltroLys.ZLys.Funciones
{
    public class fnAcceso
    {
        List<Controles> ListObj = new List<Controles>();

        public void addControl(Controles obj){
            ListObj.Add(obj);
        }

        public void HabControl(String Usuario,String Aplicacion){
            if (ListObj == null || ListObj.Count == 0) { return; }
            List<entAccesoMenu> ListAcc = negAccesoMenu.ListaUsuarioApp(Usuario, Aplicacion);
            foreach(Controles objC in ListObj){
                entAccesoMenu oEnt = ListAcc.Where(x => x.Niveles.Equals(objC.Niveles)).FirstOrDefault();
                if(oEnt!=null){
                    switch(objC.AccesoOpcion)
                    {
                        case fnEnum.AccesoOpcion.Acceso:
                            objC.BtnOpcion.Enabled = (oEnt.Acceso.Equals("S")) ? true : false;
                            break;
                        case fnEnum.AccesoOpcion.Nuevo:
                            objC.BtnOpcion.Enabled = (oEnt.Nuevo.Equals("S")) ? true : false;
                            break;
                        case fnEnum.AccesoOpcion.Modificar:
                            objC.BtnOpcion.Enabled = (oEnt.Modificar.Equals("S")) ? true : false;
                            break;
                        case fnEnum.AccesoOpcion.Eliminar:
                            objC.BtnOpcion.Enabled = (oEnt.Eliminar.Equals("S")) ? true : false;
                            break;
                        case fnEnum.AccesoOpcion.Otros:
                            objC.BtnOpcion.Enabled = (oEnt.Otros.Equals("S")) ? true : false;
                            break;
                        case fnEnum.AccesoOpcion.NuevoOrEliminar:
                            objC.BtnOpcion.Enabled = (oEnt.Nuevo.Equals("S") || oEnt.Modificar.Equals("S")) ? true : false;
                            break;
                    }
                }
            }
            ListAcc = null;
        }

        public static Boolean ExisteAcceso(String Usuario, String Aplicacion, String Niveles, fnEnum.AccesoOpcion AccesoOpcion) {
            Boolean valor = false;
            entAccesoMenu oEnt = negAccesoMenu.GetFormID(Usuario, Aplicacion, Niveles);            
            if (oEnt.ResultadoBusqueda) {                
                switch (AccesoOpcion){
                    case fnEnum.AccesoOpcion.Acceso:
                        valor = (oEnt.Acceso.Equals("S")) ? true : false;
                        break;
                    case fnEnum.AccesoOpcion.Nuevo:
                        valor = (oEnt.Nuevo.Equals("S")) ? true : false;
                        break;
                    case fnEnum.AccesoOpcion.Modificar:
                        valor = (oEnt.Modificar.Equals("S")) ? true : false;
                        break;
                    case fnEnum.AccesoOpcion.Eliminar:
                        valor = (oEnt.Eliminar.Equals("S")) ? true : false;
                        break;
                    case fnEnum.AccesoOpcion.Otros:
                        valor = (oEnt.Otros.Equals("S")) ? true : false;
                        break;                   
                }
            }
            return valor;
        }

    }

    #region "EntControles"

    public class Controles{
        private SimpleButton btnOpcion;
        private String sNivel;
        private fnEnum.AccesoOpcion accesoOpcion;

        public Controles(SimpleButton xopc,String xsniv, fnEnum.AccesoOpcion xaccopc)
        {
            btnOpcion = xopc;
            sNivel = xsniv;
            accesoOpcion = xaccopc;
        }

        public SimpleButton BtnOpcion { get { return btnOpcion; } }
        public String Niveles{get{return sNivel;}}
        public fnEnum.AccesoOpcion AccesoOpcion{get{return accesoOpcion;}}
        
    }

    #endregion

}
