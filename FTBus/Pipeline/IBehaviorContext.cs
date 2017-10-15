using FTBus.Extensibility;
using FTBus.ObjectBuilder;

namespace FTBus.Pipeline
{
    /// <summary>
    /// Интерфейс конвейерного поведения
    /// </summary>
    public interface IBehaviorContext : IExtendable
    {
        /// <summary>
        /// Построитель <see cref="IBuilder" />.
        /// </summary>
        IBuilder Builder { get; }
    }
}
