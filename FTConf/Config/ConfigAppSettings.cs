using System;
using System.Collections.Generic;
using System.Configuration;

namespace FTConf.Config
{
    public class ConfigAppSettings : IAppSettings
    {
        private readonly AppSettingsSection _config;

        public ConfigAppSettings(
            AppSettingsSection config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public string this[string name]
        {
            get => Config.Settings[name]?.Value;
            set => Config.Settings[name].Value = value;
        }

        public IDictionary<string, IAppSettings> Groups => throw new NotImplementedException();

        public AppSettingsSection Config => _config;
    }
}
