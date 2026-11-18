using MySql.Data.MySqlClient;

namespace DJing
{
    internal static class DatabaseSettings
    {
        public const string VariableName = "DJING_MYSQL_CONNECTION_STRING";

        public static string ConnectionString => Environment.GetEnvironmentVariable(VariableName) ?? string.Empty;

        public static string DatabaseName => new MySqlConnectionStringBuilder(ConnectionString).Database;
    }
}
