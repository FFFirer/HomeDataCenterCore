using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeDataCenterCore.Domain.AppSettings
{
    public class SqlConnectionOption
    {
        public List<ConnectionOption> ConnectionStrings { get; set; }
        public ConnectionOption this[string name]
        {
            get
            {
                return ConnectionStrings.Where(c => c.Name.Equals(name)).FirstOrDefault();
            }
        }
    }

    public class ConnectionOption
    {
        /// <summary>
        /// 配置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionsString { get; set; }
        /// <summary>
        /// 提供程序："Mysql.Data.MysqlClient/System.Data.SqlClient"
        /// </summary>
        public string ProviderName { get; set; }
    }
}
