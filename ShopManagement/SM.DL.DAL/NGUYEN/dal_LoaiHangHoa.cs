﻿using SM.DAL;
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
                    string query = "INSERT INTO LOAIHANGHOA(ID, LOAIHANGHOA) output INSERTED.ID VALUES(@id, @name)";
                    string[] arrParam = new string[] { "@id", "@name" };
                    SqlDbType[] arrType = new SqlDbType[] {SqlDbType.Int, SqlDbType.NVarChar };
                    object[] arrvalues = new object[] {rDataSource.Rows[0]["id"], rDataSource.Rows[0]["name"] };
                    return cnn.conn.ExecuteQueryReturnID(query, arrParam, arrvalues, arrType);
                }
                return 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public int GetLastestIDLoaiHH()
        {
            try
            {
                ConnectionString cnn = new ConnectionString();
                string query = "SELECT TOP 1 * FROM LOAIHANGHOA ORDER BY ID DESC";
                DataTable dt = cnn.conn.ExecuteQueryGetLastestID(query);
                if(dt == null || dt.Rows.Count <= 0)
                {
                    return 0;
                }
                int id = int.Parse(dt.Rows[0]["ID"].ToString());
                return id;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
