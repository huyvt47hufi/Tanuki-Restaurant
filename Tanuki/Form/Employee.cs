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
    public partial class Employee : Form
    {
        Connection kn;
        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        ImageList img;
        List<ClassNhanVien> dsnhanvien = new List<ClassNhanVien>();
        string file;

        public Employee()
        {
            InitializeComponent();
            kn = new Connection();
        }
        /*********THUC THI CODE *******/
        public void loadALLNhanVien()
        {
            string str = "select NhanVien.MaNV, ChucVu.TenChucVu, HinhNV, HoTenNV,NhanVien.GioiTinh, NgaySinh,NgayVaoLam,SoDienThoai,LuongCoBan  from NhanVien,ChucVu where NhanVien.MaChucVu = ChucVu.MaChucVu";
            ds = new DataSet();
            da = new SqlDataAdapter(str, kn.con);
            da.Fill(ds, "NhanVien");
        }

        void loadListNV()
        {
            loadALLNhanVien();

            img = new ImageList();

            lstvNhanVien.View = View.LargeIcon;
            lstvNhanVien.LargeImageList = img;
            img.ImageSize = new Size(120, 120);
            img.ColorDepth = ColorDepth.Depth32Bit;
            foreach (DataRow row in ds.Tables["NhanVien"].Rows)
            {
                ClassNhanVien nhanvien = new ClassNhanVien() { MaNV = row[0].ToString(), HoTen = row[3].ToString(), ChucVu = row[1].ToString(), GioiTinh = row[4].ToString(), Hinh = row[2].ToString(), LuongCB = decimal.Parse(row[8].ToString()), NgaySinh = row[5].ToString(), SDT = row[7].ToString(), NgayVaoLam = row[6].ToString() };
                //string ha = row[2].ToString();
                dsnhanvien.Add(nhanvien);
                string dgdan = @"..\\..\\Hinh\\NhanVien\\" + nhanvien.Hinh;

                ListViewItem item = new ListViewItem();
                item.Text = nhanvien.HoTen;
                item.ImageIndex = img.Images.Add(Image.FromFile(dgdan), Color.Transparent);
                item.Name = nhanvien.MaNV;
                lstvNhanVien.Items.Add(item);
            }
        }

        // load combobox chức vụ
        void loadCboChucVu()
        {
            string str = "select * from ChucVu";
            ds = new DataSet();
            da = new SqlDataAdapter(str, kn.con);
            da.Fill(ds, "ChucVu");
            key[0] = ds.Tables["ChucVu"].Columns[0];
            ds.Tables["ChucVu"].PrimaryKey = key;

            cbo_ChucVu.DataSource = ds.Tables["ChucVu"];
            cbo_ChucVu.ValueMember = "MaChucVu";
            cbo_ChucVu.DisplayMember = "TenChucVu";
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public void setEnable(bool t)
        {
            txt_MaNV.Enabled = t;
            txt_TenNV.Enabled = t;
            cbo_ChucVu.Enabled = t;
            txt_LuongCB.Enabled = t;
            txt_SDT.Enabled = t;
            maskedTxt_NgayVaoLam.Enabled = t;
            maskedtxt_NgaySinh.Enabled = t;

            rdoBT_Nam.Enabled = t;
            rdoBT_Nu.Enabled = t;
        }

        public void setReset()
        {
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_LuongCB.Clear();
            txt_SDT.Clear();
            maskedTxt_NgayVaoLam.Clear();
            maskedtxt_NgaySinh.Clear();

        }

        bool KT_MaNV(string ma)
        {
            try
            {
                kn.con.Open();
                string str = "select * from NhanVien where MaNV ='" + ma + "'";
                SqlCommand cmd = new SqlCommand(str, kn.con);
                int count = (int)cmd.ExecuteScalar();
                if (count >= 1)
                    return false;
                kn.con.Close();
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public string kiemTraRdo()
        {
            if (rdoBT_Nam.Checked == true)
                return "Nam";
            else
                return "Nữ";
        }


        /********* END THUC THI CODE *******/
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            loadListNV();
            loadCboChucVu();

        }

        private void lstvNhanVien_Click_1(object sender, EventArgs e)
        {
            loadALLNhanVien();
            string ma = lstvNhanVien.SelectedItems[0].Name;
            ClassNhanVien nhanvienDuocChon = dsnhanvien.Single(m => m.MaNV == ma);
            txt_MaNV.Text = nhanvienDuocChon.MaNV;
            txt_LuongCB.Text = nhanvienDuocChon.LuongCB.ToString();
            maskedtxt_NgaySinh.Text = nhanvienDuocChon.NgaySinh;
            maskedTxt_NgayVaoLam.Text = nhanvienDuocChon.NgayVaoLam;
            txt_SDT.Text = nhanvienDuocChon.SDT;
            txt_TenNV.Text = nhanvienDuocChon.HoTen;
            if (nhanvienDuocChon.GioiTinh == "Nam")
            {
                rdoBT_Nam.Checked = true;
                rdoBT_Nu.Checked = false;
            }

            else
            {
                rdoBT_Nam.Checked = false;
                rdoBT_Nu.Checked = true;
            }

            if (nhanvienDuocChon.ChucVu == "Quản lí")
            {
                cbo_ChucVu.SelectedIndex = 1;
            }
            else
            {
                cbo_ChucVu.SelectedIndex = 0;
            }

            picNV.Image = Image.FromFile("..\\..\\Hinh\\NhanVien\\" + nhanvienDuocChon.Hinh);
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            setEnable(true);
            setReset();
            btnLuu.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá nhân viên " + txt_MaNV.Text + " không?",
               "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                kn.con.Open();
                string strDelete = "delete NhanVien where MaNV = '" + txt_MaNV.Text + "'";
                SqlCommand cmd = new SqlCommand(strDelete, kn.con);
                cmd.ExecuteNonQuery();
                kn.con.Close();
                MessageBox.Show("Thành công");
                loadListNV();
            }
            else
            {
                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setEnable(true);
            txt_MaNV.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống mã nhân viên");
                txt_MaNV.Focus();
            }
            if (txt_TenNV.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống tên nhân viên");
                txt_TenNV.Focus();
            }
            if (maskedtxt_NgaySinh.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày sinh");
                maskedtxt_NgaySinh.Focus();
            }
            if (maskedTxt_NgayVaoLam.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày vào làm");
                maskedTxt_NgayVaoLam.Focus();
            }
            if (txt_SDT.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống điện thoại");
                txt_SDT.Focus();
            }
            if (txt_LuongCB.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống lương cơ bản");
                txt_LuongCB.Focus();
            }
            //if (txtTaiKhoan.Text.Length == 0)
            //{
            //    MessageBox.Show("Không được để trống tên tài khoản");
            //    txtTaiKhoan.Focus();
            //}
            //if (txtMatKhau.Text.Length == 0)
            //{
            //    MessageBox.Show("Không được để trống mật khẩu");
            //    txtMatKhau.Focus();
            //}
            if (txt_MaNV.Enabled == true)
            {
                if (KT_MaNV(txt_MaNV.Text) == false)
                {
                    if (kn.con.State == ConnectionState.Open)
                    {
                        kn.con.Close();
                    }
                    kn.con.Open();
                    string strInsert = "SET DATEFORMAT DMY Insert into NhanVien Values('" + txt_MaNV.Text + "', '" + cbo_ChucVu.SelectedValue.ToString() + "', '" + file + "', N'" + txt_TenNV.Text + "', N'" + kiemTraRdo() + "', '" + maskedtxt_NgaySinh.Text + "', '" + maskedTxt_NgayVaoLam.Text + "', '" + txt_SDT.Text + "', '" + txt_LuongCB.Text + "', '', '100000')";
                    SqlCommand cmd = new SqlCommand(strInsert, kn.con);
                    cmd.ExecuteNonQuery();
                    kn.con.Close();
                    MessageBox.Show("Thành công");
                    loadListNV();
                }
                else
                    MessageBox.Show("Mã sinh viên bị trùng");
            }// thêm
            else
            {
                try
                {
                    kn.con.Open();
                    string strUpdate = "SET DATEFORMAT DMY\n Update NhanVien set MaChucVu = '" + cbo_ChucVu.SelectedValue + "' , HinhNV = '" + file + "' , HoTenNV = '" + txt_TenNV.Text + "' , GioiTinh = '" + kiemTraRdo() + "' , NgaySinh = '" + maskedtxt_NgaySinh.Text + "' , NgayVaoLam = '" + maskedTxt_NgayVaoLam.Text + "' , SoDienThoai = '" + txt_SDT.Text + "' , LuongCoBan = '" + txt_LuongCB.Text + "' where MaNV = '" + txt_MaNV.Text + "'";
                    SqlCommand cmd = new SqlCommand(strUpdate, kn.con);
                    cmd.ExecuteNonQuery();
                    kn.con.Close();
                    MessageBox.Show("Thành công");
                    loadListNV();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thất Bại");
                    throw;
                }                
              
            }//sưa
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ofd_HinhNV.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*jpg|All files (*.*)|*.*";
            if (ofd_HinhNV.ShowDialog() == DialogResult.OK)
            {
                file = ofd_HinhNV.FileName;
                if (string.IsNullOrEmpty(file))
                    return;
                Image myImage = Image.FromFile(file);
                picNV.Image = myImage;
            }

            string[] hinh = ReverseString(file).Split('\\');
            file = ReverseString(hinh[0]);
            MessageBox.Show(file);
        }

        private void txt_LuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
    