namespace BAMS.Modules
{
    internal class SqlConnection
    {
        private string connectionString;

        public SqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}