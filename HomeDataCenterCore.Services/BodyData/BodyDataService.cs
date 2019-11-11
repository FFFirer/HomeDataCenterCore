using System;
using System.Collections.Generic;
using System.Text;
using HomeDataCenterCore.Services.DB;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using HomeDataCenterCore.Domain.AppSettings;
using HomeDataCenterCore.Domain;
using HomeDataCenterCore.Domain.ViewModels;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace HomeDataCenterCore.Services
{
    public class BodyDataService : DbHelper, IBodyDataService
    {
        private ILogger<BodyDataService> _logger;
        public BodyDataService(ILogger<BodyDataService> logger, IOptionsMonitor<SqlConnectionOption> options)
            :base(options, logger, "HomeDataDb")
        {
            _logger = logger;
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> AddBodyData(BodyDataViewModel model)
        {
            return await Task.Factory.StartNew(() =>
            {
                string sql = @"insert into BodyData(RecordTime, Shape, Weight, BMI, BodyFatPercentage, BodyMoisture, SkeletalMuscleRate, MuscleMass, BoneMass, FatFreeBodyWeight, Protein, SubcutaneousFat, VisceralFatGrade, BasalMetabolism, BodyAge) " +
                            @"values(@RecordTime, @Shape, @Weight, @BMI, @BodyFatPercentage, @BodyMoisture, @SkeletalMuscleRate, @MuscleMass, @BoneMass, @FatFreeBodyWeight, @Protein, @SubcutaneousFat, @VisceralFatGrade, @BasalMetabolism, @BodyAge)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("RecordTime", model.RecordTime);
                parameters.Add("Shape", model.Shape);
                parameters.Add("Weight", model.Weight);
                parameters.Add("BMI", model.BMI);
                parameters.Add("BodyFatPercentage", model.BodyFatPercentage);
                parameters.Add("BodyMoisture", model.BodyMoisture);
                parameters.Add("SkeletalMuscleRate", model.SkeletalMuscleRate);
                parameters.Add("MuscleMass", model.MuscleMass);
                parameters.Add("BoneMass", model.BoneMass);
                parameters.Add("FatFreeBodyWeight", model.FatFreeBodyWeight);
                parameters.Add("Protein", model.Protein);
                parameters.Add("SubcutaneousFat", model.SubcutaneousFat);
                parameters.Add("VisceralFatGrade", model.VisceralFatGrade);
                parameters.Add("BasalMetabolism", model.BasalMetabolism);
                parameters.Add("BodyAge", model.BodyAge);

                try
                {
                    using (IDbConnection conn = this.GetConnection())
                    {
                        int rows = conn.Execute(sql, parameters);
                        if (rows > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            });

        }

        /// <summary>
        /// 获取所有BodyData
        /// </summary>
        /// <returns></returns>
        public async Task<Tuple<IEnumerable<BodyDataViewModel>, int>> GetAllBodyData()
        {
            return await Task.Factory.StartNew(() =>
            {
                string sql = "select * from BodyData";
                using (IDbConnection connection = this.GetConnection())
                {
                    var data = connection.Query<BodyDataViewModel>(sql);
                    Tuple<IEnumerable<BodyDataViewModel>, int> result = new Tuple<IEnumerable<BodyDataViewModel>, int>(data, data.Count());
                    return result;
                }
            });
        }

        /// <summary>
        /// 获取BodyData（分页）
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public async Task<IEnumerable<BodyDataViewModel>> GetAllBodyDataByPage(int page, int count = 20)
        {
            return await Task.Factory.StartNew(() =>
            {
                int ignoreRows = (page - 1) * count;
                // 获取指定行数，以日期排序
                string sql = "select top @count * from (select row_numbers over (order by RecordTime) as rows,* from BodyData) as b where b.rows>@ignoreRows";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("count", count);
                parameters.Add("ignoreRows", ignoreRows);
                try
                {
                    using (IDbConnection connection = this.GetConnection())
                    {
                        IEnumerable<BodyDataViewModel> result = connection.Query<BodyDataViewModel>(sql, parameters);
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    this._logger.LogError(ex, $"Query BodyData, page:{page}, count:{count}");
                    return null;
                }
            });
        }

        /// <summary>
        /// 获取BodyData总数
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetBodyDataCount()
        {
            return await Task.Factory.StartNew(() =>
            {
                string sql = "select count(1) from BodyData";
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
                    this._logger.LogError(ex, "Query BodyData count");
                    return 0;
                }
            });
        }
    }
}
