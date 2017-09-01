using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTConf
{
    public class ConfBuilder
    {
        private IConf _configuration;

        public ConfBuilder UseConf(Func<IConf> create)
        {
            _configuration = create.Invoke();
            return this;
        }

        public IConf Build()
        {
            return _configuration;
        }
    }
}
