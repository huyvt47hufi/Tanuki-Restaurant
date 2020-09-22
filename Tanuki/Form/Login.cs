using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeInOut;
namespace Tanuki
{
    public partial class Login : Form
    {
        ClassLogin tt;
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            tt = new ClassLogin();
        }

        private void txtUserID_Click(object sender, EventArgs e)
        {
            /*--Code set hiệu ứng--*/
            if (txtUserID.Text == "User ID")
            {
                txtUserID.Clear();
            }
            else
            {
                txtUserID.Text = "User ID";
            }
            /*--End Code set hiệu ứng--*/
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            /*--Code set hiệu ứng--*/
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';

            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";

            }
            /*--End Code set hiệu ứng--*/
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tt.kiemTraTaiKhoanTonTai(txtUserID.Text, txtPassword.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                Menu mnu = new Menu(tt.kiemTraChucVu(txtUserID.Text, txtPassword.Text));
                mnu.Visible = true;

                this.Hide();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tên tài khoản hay mật khẩu");
                txtUserID.Focus();
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Time t = new Time();
            t.Visible = true;
            this.Visible = false;
        }
    }
}
