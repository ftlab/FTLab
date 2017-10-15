using System.Collections.Generic;

namespace FTConf
{
    /// <summary>
    /// Настройки
    /// </summary>
    public interface IAppSettings
    {
        /// <summary>
        /// профайлер
        /// </summary>
        IConfProfile Profile { get; set; }

        /// <summary>
        /// Конфигурация
        /// </summary>
        IConf Configuration { get; }

        /// <summary>
        /// Имя группы
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Доступ к настройке
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        string this[string name] { get; set; }
    }
}
