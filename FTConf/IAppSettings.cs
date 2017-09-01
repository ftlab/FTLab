using System.Collections.Generic;

namespace FTConf
{
    public interface IAppSettings
    {
        string this[string name] { get; set; }

        IDictionary<string, IAppSettings> Groups { get; }
    }
}
