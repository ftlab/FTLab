namespace FTBus.Extensibility
{
    /// <summary>
    /// Помечает класс как расширяемый, предоставляя досту к мешку <see cref="ContextBag" />.
    /// </summary>
    public interface IExtendable
    {
        /// <summary>
        /// <see cref="ContextBag" /> расширяет текущий объект
        /// </summary>
        ContextBag Extensions { get; }
    }
}
