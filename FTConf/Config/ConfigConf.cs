using System;
using System.Configuration;

namespace FTConf.Config
{
    public class ConfigConf : IConf
    {
        public ConfigConf(
            Configuration config)
        {

        }

        public string Name => throw new NotImplementedException();

        public IAppSettings Settings => throw new NotImplementedException();
    }
}
