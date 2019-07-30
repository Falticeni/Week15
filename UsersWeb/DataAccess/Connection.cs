using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        public static SqlConnection sqlConnection { get; } = new SqlConnection("Data Source=.; Initial Catalog=Week14; Integrated Security=True");
    }
}

