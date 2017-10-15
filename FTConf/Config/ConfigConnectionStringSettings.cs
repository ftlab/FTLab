using System;
using System.Configuration;

namespace FTConf.Config
{
    /// <summary>
    /// Настройки строки соединения .config
    /// </summary>
    public class ConfigConnectionStringSettings : IConnectionStringSettings
    {
        private readonly ConnectionStringSettings _config;

        public ConfigConnectionStringSettings(
            ConnectionStringSettings config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public string Name => Config.Name;

        public string ProviderName => Config.Name;

        public string ConnectionString => Config.ConnectionString;

        public ConnectionStringSettings Config => _config;
    }
}
