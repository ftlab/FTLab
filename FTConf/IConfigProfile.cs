using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTConf
{
    public interface IConfigProfile
    {
        void GetAppSetting(string config, string name, string value);

        void SetAppSetting(string config, string name, string value);
    }
}
