using System.Data;
using MySqlConnector;

namespace Aniflix.Factory
{
    public class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> instance =
           new(() => new DatabaseConnection());

        private readonly MySqlConnection connection;

        private const string connectionString = "Server=localhost;Database=aniflix;Username=Covenant9687;Password=v*##GLBkB3r9tuUt;";

        private DatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        public static DatabaseConnection Instance => instance.Value;

        public MySqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public int ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using var cmd = new MySqlCommand(query, GetConnection());
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetDataTable(string query, params MySqlParameter[] parameters)
        {
            using var cmd = new MySqlCommand(query, GetConnection());
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            using var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}

