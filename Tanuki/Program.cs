using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tanuki;
using TimeInOut;

namespace Tanuki
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Time());
            //Application.Run(new Sale());
            //Application.Run(new StockList());
           //Application.Run(new Employee());
            //Application.Run(new HoaDon());
          //Application.Run(new Customers());
          
        }
    }
}
