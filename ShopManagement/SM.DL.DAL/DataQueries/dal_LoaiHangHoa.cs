using SM.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.DL.DAL.DataQueries
{
    public class dal_LoaiHangHoa
    {
       
        public int insertLoaiHangHoa(params object[] oParams)
        {
            try
            {
                if (oParams != null)
                {
                    DataTable rDataSource = (DataTable)oParams[0];
                    ConnectionString cnn = new ConnectionString();
                    string query = "";
                    string[] arrParam = new string[] { };
                    SqlDbType[] arrType = new SqlDbType[] { };
                    object[] arrvalues = new object[] { };
                    return cnn.conn.ExecuteQueryReturnID(query, arrParam, arrvalues, arrType);
                }
                return 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            
        }
    }
}
