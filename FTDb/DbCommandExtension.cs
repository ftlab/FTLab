using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace FTDb
{
    /// <summary>
    /// методы расширяющие DbCommand
    /// </summary>
    public static class DbCommandExtension
    {
        /// <summary>
        /// Исполняет запрос и возвращает значение первой колонки первой строки
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static async Task<T> ExecuteScalarAsync<T>(this DbCommand cmd)
        {
            if (cmd == null) throw new ArgumentNullException(nameof(cmd));
            var result = await cmd.ExecuteScalarAsync();
            if (Convert.IsDBNull(result))
            {
                result = null;
            }
            return (T)result;
        }

        /// <summary>
        /// Исполняет запрос и возвращает значение первой колонки первой строки
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static T ExecuteScalar<T>(this DbCommand cmd)
        {
            if (cmd == null) throw new ArgumentNullException(nameof(cmd));
            var result = cmd.ExecuteScalar();
            if (Convert.IsDBNull(result))
            {
                result = null;
            }
            return (T)result;
        }

        /// <summary>
        /// Исполняет запрос и возвращает итератор с записями
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="behavior"></param>
        /// <returns></returns>
        public static IEnumerable<IDataRecord> ExecuteReader(this DbCommand cmd
            , CommandBehavior behavior = CommandBehavior.Default)
        {
            if (cmd == null) throw new ArgumentNullException(nameof(cmd));

            using (var reader = cmd.ExecuteReader(behavior))
            {
                while (reader.Read())
                    yield return reader;
            }
        }

        /// <summary>
        /// Исполняет запрос и возвращает итератор с записями
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="cmd"></param>
        /// <param name="behavior"></param>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteReader<T>(this DbCommand cmd
            , Func<IDataReader,T> map
            , CommandBehavior behavior = CommandBehavior.Default)
        {
            if (cmd == null) throw new ArgumentNullException(nameof(cmd));
            if (map == null) throw new ArgumentNullException(nameof(map));

            using (var reader = cmd.ExecuteReader(behavior))
            {
                while (reader.Read())
                    yield return map(reader);
            }
        }

        /// <summary>
        /// Добавить параметр
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="init"></param>
        /// <returns></returns>
        public static DbParameter AddParameter(this DbCommand cmd
            , Action<DbParameter> init)
        {
            if (cmd == null) throw new ArgumentNullException(nameof(cmd));
            if (init == null) throw new ArgumentNullException(nameof(init));
            var parameter = cmd.CreateParameter();
            init?.Invoke(parameter);
            cmd.Parameters.Add(parameter);
            return parameter;
        }
    }
}
