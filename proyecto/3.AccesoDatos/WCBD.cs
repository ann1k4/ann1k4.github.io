using _4.Modulo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _3.AccesoDatos
{
    public class WCBD
    {
        public List<WC> Consultar(SqlCommand comando)
        {
            try
            {
                string sp = "SelectCountries"; 

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = sp;
                comando.Parameters.Clear();

                IDbDataAdapter da = new SqlDataAdapter((SqlCommand)comando);
                DataSet ds = new DataSet();
                da.Fill(ds); 

                DataTable dt = ds.Tables[0]; 
                List<WC> lista = new List<WC>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    WC obj = new WC();
                    obj.country = dt.Rows[i][0].ToString();
                    obj.ranking = Convert.ToInt32(dt.Rows[i][1]);
                   
                 
                    lista.Add(obj);
                }

                return lista;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }


        public List<WC> Round2data(SqlCommand comando)
        {
            try
            {
                string sp = "DataRound2"; 

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = sp;
                comando.Parameters.Clear();

                IDbDataAdapter da = new SqlDataAdapter((SqlCommand)comando);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataTable dt = ds.Tables[0]; 
                List<WC> lista = new List<WC>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    WC obj = new WC();
                    obj.country = dt.Rows[i][0].ToString();
                    obj.ranking = Convert.ToInt32(dt.Rows[i][1]);


                    lista.Add(obj);
                }

                return lista;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }


        public void AddData(SqlCommand comando, WC obj)
        {
            try
            {
                string sp = "[AddDataRound1]"; 

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = sp;
                comando.Parameters.Clear();

                comando.Parameters.Add(new SqlParameter("@country", SqlDbType.VarChar));
                comando.Parameters.Add(new SqlParameter("@matches", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@win", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@lost", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@ranking", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@newranking", SqlDbType.Int));

                comando.Parameters[0].Value = obj.country;
                comando.Parameters[1].Value = obj.matches;
                comando.Parameters[2].Value = obj.win;
                comando.Parameters[3].Value = obj.lost;
                comando.Parameters[4].Value = obj.ranking;
                comando.Parameters[5].Value = obj.newranking;



                comando.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }



        public void AddDataRound2(SqlCommand comando, WC obj)
        {
            try
            {
                string sp = "[AddDataRound2]";

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = sp;
                comando.Parameters.Clear();

                
                comando.Parameters.Add(new SqlParameter("@matches", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@win", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@lost", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@ranking", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@newranking", SqlDbType.Int));
                comando.Parameters.Add(new SqlParameter("@country", SqlDbType.VarChar));

                
                comando.Parameters[0].Value = obj.matches;
                comando.Parameters[1].Value = obj.win;
                comando.Parameters[2].Value = obj.lost;
                comando.Parameters[3].Value = obj.ranking;
                comando.Parameters[4].Value = obj.newranking;
                comando.Parameters[5].Value = obj.country;


                comando.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void DeleteData(SqlCommand comando)
        {
            try
            {
                string sp = "[deletedata]";

                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = sp;
               


                comando.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

    }
}