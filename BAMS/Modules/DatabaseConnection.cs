using Microsoft.Data.SqlClient;

namespace BAMS.Modules
{
    public class DatabaseConnection
    {
        private static string connectionString =
            "Server=MSI;Database=BAM;Integrated Security=true;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}