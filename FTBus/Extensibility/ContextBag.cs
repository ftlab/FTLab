using System.Collections.Generic;

namespace FTBus.Extensibility
{
    /// <summary>
    /// Мешок объектов
    /// </summary>
    public class ContextBag : IReadOnlyContextBag
    {
        private readonly ContextBag _parentBag;

        private readonly Dictionary<string, object> _stash = new Dictionary<string, object>();

        /// <summary>
        /// Создает экземпляр <see cref="ContextBag" />.
        /// </summary>
        public ContextBag(ContextBag parentBag = null)
        {
            _parentBag = parentBag;
        }

        /// <summary>
        /// Копилка
        /// </summary>
        private Dictionary<string, object> Stash => _stash;

        /// <summary>
        /// Родительский мешок
        /// </summary>
        private ContextBag ParentBag => _parentBag;

        /// <summary>
        /// Получить объект
        /// </summary>
        /// <typeparam name="T">тип объекта</typeparam>
        /// <returns>экземпляр</returns>
        public T Get<T>()
        {
            return Get<T>(typeof(T).FullName);
        }

        /// <summary>
        /// Попробовать получить объект
        /// </summary>
        /// <typeparam name="T">тип объекта</typeparam>
        /// <param name="result">экземпляр</param>
        /// <returns></returns>
        public bool TryGet<T>(out T result)
        {
            return TryGet(typeof(T).FullName, out result);
        }

        /// <summary>
        /// Попробоовать получить объект по ключу
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool TryGet<T>(string key, out T result)
        {
            Guard.AgainstNullAndEmpty(nameof(key), key);
            if (Stash.TryGetValue(key, out var value))
            {
                result = (T)value;
                return true;
            }

            if (ParentBag != null)
                return ParentBag.TryGet(key, out result);

            result = default(T);
            return false;
        }

        /// <summary>
        /// Получить объект
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Get<T>(string key)
        {
            Guard.AgainstNullAndEmpty(nameof(key), key);

            if (!TryGet(key, out T result))
                throw new KeyNotFoundException("No item found in behavior context with key: " + key);

            return result;
        }

        /// <summary>
        /// Получить объект, в случае его отстутствия - создать
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetOrCreate<T>()
            where T : class, new()
        {
            if (TryGet(out T value))
                return value;

            var newInstance = new T();
            Set(newInstance);
            return newInstance;
        }

        /// <summary>
        /// Вставить в мешок
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void Set<T>(T t)
        {
            Set(typeof(T).FullName, t);
        }


        /// <summary>
        /// Удалить из мешка
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void Remove<T>()
        {
            Remove(typeof(T).FullName);
        }

        /// <summary>
        /// Удалить из мешка по ключу
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            Guard.AgainstNullAndEmpty(nameof(key), key);
            Stash.Remove(key);
        }

        /// <summary>
        /// Вставить в мешок по ключу
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="t"></param>
        public void Set<T>(string key, T t)
        {
            Guard.AgainstNullAndEmpty(nameof(key), key);
            Stash[key] = t;
        }

        /// <summary>
        /// Перенести объекты из мешка
        /// </summary>
        /// <param name="context"></param>
        internal void Merge(ContextBag context)
        {
            foreach (var kvp in context.Stash)
            {
                Stash[kvp.Key] = kvp.Value;
            }
        }
    }
}
