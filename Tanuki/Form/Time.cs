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
using Tanuki;

namespace TimeInOut
{
    public partial class Time : Form
    {
        Connection cn;

        public Time()
        {
            InitializeComponent();
            this.CenterToScreen();

            cn = new Connection();
        }


        /**************** xu ly code**************/
        public void setVisible(bool t)
        {
            gbThongTin.Visible = t;
            btnRaCa.Visible = t;
            btnVaoCa.Visible = t;
            pictureBox1.Visible = t;
        }

        public bool kiemTraMaNVTonTai(string manv)
        {
            try
            {
                if (cn.con.State == ConnectionState.Closed)
                {
                    cn.con.Open();
                }
                //Kiem tra ma nhan vien ton tai
                string strSelect = "select count(*) MaNV from NhanVien where MaNV = '" + manv + "'";
                SqlCommand cmd = new SqlCommand(strSelect, cn.con);

                int countManv = (int)cmd.ExecuteScalar();

                if (cn.con.State == ConnectionState.Open)
                {
                    cn.con.Close();
                }

                return countManv >= 1;//co //khong
            }
            catch
            {
                return false;
            }
        }

        public string layTenNVTheoMa(string manv)
        {
            string hoten = "";
            try
            {
                if (cn.con.State == ConnectionState.Closed)
                {
                    cn.con.Open();
                }
                //Kiem tra ma nhan vien ton tai
                string strSelect = "select * from NhanVien where MaNV = '" + manv + "'";
                SqlCommand cmd = new SqlCommand(strSelect, cn.con);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    hoten = rd["HoTenNV"].ToString();

                }
                rd.Close();
                if (cn.con.State == ConnectionState.Open)
                {
                    cn.con.Close();
                }
                return hoten;

            }
            catch
            {
                return null;
            }
        }
        //public void tinhTongGioLam()
        //{

        //}
        /****************end xu ly code**************/
        private void Time_Load(object sender, EventArgs e)
        {
            setVisible(false);

        }

        private void txtMaNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (kiemTraMaNVTonTai(txtMaNV.Text))
            {

                setVisible(true);
                gbThongTin.Enabled = false;
                txtMaNV_TT.Text = txtMaNV.Text;
                string hoten = layTenNVTheoMa(txtMaNV.Text);
                txtTenNV.Text = hoten;
                txtNgay.Text = DateTime.Now.ToShortDateString();
                txtGio.Text = DateTime.Now.ToLongTimeString();
                
                
            }
            else
            {
                MessageBox.Show("Mã " + txtMaNV.Text + " không tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnVaoCa_Click(object sender, EventArgs e)
        {
            string strInsert = "SET DATEFORMAT DMY\nInsert into ChamCong "
                      + " Values('" + txtMaNV_TT.Text + "','" + txtNgay.Text + "','" + txtGio.Text + "','','')";
            //try
            //{
                    if (cn.con.State == ConnectionState.Closed)
                    {
                        cn.con.Open();
                    }
                    SqlCommand cmd = new SqlCommand(strInsert, cn.con);
                    cmd.ExecuteNonQuery();
                    if (cn.con.State == ConnectionState.Open)
                    {
                        cn.con.Close();
                    }

                    MessageBox.Show("Thành công");
                    Login lg = new Login();
                    lg.Visible = true;
                    this.Visible = false;
            //        this.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Thất bại");
            //}
        }

        private void btnRaCa_Click(object sender, EventArgs e)
        {

            string tgVaoMax = "select TGVao from ChamCong  where MaNV='" + txtMaNV_TT.Text + "' AND Ngay='" + txtNgay.Text + "'  AND TGVao = (SELECT MAX(TGVao) FROM ChamCong Where MaNV ='" + txtMaNV_TT.Text + "')";
            try
            {
                string strInsert = "SET DATEFORMAT DMY\n"
                                    + " UPDATE ChamCong"
                                    + " Set TGVe = '" + txtGio.Text + "'"
                                    + " where MaNV = '" + txtMaNV_TT.Text + "' and Ngay = '" + txtNgay.Text + "' and TGVao = (" + tgVaoMax + ");";
                if (cn.con.State == ConnectionState.Closed)
                {
                    cn.con.Open();
                }
                SqlCommand cmd = new SqlCommand(strInsert, cn.con);
                cmd.ExecuteNonQuery();
                if (cn.con.State == ConnectionState.Open)
                {
                    cn.con.Close();
                }
                MessageBox.Show("Thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }




    }
}
