using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTBus.Extensibility
{
    /// <summary>
    /// Контекстно-зависимый мешок объектов
    /// </summary>
    public interface IReadOnlyContextBag
    {
        /// <summary>
        /// Извлечь объект данного типа из контекста
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Get<T>();

        /// <summary>
        /// Извлечь объект данного типа из контекста по ключу
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key);

        /// <summary>
        /// Попытка извлчеь объект данного типа из контекста
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryGet<T>(out T result);

        /// <summary>
        /// Попытка извлчеь объект данного типа из контекста по ключу
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryGet<T>(string key, out T result);
    }
}
