using System.Data.Common;

namespace FluentDb
{
    /// <summary>
    /// методы расширяющие DbConnection
    /// </summary>
    public static partial class DbConnectionExtension
    {
        /// <summary>
        /// Выполнить запрос
        /// </summary>
        /// <param name="con"></param>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static DbConnection ExecuteNonQuery(this DbConnection con
            , DbCommand cmd)
        {
            cmd.ExecuteNonQuery();
            return con;
        }

        /// <summary>
        /// Выполнить запрос
        /// </summary>
        /// <param name="con"></param>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static DbConnection ExecuteNonQuery(this DbConnection con
            , string cmdText)
        {
            using (var cmd = con.CreateCommand())
                return con.ExecuteNonQuery(cmd.SetCommandText(cmdText));
        }
    }
}
