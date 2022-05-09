using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PharmacyProject
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-CEI400U\\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
