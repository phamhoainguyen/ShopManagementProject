using SM.DL.DAL.DataQueries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.BL.QUANLYBANHANG
{
    public class bll_LoaiHangHoa
    {
        
        public int AddLoaiHangHoa(DataTable dataSource)
        {
            try
            {
                dal_LoaiHangHoa dal = new dal_LoaiHangHoa();
                int value = dal.insertLoaiHangHoa(dataSource);
                return value;
            }
            catch(Exception ex)
            {
                throw ex;
            }         
        }

        public int GetLastesIDLoaiHH()
        {
            try
            {
                dal_LoaiHangHoa dal = new dal_LoaiHangHoa();
                int value = dal.GetLastestIDLoaiHH();
                return value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
}
