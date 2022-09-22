namespace UOM.Config.ConnectionManagement
{
    public class ConnectionManager : IConnectionManager
    {
        private string _connectionString;
        public ConnectionManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        public void OverrideConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}