using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using UOM.Technical.WebUI.Framework;

namespace UOM.Specs.Configuration
{
    public static class Config
    {
        public static TestConfig Current { get; private set; }
        static Config()
        {
            Current = GetRoot(AppDomain.CurrentDomain.BaseDirectory).Get<TestConfig>();
            Current.ExecutionAssembly = Assembly.Load(Current.ExecutionAssemblyName);
        }

        private static IConfigurationRoot GetRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", true)
                .Build();
        }
    }
}
