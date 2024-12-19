using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Petrol_otomasyonu
{
    internal class sqlbağlantisi
    {
        public SqlConnection baglanti() 
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LN04JT2\\SQLEXPRESS;Initial Catalog=petrol_otomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
