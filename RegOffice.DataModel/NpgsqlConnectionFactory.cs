using Npgsql;

namespace RegOffice.DataModel
{
    public class NpgsqlConnectionFactory
    {
        private string _connectionString;

        public NpgsqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
