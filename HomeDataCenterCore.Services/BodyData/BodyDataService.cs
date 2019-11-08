using System;
using System.Collections.Generic;
using System.Text;
using HomeDataCenterCore.Services.DB;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using HomeDataCenterCore.Domain.AppSettings;
using HomeDataCenterCore.Domain;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace HomeDataCenterCore.Services
{
    public class BodyDataService : DbHelper, IBodyDataService
    {
        private ILogger<BodyDataService> _logger;
        public BodyDataService(ILogger<BodyDataService> logger, IOptionsMonitor<SqlConnectionOption> options):base(options, logger, "MssqlConnect")
        {

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
                using (IDbConnection connection = new SqlConnection(ConnectString))
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
        public async Task<Tuple<IEnumerable<BodyDataViewModel>, int>> GetAllBodyDataByPage(int page, int count)
        {
            return await Task.Factory.StartNew(() =>
            {
                return new Tuple<IEnumerable<BodyDataViewModel>, int>(null, 0);
            });
        }
    }
}
