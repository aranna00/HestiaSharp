using System.Data.Common;
using Npgsql;

namespace HestiaStore
{
    public static class ContextConnection
    {
        public static DbConnection GetDatabaseConnection()
        {
            var connectionStringbuilder = new NpgsqlConnectionStringBuilder();
            connectionStringbuilder.Host = "127.0.0.1";
            connectionStringbuilder.Port = 5432;
            connectionStringbuilder.Username = "hestiasharp";
            connectionStringbuilder.Password = "hestiasharp";
            connectionStringbuilder.Database = "hestiasharp";

            //Insert it here
            var conn = new NpgsqlConnectionFactory().CreateConnection(connectionStringbuilder.ConnectionString);

            return conn;
        }
    }
}