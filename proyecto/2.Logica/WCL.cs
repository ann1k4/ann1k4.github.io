using _3.AccesoDatos;
using _4.Modulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2.Logica
{
    public class WCL:Negocio
    {

        public List<WC> Consultar()//método y usar el resolve para referencias
        {
            try
            {
                this.AbrirConexion(); //abre conexion

                WCBD objBD = new WCBD();

                List<WC> lista = objBD.Consultar(this.comando);

                this.CerrarConexion(); //cierra la conexion

                return lista;

            }
            catch (Exception exc)//en caso de error a nivel de logica lo manda para arriba
            {
                this.CerrarConexion();//importante no omitir este
                throw exc;
            }
        }


        public List<WC> DataRound2()//método y usar el resolve para referencias
        {
            try
            {
                this.AbrirConexion(); //abre conexion

                WCBD objBD = new WCBD();

                List<WC> lista = objBD.Round2data(this.comando);

                this.CerrarConexion(); //cierra la conexion

                return lista;

            }
            catch (Exception exc)//en caso de error a nivel de logica lo manda para arriba
            {
                this.CerrarConexion();//importante no omitir este
                throw exc;
            }
        }

        public void AddDataRound1(WC obj)
        {
            try
            {
                this.IniciarTransaccion();

                WCBD objBD = new WCBD();



                objBD.AddData(this.comando, obj);

                this.ConfirmarTransaccion();
            }
            catch (Exception exc)
            {
                this.DeshacerTransaccion();
                throw exc;
            }
        }

        public void AddDataRound2(WC obj)
        {
            try
            {
                this.IniciarTransaccion();

                WCBD objBD = new WCBD();



                objBD.AddDataRound2(this.comando, obj);

                this.ConfirmarTransaccion();
            }
            catch (Exception exc)
            {
                this.DeshacerTransaccion();
                throw exc;
            }
        }

        public void DeleteData()
        {
            try
            {
                this.IniciarTransaccion();

                WCBD objBD = new WCBD();



                objBD.DeleteData(this.comando );

                this.ConfirmarTransaccion();
            }
            catch (Exception exc)
            {
                this.DeshacerTransaccion();
                throw exc;
            }
        }
        
    }
}