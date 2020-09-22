using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanuki.Class
{
    class PhieuOrder
    {
        string tenmon;

        public string Tenmon
        {
            get { return tenmon; }
            set { tenmon = value; }
        }
        int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        double gia;

        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        //double thanhtien;

        public double Thanhtien
        {
            get { return soluong * gia; }

        }

        public PhieuOrder(string tenmon, int soluong, double gia)
        {
            this.tenmon = tenmon;
            this.soluong = soluong;
            this.gia = gia;
        }
    }
}
