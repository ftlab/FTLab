using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTBus.Pipeline
{
    /// <summary>
    /// Интерфейс поведения
    /// </summary>
    public interface IBehavior
    {

    }

    /// <summary>
    /// Интерфейс поведения, регистрируемый к конвейере
    /// </summary>
    /// <typeparam name="TInContext"></typeparam>
    /// <typeparam name="TOutContext"></typeparam>
    public interface IBehavior<in TInContext, out TOutContext> : IBehavior
        where TInContext : IBehaviorContext
        where TOutContext : IBehaviorContext
    {
        /// <summary>
        /// Вызывается при исполнении поведения
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        Task Invoke(TInContext context, Func<TOutContext, Task> next);
    }
}
