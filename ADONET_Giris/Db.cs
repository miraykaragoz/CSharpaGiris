using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Giris
{
    public static class Db
    {
        public static SqlConnection conn()
        {
            return new SqlConnection ("Server=.\\SQLEXPRESS01;Database=Northwind;Integrated Security=True;TrustServerCertificate=Yes");
        }
    }
}
