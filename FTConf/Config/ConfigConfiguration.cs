using System;
using System.Configuration;

namespace FTConf.Config
{
    public class ConfigConfiguration : IConfiguration
    {
        public ConfigConfiguration(
            Configuration config)
        {

        }

        public string Name => throw new NotImplementedException();

        public IAppSettings AppSettings => throw new NotImplementedException();
    }
}
