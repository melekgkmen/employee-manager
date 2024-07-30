using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=MELEK\SQLEXPRESS;Initial Catalog=DbEmployee;Integrated Security=True");

    }
}
