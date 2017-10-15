using System;
using System.Collections.Generic;

namespace FTBus.ObjectBuilder
{
    /// <summary>
    /// Используется для создания экземпляров типа, со всеми сконфигурированными зависимостями.
    /// Абстракция внедрения зависимости
    /// </summary>
    public interface IBuilder : IDisposable
    {
        /// <summary>
        /// Возвращает экземпляр указанного типа
        /// </summary>
        /// <param name="typeToBuild">Тип объекта</param>
        /// <returns>Экземпляр типа</returns>
        object Build(Type typeToBuild);

        /// <summary>
        /// Возвращает дочерний экземпляр контейнера для облегчения детерминированной очистки
        /// ресурсов задействованных в  дочернем контейнере
        /// </summary>
        /// <returns>Возвращает новый дочерний контейнер</returns>
        IBuilder CreateChildBuilder();

        /// <summary>
        /// Возвращает экземпляр указанного типа с внедренными зависимостями
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <returns>Экземпляр типа <typeparamref name="T" />.</returns>
        T Build<T>();

        /// <summary>
        /// Для всех типов, которые совместимы с T, создается экземпляр со всеми внедренными зависимостями, и возвращает итератор
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <returns>Экземпляры типа <typeparamref name="T" />.</returns>
        IEnumerable<T> BuildAll<T>();

        /// <summary>
        /// Для всех типов, которые совместимы с данным типом, создается экземпляр со всеми внедренными зависимостями, и возвращает итератор
        /// </summary>
        /// <param name="typeToBuild">Тип <see cref="Type" /> для построения</param>
        /// <returns>Экземпляры компонент</returns>
        IEnumerable<object> BuildAll(Type typeToBuild);

        /// <summary>
        /// Освободить экземпляр компоненты
        /// </summary>
        /// <param name="instance">Экземпляр компоненты</param>
        void Release(object instance);

        /// <summary>
        /// Создает экземпляр указанного типа со всеми определяемыми зависимостями
        /// и передает экземпляр в делегат
        /// </summary>
        /// <param name="typeToBuild">Тип <see cref="Type" /> для построения</param>
        /// <param name="action">Обслуживающий делегат</param>
        void BuildAndDispatch(Type typeToBuild, Action<object> action);
    }
}
