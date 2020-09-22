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
    public partial class HoaDon : Form
    {
        Connection kn;
        SqlDataAdapter da;
        DataSet ds, ds2;
        DataTable dt_sp;
        DataColumn[] key = new DataColumn[1];
        public HoaDon()
        {
            InitializeComponent();
            kn = new Connection();
            LoadHD();
        }
        public void LoadHD()
        {
            string str = "select * from HoaDon";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            binding(ds.Tables[0]);
        }

        public void binding(DataTable tb)
        {
            txtTim.DataBindings.Clear();
            txtDate.DataBindings.Clear();

            txtTim.DataBindings.Add("Text", tb, "MaHoaDon");
            txtDate.DataBindings.Add("Text", tb, "NgayXuatHD");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập liệu !!");
                return;
            }
            string str = "select * from HoaDon where MaHoaDon Like '%" + txtTim.Text + "%'";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnTimNgay_Click(object sender, EventArgs e)
        {
            string str = "set dateformat dmy select * from HoaDon where NgayXuatHD = '" + txtDate.Text + "'";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            CTHoaDon phieu = new CTHoaDon(txtTim.Text);
            phieu.ShowDialog();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            string str = "select * from HoaDon";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            binding(ds.Tables[0]);
        }





    }
}
