using Sample.Logging;

namespace Sample.Tests.TestDoubles
{
    public class DummyLogger : ILogger
    {
        public void Info(string message) { }
        public void Error(string errorMessage) { }
    }
}