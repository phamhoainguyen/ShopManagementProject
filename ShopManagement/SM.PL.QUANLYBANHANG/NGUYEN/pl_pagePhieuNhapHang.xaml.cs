using SM.BL.QUANLYBANHANG.NGUYEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SM.PL.QUANLYBANHANG.NGUYEN
{
    /// <summary>
    /// Interaction logic for PhieuNhapHang.xaml
    /// </summary>
    public partial class pl_pagePhieuNhapHang : Page
    {

        private DataTable dataSource;
        // thang nay se chua du lieu lay len tu database
        private DataTable gridViewDataSource;

        // lay du lieu tu tang bl
        private bl_PhieuNhapHang bl_phieuNhap;
        public pl_pagePhieuNhapHang()
        {
            InitializeComponent();
            bl_phieuNhap = new bl_PhieuNhapHang();
            this.initGridViewDataSource();
        }

        private void initGridViewDataSource()
        {
            DataTable dt = this.bl_phieuNhap.GetAllPhieuNhapHang();
            this.gridViewDataSource = dt;

            // gan dataSource cho gridView
            this.iGridViewPhieuNhap.ItemsSource = this.gridViewDataSource.DefaultView;
        }
    }


}
