using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _2.Logica
{
    public class Negocio
    {

        protected SqlConnection conexion;
        protected SqlCommand comando;
        private SqlTransaction transaccion;

        protected void AbrirConexion()
        {
            string cadenaConexion = ConfigurationManager.AppSettings.Get("cadenaConexionBD");

            conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            comando = conexion.CreateCommand();
        }

        protected void CerrarConexion()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                    conexion.Dispose();
                    conexion = null;
                }
            }
            catch
            {
            }
        }

        protected void IniciarTransaccion()
        {
            AbrirConexion();

            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
        }

        protected void ConfirmarTransaccion()
        {
            if (transaccion != null)
            {
                transaccion.Commit();
                transaccion.Dispose();
                transaccion = null;
                CerrarConexion();
            }
        }

        protected void DeshacerTransaccion()
        {
            if (transaccion != null)
            {
                transaccion.Rollback();
                transaccion.Dispose();
                transaccion = null;
                CerrarConexion();
            }
        }
    }
}