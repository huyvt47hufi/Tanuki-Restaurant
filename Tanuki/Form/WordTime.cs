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
    public partial class WordTime : Form
    {
        Connection cn;
        SqlDataAdapter da;
        DataSet ds;
        ClassLogin tt;
        public WordTime()
        {
            InitializeComponent();
            this.CenterToScreen();
            cn = new Connection();
            tt = new ClassLogin();
        }

        private void WordTime_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            string strSelect = " SET DATEFORMAT DMY\n"
                              + "select ChamCong.MaNV as 'Mã nhân viên',  HoTenNV as 'Họ tên' , Ngay as 'Ngày' , TGVao as 'Thời gian vào', TGVe as 'Thời gian vể'"
                              + " from ChamCong,NhanVien "
                              + " where ChamCong.MaNV = NhanVien.MaNV "
                              + " and (Ngay >= '"+dtpFromdate.Text+"' and Ngay <= '"+dtpToDate.Text+"')"
                              + " order by Ngay asc";
            
            da= new SqlDataAdapter(strSelect, cn.con);
            
            da.Fill(ds, "ChamCong_NhanVien");
            dgrvTime.DataSource = ds.Tables["ChamCong_NhanVien"];
          
        }
    }
}
