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
    public static partial class DbCommandExtension
    {
        /// <summary>
        /// Добавить параметр
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="init"></param>
        /// <returns></returns>
        public static DbCommand AddParameter(this DbCommand cmd
            , Action<DbParameter> init)
        {
            if (cmd == null) throw new ArgumentNullException(nameof(cmd));
            var parameter = cmd.CreateParameter();
            init?.Invoke(parameter);
            cmd.Parameters.Add(parameter);
            return cmd;
        }
    }
}
