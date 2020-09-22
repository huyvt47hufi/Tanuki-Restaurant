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
    public partial class StockList : Form
    {
        Connection kn;
        SqlDataAdapter da, da2;
        DataSet ds, ds2;
        DataTable dt_sp;
        DataColumn[] key = new DataColumn[1];
        public StockList()
        {
            InitializeComponent();
            kn = new Connection();

        }
        /**** Thuc thi code *****/
        public void LoadCB()
        {
            string str = "Select * from LoaiMon ";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds, "Loai");
            key[0] = ds.Tables["Loai"].Columns[0];
            ds.Tables["Loai"].PrimaryKey = key;

            DataRow nr = ds.Tables["Loai"].NewRow();
            nr["TenLoai"] = "Tất cả";
            nr["MaLoai"] = "0";
            ds.Tables["Loai"].Rows.InsertAt(nr, 0);

            cbLoai.DataSource = ds.Tables["Loai"];
            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "MaLoai";
        }

        public void LoadSP(string ma)
        {
            string str = "Select * from Menu ";
            if (ma != null && ma != "0")
                str += "Where MaLoai = '" + ma + "'";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds, "Menu");
            key[0] = ds.Tables["Menu"].Columns[0];
            ds.Tables["Menu"].PrimaryKey = key;
            dgvHienThi.DataSource = ds.Tables["Menu"];
            DataBindding(ds.Tables["Menu"]);
        }

        public void DataBindding(DataTable dt)
        {
            txtMaMon.DataBindings.Clear();
            txtTenmon.DataBindings.Clear();
            txtMaMon.DataBindings.Add("Text", dt, "MaMon");
            txtTenmon.DataBindings.Add("Text", dt, "TenMon");
        }


        /**** end Thuc thi code *****/


        private void StockList_Load(object sender, EventArgs e)
        {
            LoadCB();
            LoadSP(null);
            dgvHienThi.ReadOnly = true;
            dgvHienThi.AllowUserToAddRows = false;
            btnLuu.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            rdoMaMon.Checked = true;
        }

        private void bnTim_Click(object sender, EventArgs e)
        {
            LoadSP(cbLoai.SelectedValue.ToString());
        }

        private void btnTimMon_Click(object sender, EventArgs e)
        {
            if (rdoMaMon.Checked == true)
            {
                da = new SqlDataAdapter("Select * from Menu Where MaMon Like '%" + txtMaMon.Text + "%'", kn.con);
            }
            else
            {
                da = new SqlDataAdapter("Select * from Menu Where TenMon Like N'%" + txtTenmon.Text + "%'", kn.con);
            }
            ds = new DataSet();
            da.Fill(ds, "Menu");
            dgvHienThi.DataSource = ds.Tables["Menu"];
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Select * from Menu";
                SqlDataAdapter da = new SqlDataAdapter(str, kn.con);
                SqlCommandBuilder dmb = new SqlCommandBuilder(da);
                da.Update(ds, "Menu");
                MessageBox.Show("Thành công");
                btnLuu.Enabled = false;
                dgvHienThi.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("Thất bại");
                ds.Tables["Menu"].Reset();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dgvHienThi.AllowUserToAddRows = true;
            dgvHienThi.ReadOnly = false;
            for (int i = 0; i < dgvHienThi.Rows.Count - 1; i++)
            {
                dgvHienThi.Rows[i].ReadOnly = true;
            }
            dgvHienThi.FirstDisplayedScrollingRowIndex = dgvHienThi.Rows.Count - 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn Món");
                return;
            }
            else
            {
                DataRow dr = ds.Tables["Menu"].Rows.Find(txtMaMon.Text);
                if (dr != null)
                {
                    dr.Delete();
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm này");
                }
            }
            SqlCommandBuilder bd = new SqlCommandBuilder(da);
            da.Update(ds, "Menu");
            LoadSP("0");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dgvHienThi.ReadOnly = false;
            for (int i = 0; i < dgvHienThi.Rows.Count; i++)
            {
                dgvHienThi.Rows[i].ReadOnly = false;
            }
            dgvHienThi.Columns[0].ReadOnly = true;
            dgvHienThi.AllowUserToAddRows = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void dgvHienThi_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }


    }
}
