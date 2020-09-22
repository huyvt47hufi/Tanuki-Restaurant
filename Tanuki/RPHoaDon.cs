using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanuki
{
    public partial class RPHoaDon : Form
    {
        string ma;
        public RPHoaDon(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void RPHoaDon_Load(object sender, EventArgs e)
        {
            Reporthd rpt = new Reporthd();
            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("sa","sql2012","A201-PC08\\SQL2012","QLNhaHang");
            rpt.SetParameterValue("LocMaHD",ma);


            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }

        private void RPHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sale sale = new Sale();
            sale.Visible = true;
        }

    }
}
