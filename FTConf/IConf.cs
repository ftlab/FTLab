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
    public interface IConf
    {
        /// <summary>
        /// конфигурация
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Настройки
        /// </summary>
        IAppSettings Settings { get; }
    }
}
