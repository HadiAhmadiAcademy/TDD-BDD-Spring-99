namespace UOM.Config.ConnectionManagement
{
    public interface IConnectionManager
    {
        string GetConnectionString();
        void OverrideConnectionString(string connectionString);
    }
}