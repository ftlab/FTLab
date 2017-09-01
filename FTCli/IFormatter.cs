using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCli
{
    public interface IFormatter
    {
        string Format(object value);
    }
}
