using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAMS.Repositories
{
    internal class AdminRepository
    {
        private readonly String connectionString =
            "Server=MSI\\pitar;Database=BAMS_DB;trusted_connection=true;trustServerCertificate=True";
        private SqlConnection conn;

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) ;
            {
                string query = @"SELECT COUNT(*) 
                                FROM Admin
                                WHERE Username=@username
                                AND Password=@password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);

                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}
