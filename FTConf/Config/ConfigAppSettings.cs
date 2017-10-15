using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace FTConf.Config
{
    public class ConfigAppSettings : IAppSettings
    {
        private readonly ConfigConf _config;

        public ConfigAppSettings(ConfigConf config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public string this[string name] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IConfAudit Profile { get; set; }

        public IConf Configuration => _config;

        public string Name => throw new NotImplementedException();
    }
}