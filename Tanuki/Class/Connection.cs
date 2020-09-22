using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Tanuki
{
    class Connection
    {
          SqlConnection _consql;

        public SqlConnection con
        {
            get { return _consql; }
            set { _consql = value; }
        }

        public Connection()
        {
            con = new SqlConnection(@"Data Source = A201-PC08\SQL2012;"
                                + " Initial Catalog = QLNhaHang;"
                                + " User ID=sa; Password=sql2012;");
        }
    }
}
