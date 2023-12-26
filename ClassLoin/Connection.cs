using System.Data.SqlClient;
namespace Manager_Hotel.ClassLoin
{
    class Connection
    {
        private static string stringConnection = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
