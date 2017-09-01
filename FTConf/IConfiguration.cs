using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTConf
{
    /// <summary>
    /// Конфигурация
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// конфигурация
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Настройки
        /// </summary>
        IAppSettings AppSettings { get; }
    }
}
