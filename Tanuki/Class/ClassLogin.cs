using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Tanuki
{
    class ClassLogin
    {
        
        Connection cn = new Connection();
        /*--------------LOGIN-------------------*/
        public bool kiemTraTaiKhoanTonTai(string user, string pass)
        {
            try
            {
                if (cn.con.State == ConnectionState.Closed)
                {
                    cn.con.Open();
                }
                //Kiem tra ma nhan vien ton tai
                string strSelect = "select count(*) TenTK from TaiKhoan where TenTK = '" + user + "' and MatKhau = '"+pass+"'";
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

        public string kiemTraChucVu(string user, string pass)
        {
            string chucvu = "";
            try
            {
                if (cn.con.State == ConnectionState.Closed)
                {
                    cn.con.Open();
                }
                string strSelect = " select MaChucVu"
                                    + " from TaiKhoan,NhanVien"
                                    + " where TaiKhoan.MaNV = NhanVien.MaNV"
                                    + " and TenTK = '" + user + "' and MatKhau = '" + pass + "'";
                                   
                SqlCommand cmd = new SqlCommand(strSelect, cn.con);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    chucvu = rd["MaChucVu"].ToString();
                    
                }
                rd.Close();
                if (cn.con.State == ConnectionState.Open)
                {
                    cn.con.Close();
                }
              
                return chucvu;
              
            }
            catch
            {
                return null;
               
            }
        }
        /*--------------LOGIN-------------------*/
    }
}
