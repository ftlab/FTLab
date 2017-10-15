using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTConf
{
    public interface IConfProfile
    {
        void GetAppSetting(string confName, string name, string value);

        void SetAppSetting(string confName, string name, string value);
    }
}
