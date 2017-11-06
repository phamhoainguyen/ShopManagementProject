using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SM.DAL
{
    class ConnectDB
    {
        public string connectionString;
        private SqlConnection conn;

        public ConnectDB() { }

        public ConnectDB(string _connectionString)
        {
            this.connectionString = _connectionString;
        }

        public void OpenConnection()
        {
            try
            {
                conn = new SqlConnection(this.connectionString);
                conn.Open();
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public void CloseConnection()
        {
            try
            {
                this.conn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlConnection GetConn()
        {
            return this.conn;
        }
        public DataTable GetDataTable(string storeProcedureName, string[] arrParam = null, SqlDbType[] arrType = null, ParameterDirection[] direct = null)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand(storeProcedureName, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < arrParam.Length; i++)
                {
                    cmd.Parameters.Add(new SqlParameter(arrParam[i].ToString(), arrType[i]));
                    
                }

                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
            
            

            
            return null;
        }






    }
}
