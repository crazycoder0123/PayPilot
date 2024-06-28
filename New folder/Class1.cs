using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudsql
{
      public class Class1
        {
            public static SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BCA\PRACTICALS\C#\crudsql\bin\Debug\login.mdf;Integrated Security=True");
            public static int menuitem = 0;
    }

}
