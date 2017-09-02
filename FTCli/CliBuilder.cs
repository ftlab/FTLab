using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCli
{
    public class CliBuilder
    {
        private Func<ICli> _build;

        private IFormatter _formatter;

        public CliBuilder UseCli(Func<ICli> build)
        {
            _build = build;
            return this;
        }

        public CliBuilder UseFormatter(IFormatter formatter)
        {
            _formatter = formatter;
            return this;
        }

        public ICli Build()
        {
            var result = _build?.Invoke();
            result?.UseFormaterr(_formatter);
            return result;
        }
    }
}
