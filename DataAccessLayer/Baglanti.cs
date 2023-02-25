using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=VICTUS-16-JMT\\SQLEXPRESS;Initial Catalog=DbPersonel;Integrated Security=True");
    }
}
