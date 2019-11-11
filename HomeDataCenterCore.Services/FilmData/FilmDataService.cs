using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HomeDataCenterCore.Domain.DomainModels;
using HomeDataCenterCore.Domain.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using HomeDataCenterCore.Domain.AppSettings;
using HomeDataCenterCore.Domain;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace HomeDataCenterCore.Services
{
    public class FilmDataService : DbHelper, IFilmDataService
    {
        private ILogger<FilmDataService> _logger;

        public FilmDataService(ILogger<FilmDataService> logger, IOptionsMonitor<SqlConnectionOption> options)
            :base(options, logger, "FilmDataDb")
        {
            _logger = logger;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="page">页数</param>
        /// <param name="count">分页大小</param>
        /// <returns></returns>
        public async Task<IEnumerable<FilmDataViewModel>> GetFilmDataByPage(int page, int count = 20)
        {
            int ignoreRows = (page - 1) * count;
            string sql = "SELECT TOP " + count + " * FROM(SELECT ROW_NUMBER() OVER(ORDER BY Id) AS rows, Id, Name, Country, Language, FilmType, PlayType, UserRating FROM dbo.Film1905) b WHERE b.rows>@ignoreRows";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ignoreRows", ignoreRows);

            return await Task.Factory.StartNew(() =>
            {
                try
                {
                    using (IDbConnection connection = this.GetConnection())
                    {
                        IEnumerable<FilmDataViewModel> result = connection.Query<FilmDataViewModel>(sql, parameters);
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Query film data, page:{page}, count:{count}");
                    return null;
                }
            });
        }

        /// <summary>
        /// 获取电影数量总数
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetFilmDataCount()
        {
            string sql = "SELECT COUNT(1) FROM dbo.Film1905";
            return await Task.Factory.StartNew(() =>
            {
                try
                {
                    using (IDbConnection connection = this.GetConnection())
                    {
                        int count = connection.Query<int>(sql).FirstOrDefault();
                        return count;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Query film count");
                    return 0;
                }
            });
        }

        /// <summary>
        /// 根据Id获取详细信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<FilmData> GetFilmDetailById(int Id)
        {
            string sql = "SELECT * FROM dbo.Film1905 WHERE Id=@Id";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", Id);

            return await Task.Factory.StartNew(() =>
            {
                try
                {
                    using (IDbConnection connection = this.GetConnection())
                    {
                        FilmData film = connection.Query<FilmData>(sql, parameters).FirstOrDefault();
                        return film;
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Query film, Id:{Id}");
                    return null;
                }
            });
        }
    }
}
