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
    public partial class Customers : Form
    {
        Connection kn;
        SqlDataAdapter da;
        DataSet ds;
        DataColumn[] key = new DataColumn[1];

        public Customers()
        {
            InitializeComponent();
            kn = new Connection();
        }

        public Customers(string manv)
        {
            InitializeComponent();
            kn = new Connection();
            txtMaKH.Text = manv;
            txtMaKH.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtTenKH.Enabled = true;
            btnLuu.Enabled = true;
            txtEmail.Clear();
            txtSDT.Clear();
            txtTenKH.Clear();
        }

        public void Databingding(DataTable pDT)
        {
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
          
            txtMaKH.DataBindings.Add("Text", pDT, "MaKH");
            txtTenKH.DataBindings.Add("Text", pDT, "TenKH");
            txtSDT.DataBindings.Add("Text", pDT, "SDT");
            txtEmail.DataBindings.Add("Text", pDT, "Email");

        }

        public void loadDuLieuKhachHang()
        {
            ds = new DataSet();

            string strSelect = "Select * from KhachHang";
            da = new SqlDataAdapter(strSelect, kn.con);
            da.Fill(ds, "KhachHang");
            dgrvKhachHang.DataSource = ds.Tables["KhachHang"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["KhachHang"].Columns[0];
            ds.Tables["KhachHang"].PrimaryKey = key;


        }

        void dtbingding(DataTable pDT)
        {
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();



            txtMaKH.DataBindings.Add("Text", pDT, "MaKH");
            txtTenKH.DataBindings.Add("Text", pDT, "TenKH");
            txtSDT.DataBindings.Add("Text", pDT, "SDT");
            txtEmail.DataBindings.Add("Text", pDT, "Email");

            if (dgrvKhachHang.CurrentRow.Cells[4].Value.ToString().Equals("Nữ"))
            {
                rdoBT_Nu.Checked = true;
                rdoBT_Nam.Checked = false;
                
            }
            else
            {
                rdoBT_Nu.Checked = false;
                rdoBT_Nam.Checked = true;
            }

        }
        private void Customers_Load(object sender, EventArgs e)
        {
            loadDuLieuKhachHang();
            dtbingding(ds.Tables["KhachHang"]);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtTenKH.Enabled = true;
            btnLuu.Enabled = true;
            rdoBT_Nam.Enabled = true;
            rdoBT_Nu.Enabled = true;

            txtMaKH.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtTenKH.Clear();
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            txtMaKH.Enabled = false;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            txtTenKH.Enabled = true;
            btnLuu.Enabled = true;
            rdoBT_Nam.Enabled = true;
            rdoBT_Nu.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập Mã khách hàng");
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập Tên khách hàng");
                txtTenKH.Focus();
                return;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập Email");
                txtEmail.Focus();
                return;
            }
            if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhậpSDT");
                txtSDT.Focus();
                return;
            }
            if (txtMaKH.Enabled == true)
            {
                DataRow insNew = ds.Tables["KhachHang"].NewRow();
                insNew["MaKH"] = txtMaKH.Text;
                insNew["TenKH"] = txtTenKH.Text;
                insNew["SDT"] = txtSDT.Text;
                insNew["Email"] = txtEmail.Text;
                if (rdoBT_Nam.Checked)
                {
                    insNew["GioiTinh"] = rdoBT_Nam.Text;
                }
                else
                {
                    insNew["GioiTinh"] = rdoBT_Nu.Text;
                }
                ds.Tables["KhachHang"].Rows.Add(insNew);
            }
            else
            {
                DataRow upNew = ds.Tables["KhachHang"].Rows.Find(txtMaKH.Text);
                if (upNew != null)
                {
                    upNew["TenKH"] = txtTenKH.Text;
                    upNew["SDT"] = txtSDT.Text;
                    upNew["Email"] = txtEmail.Text;
                    if (rdoBT_Nam.Checked)
                    {
                        upNew["GioiTinh"] = rdoBT_Nam.Text;
                    }
                    else
                    {
                        upNew["GioiTinh"] = rdoBT_Nu.Text;
                    }
                }
            }
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "KhachHang");
            MessageBox.Show("Thành công");
            btnLuu.Enabled = false;
        }

        private void dgrvKhachHang_Click(object sender, EventArgs e)
        {
            //foreach (DataRow row in ds.Tables["KhachHang"].Rows)
            //{
            //    if (row.ItemArray[4].ToString() == "Nam")
            //    {


            //        rdoBT_Nam.Checked = true;
            //        rdoBT_Nu.Checked = false;
            //    }
            //    else
            //    {
            //        rdoBT_Nam.Checked = false;
            //        rdoBT_Nu.Checked = true;
            //    }
            //}
            if (dgrvKhachHang.CurrentRow.Cells[4].Value.ToString().Equals("Nữ"))
            {
                rdoBT_Nu.Checked = true;
                rdoBT_Nam.Checked = false;

            }
            else
            {
                rdoBT_Nu.Checked = false;
                rdoBT_Nam.Checked = true;
            }
        }

        private void dgrvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

    }
}
