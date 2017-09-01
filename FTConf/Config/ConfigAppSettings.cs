using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace FTConf.Config
{
    public class ConfigAppSettings : IAppSettings
    {
        private readonly ConfigConfiguration _config;

        public ConfigAppSettings(ConfigConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public string this[string name] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IConfigProfile Profile { get; set; }

        public IConfiguration Configuration => _config;

        public string Name => throw new NotImplementedException();
    }
}