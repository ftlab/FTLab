namespace FTBus.ObjectBuilder
{
    /// <summary>
    /// Представляет различные жизненные циклы доступные для компонент, сконфигурированных в контейнере
    /// </summary>
    public enum DependencyLifecycle
    {
        /// <summary>
        /// Возвращается один и тотже компонент в любой момент
        /// </summary>
        SingleInstance,

        /// <summary>
        /// Возвращается один и тотже компонент на время единицы работы.
        /// Например, при обработке одного транспортного сообщения
        /// </summary>
        InstancePerUnitOfWork,

        /// <summary>
        /// Возврщается всегда новый экземпляр компоненты при вызове
        /// </summary>
        InstancePerCall
    }
}
