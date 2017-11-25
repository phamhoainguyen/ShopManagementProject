using SM.PL.QUANLYBANHANG.plUtilities;
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
using System.Windows.Shapes;

namespace SM.PL.QUANLYBANHANG
{
    /// <summary>
    /// Interaction logic for pl_LoaiHangHoa.xaml
    /// </summary>
    public partial class pl_LoaiHangHoa : Window
    {

        private DataTable dataTable;
        //private DataTable cboDataSource;
        private DataTable gridDataSource;
        public pl_LoaiHangHoa()
        {
            InitializeComponent();
            InitDataTable();
            
            DataTable cboDataSource;

            cboDataSource = this.dataTable.Copy();
            this.gridDataSource = this.dataTable.Copy();

            this.stackPanel.DataContext = this.dataTable;
            
            this.iGridView.ItemsSource = this.gridDataSource.DefaultView;

            ComboxUtils.SetComboBoxEdit(ref this.cboKhoa, "name", "id", cboDataSource);
            ComboxUtils.InsertItem( ref this.cboKhoa, "*", "0", 0, true);
            

            
        }


        
        public void InitDataTable()
        {
            this.dataTable = new DataTable();
            DataColumn name = new DataColumn("name", typeof(string));
            DataColumn id = new DataColumn("id", typeof(int));

            this.dataTable.Columns.Add(name);
            this.dataTable.Columns.Add(id);

            DataRow firstRow = this.dataTable.NewRow();
            firstRow[0] = "Pham Hoai Nguyen";
            firstRow[1] = 10;

            DataRow row2 = this.dataTable.NewRow();
            row2[0] = "Pham Hoai Nhan";
            row2[1] = 21;

            DataRow row3 = this.dataTable.NewRow();
            row3[0] = "Pham Minh Hung";
            row3[1] = 31;

            this.dataTable.Rows.Add(firstRow);
            this.dataTable.Rows.Add(row2);
            this.dataTable.Rows.Add(row3);

            
        }

        private int i = 1;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(this.dataTable != null && this.dataTable.Rows.Count > 1)
            {
                //this.dataTable.Rows[0]["id"] = i++;
                //this.dataTable.Rows[0]["name"] = "Pham Hoai Nguyen";
                
            }

            if (i == 3)
            {
                
            }

            if (i == 5)
            {
                
            }
        }

        private void cboKhoa_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            

        }

        private void iGridView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //DataRowView dr = (DataRowView)this.iGridView.SelectedItem;
            //this.dataTable.Rows[0]["id"] = (int)dr["id"];
            //this.dataTable.Rows[0]["name"] = (string)dr["name"];
            
        }
    }
}
