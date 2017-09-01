using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTConf
{
    /// <summary>
    /// Настройки строки соединения
    /// </summary>
    public interface IConnectionStringSettings
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Провайдер
        /// </summary>
        string ProviderName { get; }

        /// <summary>
        /// Строка соединения
        /// </summary>
        string ConnectionString { get; }
    }
}
