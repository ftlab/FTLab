using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTConf
{
    public class ConfigurationBuilder
    {
        private IConfiguration _configuration;

        public ConfigurationBuilder UseConfiguration(Func<IConfiguration> create)
        {
            _configuration = create.Invoke();
            return this;
        }

        public IConfiguration Build()
        {
            return _configuration;
        }
    }
}
