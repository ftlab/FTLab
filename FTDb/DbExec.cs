using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace FTDb
{
    /// <summary>
    /// Легковесный доступ к БД
    /// </summary>
    public class DbExec : IDisposable
    {
        private readonly string _connectionString;

        private readonly DbProviderFactory _provider;

        /// <summary>
        /// Создание экземпляра
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="provider"></param>
        public DbExec(
            string connectionString
            , DbProviderFactory provider)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// провайдер
        /// </summary>
        public DbProviderFactory Provider => _provider;

        /// <summary>
        /// Строка соединения
        /// </summary>
        public string ConnectionString => _connectionString;

        /// <summary>
        /// Создать соединение
        /// </summary>
        /// <returns></returns>
        public DbConnection CreateConnection()
        {
            var conn = Provider.CreateConnection();
            conn.ConnectionString = ConnectionString;
            return conn;
        }

        /// <summary>
        /// Очистка ресурсов
        /// </summary>
        public void Dispose()
        {

        }
    }
}
