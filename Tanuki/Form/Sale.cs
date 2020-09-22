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
using Tanuki.Class;

namespace Tanuki
{
    public partial class Sale : Form
    {
        Connection kn;
        SqlDataAdapter da, da2;
        DataSet ds, ds2;
        DataTable dt_sp;
        DataColumn[] key = new DataColumn[1];
        List<string> lstMa = new List<string>();
        ImageList img;
        public Sale()
        {
            InitializeComponent();
            kn = new Connection();
        }

        /*** Thuc thi ***/
        public void LoadKhachHang()
        {
            string str = "Select * from KhachHang";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds, "KhachHang");
            key[0] = ds.Tables["KhachHang"].Columns[0];
            ds.Tables["KhachHang"].PrimaryKey = key;

        }

        public void LoadHoaDon()
        {
            string str = "Select * from HD";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds, "HoaDon");
            key[0] = ds.Tables["HoaDon"].Columns[0];
            ds.Tables["HoaDon"].PrimaryKey = key;
        }

        public void LoadNhanVien()
        {
            string str = "Select * from NhanVien";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds, "NhanVien");
            key[0] = ds.Tables["NhanVien"].Columns[0];
            ds.Tables["NhanVien"].PrimaryKey = key;

        }

        public void LoadPhieuOrder()
        {
            string str = "Select * from PhieuOrder";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds, "PhieuOrder");
            key[0] = ds.Tables["PhieuOrder"].Columns[0];
            ds.Tables["PhieuOrder"].PrimaryKey = key;
        }
        public void HienthiSanPham(string s)
        {
            string query = " Select * from Menu ";
            if (s != null)
            {
                query += " where MaLoai = '" + s + "'";
            }
            da = new SqlDataAdapter(query, kn.con);
            //ds = new DataSet();
            //da.Fill(ds,"hienthiSanPham");
            dt_sp = new DataTable();
            da.Fill(dt_sp);
            lstV_sp.Items.Clear();
            lstV_sp.View = View.Details;
            lstV_sp.Columns.Add("MaMon");
            lstV_sp.Columns.Add("TenMon");
            lstV_sp.Columns.Add("HinhAnh");
            lstV_sp.Columns.Add("MoTa");
            lstV_sp.Columns.Add("Gia");
            lstV_sp.GridLines = true;
            lstV_sp.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in dt_sp.Rows)
            {
                lstV_sp.Items.Add(row["MaMon"].ToString());
                lstV_sp.Items[i].SubItems.Add(row["TenMon"].ToString());
                lstV_sp.Items[i].SubItems.Add(row["HinhAnh"].ToString());
                lstV_sp.Items[i].SubItems.Add(row["MoTa"].ToString());
                lstV_sp.Items[i].SubItems.Add(row["Gia"].ToString());
                i++;
            }
        }

        void loadhinhMenu(string s)
        {
            img = new ImageList();

            string query = " Select * from Menu ";
            if (s != null)
            {
                query += " where MaLoai = '" + s + "'";
            }

            da = new SqlDataAdapter(query, kn.con);
            dt_sp = new DataTable();
            da.Fill(dt_sp);

            lstV_sp.View = View.LargeIcon;
            lstV_sp.LargeImageList = img;
            img.ImageSize = new Size(110, 110);
            img.ColorDepth = ColorDepth.Depth32Bit;

            foreach (DataRow row in dt_sp.Rows)
            {
                string ha = row[1].ToString();
                string dgdan = @"..\..\Hinh\Menu\" + ha;
                ListViewItem item = new ListViewItem();
                //item.Text = row[3].ToString() + "-" + Double.Parse(row[5].ToString()).ToString() + "Đ";
                //item.Text = "Tên: " + row[3].ToString() +"\n"+ "Giá: " + row[5].ToString();
                item.Text = "" + row[3].ToString() + "\nGiá: " + Double.Parse(row[5].ToString()).ToString() + " VND";
                item.SubItems.Add(row[0].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[5].ToString());

                item.ImageIndex = img.Images.Add(Image.FromFile(dgdan), Color.Transparent);

                lstV_sp.Items.Add(item);
            }
        }

        public bool kiemtraTrung(string str)
        {
            foreach (string item in lstMa)
            {
                if (item == str)
                    return true;
            }
            return false;
        }

        public void LoadTongTien()
        {
            double tong = TinhTong();
            lbTongCong.Text = tong.ToString();
            lbThanhTien.Text = tong.ToString();
        }

        public double TinhTong()
        {
            double tong = 0;
            foreach (ListViewItem item in lstSelect.Items)
            {
                tong += double.Parse(item.SubItems[4].Text);
            }
            return tong;
        }

        /** end thuc thi **/
        /*** phan su kien **/
        private void btnThucAn_Click(object sender, EventArgs e)
        {
            lstV_sp.Clear();
            loadhinhMenu("F");
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            lstV_sp.Clear();
            loadhinhMenu("N");
        }

        private void btnTrangMieng_Click(object sender, EventArgs e)
        {
            lstV_sp.Clear();
            loadhinhMenu("TM");
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            loadhinhMenu(null);
        }

        private void lstV_sp_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstV_sp.SelectedItems)
            {

                if (kiemtraTrung(item.SubItems[1].Text))
                {
                    int index = lstMa.IndexOf(item.SubItems[1].Text);
                    lstSelect.Items[index].SubItems[2].Text = (int.Parse(lstSelect.Items[index].SubItems[2].Text) + 1).ToString();
                    lstSelect.Items[index].SubItems[4].Text = (int.Parse(lstSelect.Items[index].SubItems[2].Text) * double.Parse(lstSelect.Items[index].SubItems[3].Text)).ToString();
                }
                else
                {
                    double gia = double.Parse(item.SubItems[3].Text);
                    PhieuOrder phieu1 = new PhieuOrder(item.SubItems[2].Text, 1, gia);
                    ListViewItem item1 = new ListViewItem();
                    item1.Text = item.SubItems[1].Text;
                    item1.SubItems.Add(item.SubItems[2].Text);
                    item1.SubItems.Add(phieu1.Soluong.ToString());
                    item1.SubItems.Add(phieu1.Gia.ToString());
                    item1.SubItems.Add(phieu1.Thanhtien.ToString());
                    lstSelect.Items.Add(item1);
                    lstMa.Add(item.SubItems[1].Text);
                }
            }
            LoadTongTien();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string str = "Select * from HoaDon";
            da = new SqlDataAdapter(str, kn.con);
            ds = new DataSet();
            da.Fill(ds, "HoaDon");

            string str2 = "Select * from PhieuOrder";
            da2 = new SqlDataAdapter(str2, kn.con);
            ds2 = new DataSet();
            da2.Fill(ds2, "PhieuOrder");


            try
            {
                string MAHD = ds.Tables["HoaDon"].Rows.Count + 1 + "";
                DataRow dr = ds.Tables["HoaDon"].NewRow();
                dr["MaHoaDon"] = "HD" + MAHD;
                if (txtMaKH.Text.Length != 0)
                    dr["MaKH"] = txtMaKH.Text;
                else
                    dr["MaKH"] = "UNKNOW"; // Khách Chưa đăng ký thành viên

                dr["TongTien"] = TinhTong();
                dr["NgayXuatHD"] = DateTime.Now.Date;

                if (rdoMangDi.Checked)
                {
                    dr["MaDichVu"] = "TA";
                }
                else
                {
                    dr["MaDichVu"] = "EI";
                }
                ds.Tables["HoaDon"].Rows.Add(dr);
                SqlCommandBuilder bd = new SqlCommandBuilder(da);
                da.Update(ds, "HoaDon");


                foreach (ListViewItem item in lstSelect.Items)
                {
                    DataRow dr2 = ds2.Tables["PhieuOrder"].NewRow();
                    dr2["MaPhieu"] = (ds2.Tables["PhieuOrder"].Rows.Count + 1);
                    if (txtMaKH.Text.Length != 0)
                        dr["MaKH"] = txtMaKH.Text;
                    else
                        dr["MaKH"] = "UNKNOW"; // Khách Chưa đăng ký thành viên
                    dr2["MaKH"] = "NV01";
                    dr2["MaMon"] = item.SubItems[0].Text;
                    dr2["SoLuong"] = item.SubItems[2].Text;
                    dr2["TongTien"] = item.SubItems[4].Text;
                    //dr2["MaHoaDon"] = "HD" + (ds.Tables["HoaDon"].Rows.Count + 1);
                    dr2["MaHoadON"] = "HD" + MAHD;
                    ds2.Tables["PhieuOrder"].Rows.Add(dr2);
                }
                SqlCommandBuilder bd2 = new SqlCommandBuilder(da2);
                da2.Update(ds2, "PhieuOrder");
                MessageBox.Show("Thanh toán thành công");
                RPHoaDon hd = new RPHoaDon("HD" + MAHD);
                hd.Visible = true;
                this.Close();

            }
            catch
            {
                MessageBox.Show("Đặt hàng thất bại", "Lỗi");
                ds.Tables["HoaDon"].Reset();
                ds2.Tables["PhieuOrder"].Reset();
            }
        }

        private void btnKTKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập Khách Hàng", "Lưu Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadKhachHang();
            DataRow dr = ds.Tables["KhachHang"].Rows.Find(txtMaKH.Text);
            if (dr == null)
            {
                if (MessageBox.Show("Chưa đăng ký thành viên ! Bạn muốn thêm thành viên không", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Customers cs = new Customers(txtMaKH.Text);
                    cs.Show();
                }
            }
            else
            {
                MessageBox.Show("Tồn Tại", "Lưu ý", MessageBoxButtons.OK);
            }
        }

        private void CmsSelect_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in lstSelect.SelectedItems)
            {
                item.Remove();
                lstMa.Remove(item.SubItems[0].Text);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tên");
                return;
            }
            else
            {
                lstV_sp.Clear();
                img = new ImageList();

                string query = " Select * from Menu where TenMon like N'%" + txtTim.Text + "%'";

                da = new SqlDataAdapter(query, kn.con);
                dt_sp = new DataTable();
                da.Fill(dt_sp);

                lstV_sp.View = View.LargeIcon;
                lstV_sp.LargeImageList = img;
                img.ImageSize = new Size(110, 110);
                img.ColorDepth = ColorDepth.Depth32Bit;

                foreach (DataRow row in dt_sp.Rows)
                {
                    string ha = row[1].ToString();
                    string dgdan = @"..\..\Hinh\Menu\" + ha;
                    ListViewItem item = new ListViewItem();
                    item.Text = "Tên: " + row[3].ToString() + "\nGiá: " + row[5].ToString() + Double.Parse(row[5].ToString()) + " VND";
                    item.SubItems.Add(row[0].ToString());
                    item.SubItems.Add(row[3].ToString());
                    item.SubItems.Add(row[5].ToString());

                    item.ImageIndex = img.Images.Add(Image.FromFile(dgdan), Color.Transparent);

                    lstV_sp.Items.Add(item);
                }
            }

        }
    }
}
