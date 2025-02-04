using System.Data;
using MySqlConnector;

namespace Aniflix.Factory
{
    public class ConnectionFactory
    {
        private static ConnectionFactory? _instance;
        private readonly MySqlConnection _connection;
        private const string ConnectionString = "Server=localhost;Database=aniflix;Username=Covenant9687;Password=v*##GLBkB3r9tuUt;";

        private ConnectionFactory()
        {
            _connection = new MySqlConnection(ConnectionString);
            _connection.Open();
        }

        public static ConnectionFactory GetInstance()
        {
            _instance ??= new ConnectionFactory();
            return _instance;
        }

        public IDbConnection GetConnection()
        {
            return _connection;
        }
    }
}
