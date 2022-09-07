using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using transporteCargas.models;
using System.Data.SqlClient;

namespace transporteCargas.datos
{
    class helperDb
    {
        private SqlConnection cnn;
        private static string stringConnection = @"Data Source = DESKTOP-UKHHIVP\SQLEXPRESS; Initial Catalog = transporteCargas; Integrated Security = True";

        public helperDb()
        {
            cnn = new SqlConnection(stringConnection);
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        public bool confirmarCamion(Camion oCamion)
        {
            bool ok = true;
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "dbo.SP_INSERTAR_CAMIONN";
                cmd.CommandType = CommandType.StoredProcedure;
                //foreach (Parametro oParametro in values)
                //{
                //    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                //}
                cmd.Parameters.AddWithValue("@patente", oCamion.patente);
                cmd.Parameters.AddWithValue("@estado",  oCamion.idEstado);
                cmd.Parameters.AddWithValue("@pesoMax", oCamion.pesoMax);
                //parámetro de salida:
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                
                int idCamion = (int)pOut.Value;

                SqlCommand cmdCarga;
                int CargaNro = 1;
                foreach (Carga carga in oCamion.cargas)
                {
                    cmdCarga= new SqlCommand("dbo.SP_INSERTAR_CARGA", cnn,t);
                    cmdCarga.CommandType = CommandType.StoredProcedure;
                    cmdCarga.Parameters.AddWithValue("@id", CargaNro);
                    cmdCarga.Parameters.AddWithValue("@idCamion", idCamion);
                    cmdCarga.Parameters.AddWithValue("@peso", carga.peso);
                    cmdCarga.Parameters.AddWithValue("@idTipoCarga", carga.idTipo);
                    cmdCarga.ExecuteNonQuery();

                    CargaNro++;
                }
                t.Commit();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ok = true;
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }

        public DataTable ConsultaSQL(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (Parametro oParametro in values)
            {
                cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
            }

            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
        public int ProximoIdCarga(int idCamion)
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "dbo.SP_PROXIMO_ID_CARGAS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", idCamion);
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = "@next";
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();

            cnn.Close();
            try
            {
                return (int)pOut.Value;
            
            }
            catch (Exception)
            {  
              return 1;
            
             
            }

        }
    }
}
