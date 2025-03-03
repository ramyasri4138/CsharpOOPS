using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public sealed class ConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> _instance =
            new Lazy<ConfigurationManager>(() => new ConfigurationManager());

        // Private constructor to prevent instantiation
        private ConfigurationManager()
        {
            // Load configuration settings here
        }

        public static ConfigurationManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        // Example method to get configuration value
        public string GetConfigValue(string key)
        {
            // Retrieve configuration value by key
            return "ConfigValue"; // Placeholder, replace with actual implementation
        }
    }
}
