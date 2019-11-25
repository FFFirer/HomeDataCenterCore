using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using HomeDataCenterCore.Models;

namespace HomeDataCenterCore.Services
{
    public class BodyDataDAL : IBodyDataDAL
    {
        public string ConnectString = "Data Source=192.168.1.2;Initial Catalog=HomeData;User ID=sa;Password=1qaz@WSX3edc";

        /// <summary>
        /// 添加一条数据
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
                    using (IDbConnection conn = new SqlConnection(ConnectString))
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
        /// 获取所有数据
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
        /// 根据分页获取数据
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
