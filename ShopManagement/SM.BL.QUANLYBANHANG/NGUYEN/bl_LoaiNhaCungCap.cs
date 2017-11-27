using SM.DL.DAL.NGUYEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.BL.QUANLYBANHANG.NGUYEN
{
    public class bl_LoaiNhaCungCap
    {
        public int AddLoaiNCC(DataTable dataSource)
        {
            try
            {
                dal_LoaiNhaCungCap dal = new dal_LoaiNhaCungCap();
                int value = dal.insertLoaiNCC(dataSource);
                return value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetLastesIDLoaiNCC()
        {
            try
            {
                dal_LoaiNhaCungCap dal = new dal_LoaiNhaCungCap();
                int value = dal.GetLastestIDLoaiNCC();
                return value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
