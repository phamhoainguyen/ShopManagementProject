using System;
using System.Collections.Generic;
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

namespace SM.PL.QUANLYBANHANG
{
    /// <summary>
    /// Interaction logic for NhapHangHoa.xaml
    /// </summary>
    public partial class NhapHangHoa : Window
    {
        public NhapHangHoa()
        {
            InitializeComponent();
            this.frame.Source = new Uri("KiemKho.xaml", UriKind.Relative);
            
        }
    }
}
