using SM.DL.DAL.NGUYEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.BL.QUANLYBANHANG.NGUYEN
{
    public class bl_PhieuNhapHang
    {
        public DataTable GetAllPhieuNhapHang()
        {
            try
            {
                dal_PhieuNhapHang dal = new dal_PhieuNhapHang();
                DataTable dt = dal.GetAllPhieuNhap();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
