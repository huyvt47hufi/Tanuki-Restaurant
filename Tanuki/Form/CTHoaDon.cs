using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Tanuki
{
    public partial class CTHoaDon : Form
    {
        Connection kn;
        SqlDataAdapter da;
        DataSet ds, ds2;
        DataTable dt_sp;
        DataColumn[] key = new DataColumn[1];
        public CTHoaDon(string mahoadon)
        {
            InitializeComponent();
            kn = new Connection();
            loadPhieu(mahoadon);
            lbTenHD.Text = mahoadon;
        }

        public void loadPhieu(string mahoadon)
        {
            string str = "Select maphieu,makh,manv,tenmon,soluong,tongtien from PhieuOrder a,Menu b where a.mamon = b.mamon and  MaHoaDon = '" + mahoadon + "'";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds, "PhieuOrder");
            dgv.DataSource = ds.Tables[0];
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;

        }
    }
}
