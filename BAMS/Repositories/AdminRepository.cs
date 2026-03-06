using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BAMS.Repositories
{
    internal class AdminRepository
    {
        private readonly string connectionString =
            "Server=MSI;Database=BAM;Integrated Security=True;TrustServerCertificate=True;";

        public bool Login(string username, string password)
        {
            // Fix for CS0747, CS0165, and CS1003:
            // Correctly instantiate the SqlConnection object using a valid constructor.
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT COUNT(*)
                                    FROM Admin 
                                    WHERE Username = @username 
                                    AND Password = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Trim());

                    int result = (int)cmd.ExecuteScalar();

                    return result > 0;
                }
            }
        }
    }
    
}