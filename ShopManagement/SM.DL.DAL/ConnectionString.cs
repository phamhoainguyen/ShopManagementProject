using System;
using System.Data.SqlClient;

namespace SM.DAL
{
    public class ConnectionString
    {   
        public DBConnection conn = null;

        public ConnectionString()
        {
            try
            {

                //User Id=NguyenMSSQL;Password=123456;Data Source=192.168.1.5:1433/NGUYENSQL;Statement Cache Size=0
                // string = Data Source=DESKTOP-HOAINGU\NGUYENSQL;Initial Catalog=ShopManagement;Persist Security Info=True;User ID=NguyenMSSQL;Password=***********
                conn = new DBConnection("Data Source=192.168.1.5\\NGUYENSQL;Initial Catalog=ShopManagement;Persist Security Info=True;User ID=NguyenMSSQL;Password=123456");

            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }

    
}
