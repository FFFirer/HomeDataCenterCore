using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Dapper;
using Microsoft.Extensions.Options;
using HomeDataCenterCore.Domain.AppSettings;
using Microsoft.Extensions.Logging;

namespace HomeDataCenterCore.Services
{
    /// <summary>
    /// 按需获取数据库连接
    /// </summary>
    public class DbHelper
    {
        private ILogger<DbHelper> _logger;
        private ConnectionOption _current;

        /// <summary>
        /// 主要是用来获取数据库连接
        /// </summary>
        /// <param name="options">连接字符串配置</param>
        /// <param name="logger">日志组件</param>
        /// <param name="connectionName">连接字符串名称</param>
        public DbHelper(IOptionsMonitor<SqlConnectionOption> options, ILogger<DbHelper> logger, string connectionName)
        {
            _current = (ConnectionOption)options.CurrentValue[connectionName];
            _logger = logger;
        }
        public IDbConnection GetConnection()
        {
            //ConnectionOption current = _dboption[_current.ConnectionsString];

            try
            {
                switch (_current.ProviderName)
                {
                    case "Mssql":
                        return new SqlConnection(_current.ConnectionString);
                    case "Mysql":
                        return new MySqlConnection(_current.ConnectionString);
                    default:
                        throw new Exception("Not support this provider.Unkown provider.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, $"不支持的ProviderName,{_current?.ProviderName}");
                throw new Exception("Not support this provider.Unkown provider.");
            }
        }
    }
}
