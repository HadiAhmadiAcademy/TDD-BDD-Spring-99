namespace Sample.Logging
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string errorMessage);
    }
}