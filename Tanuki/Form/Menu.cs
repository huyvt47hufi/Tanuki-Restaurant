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
    public partial class Menu : Form
    {
        ClassLogin tt;
        string chucvu="";
        public Menu(string cv)
        {
            InitializeComponent();
            this.CenterToScreen();
            tt = new ClassLogin();
            chucvu = cv;
        }
        
        public void setEnable()
        {
            if (chucvu.Equals("QL        "))
            {

                btnStockList.Enabled = true;
                btnEmployee.Enabled = true;
                btnCustomers.Enabled = true;
            }
            else
            {
                btnStockList.Enabled = false;
                btnEmployee.Enabled = false;
                btnCustomers.Enabled = false;
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString();
            setEnable();
        }

        private void btnTimeInOut_Click(object sender, EventArgs e)
        {
            WordTime tio = new WordTime();
            tio.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Sale sl = new Sale();
            sl.Show();
        }

        private void btnStockList_Click(object sender, EventArgs e)
        {
            StockList stl = new StockList();
            stl.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }


    }
}
