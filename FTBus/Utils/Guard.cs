using System;
using System.Collections;
using System.Linq;

namespace FTBus
{
    /// <summary>
    /// Проверка переменных, аргументов, типов
    /// </summary>
    static class Guard
    {
        /// <summary>
        /// Проверка на Null
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="value"></param>
        public static void AgainstNull(string argumentName, object value)
        {
            if (value == null)
                throw new ArgumentNullException(argumentName);
        }

        /// <summary>
        /// Проверка на Null or Empty строку
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="value"></param>
        public static void AgainstNullAndEmpty(string argumentName, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(argumentName);
        }

        /// <summary>
        /// Проверка на Null or Empty коллекцию
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="value"></param>
        public static void AgainstNullAndEmpty(string argumentName, ICollection value)
        {
            if (value == null)
                throw new ArgumentNullException(argumentName);
            if (value.Count == 0)
                throw new ArgumentOutOfRangeException(argumentName);
        }

        /// <summary>
        /// Проверка на отрицательное или 0 значение целового числа
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="value"></param>
        public static void AgainstNegativeAndZero(string argumentName, int value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(argumentName);
        }

        /// <summary>
        /// Проверка на отрицательное значение целового числа
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="value"></param>
        public static void AgainstNegative(string argumentName, int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(argumentName);
        }

        /// <summary>
        /// Проверка на отрицательное или 0 значение TimeSpan
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="value"></param>
        public static void AgainstNegativeAndZero(string argumentName, TimeSpan value)
        {
            if (value <= TimeSpan.Zero)
                throw new ArgumentOutOfRangeException(argumentName);
        }

        /// <summary>
        /// Проверка на отрицательное значение TimeSpan
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="value"></param>
        public static void AgainstNegative(string argumentName, TimeSpan value)
        {
            if (value < TimeSpan.Zero)
                throw new ArgumentOutOfRangeException(argumentName);
        }
    }
}
