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
            {
                cmd.Parameters.AddRange(parameters);
            }

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
        public int InsertData(string tableName, params MySqlParameter[] parameters)
        {
            string columnNames = string.Join(", ", parameters.Select(p => p.ParameterName.TrimStart('@')));
            string paramNames = string.Join(", ", parameters.Select(p => "@" + p.ParameterName.TrimStart('@')));
            string query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({paramNames});";
            return ExecuteQuery(query, parameters);
        }
        public int UpdateData(string tableName, string condition, params MySqlParameter[] parameters)
        {
            string setClause = string.Join(", ", parameters.Select(p => $"{p.ParameterName.TrimStart('@')} = @{p.ParameterName.TrimStart('@')}"));
            string query = $"UPDATE {tableName} SET {setClause} WHERE {condition};";
            return ExecuteQuery(query, parameters);
        }
        public DataRow? GetFirstRecord(string tableName, params MySqlParameter[] parameters)
        {
            string query = $"SELECT * FROM {tableName} LIMIT 1;";
            DataTable table = GetDataTable(query, parameters);
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }
        public DataRow? GetFirstRecord(string tableName, string condition = "1=1", params MySqlParameter[] parameters)
        {
            string query = $"SELECT * FROM {tableName} WHERE {condition} LIMIT 1;";
            DataTable table = GetDataTable(query, parameters);
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }
        public DataTable SelectData(string tableName, string condition = "1=1", params MySqlParameter[] parameters)
        {
            string query = $"SELECT * FROM {tableName} WHERE {condition};";
            return GetDataTable(query, parameters);
        }
        public DataRow? GetRecordById(string tableName, int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE id = @id LIMIT 1;";
            DataTable table = GetDataTable(query, new MySqlParameter("@id", id));
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }
        public DataRow? GetNextRecord(string tableName, int currentId)
        {
            string query = $"SELECT * FROM {tableName} WHERE id > @currentId ORDER BY id ASC LIMIT 1;";
            DataTable table = GetDataTable(query, new MySqlParameter("@currentId", currentId));
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }
        public DataRow? GetPreviousRecord(string tableName, int currentId)
        {
            string query = $"SELECT * FROM {tableName} WHERE id < @currentId ORDER BY id DESC LIMIT 1;";
            DataTable table = GetDataTable(query, new MySqlParameter("@currentId", currentId));
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }
    }
}