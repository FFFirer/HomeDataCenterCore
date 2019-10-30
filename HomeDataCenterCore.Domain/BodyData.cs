using System;

namespace HomeDataCenterCore.Domain
{
    public class BodyData
    {
        public int Id { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime RecordTime { get; set; }
        /// <summary>
        /// 体型
        /// </summary>
        public string Shape { get; set; }
        /// <summary>
        /// 体重，单位：kg
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// BMI
        /// </summary>
        public float BMI { get; set; }
        /// <summary>
        /// 体脂率，%
        /// </summary>
        public float BodyFatPercentage { get; set; }
        /// <summary>
        /// 体水分，%
        /// </summary>
        public float BodyMoisture { get; set; }
        /// <summary>
        /// 骨骼肌率，%
        /// </summary>
        public float SkeletalMuscleRate { get; set; }
        /// <summary>
        /// 肌肉量，单位：kg
        /// </summary>
        public float MuscleMass { get; set; }
        /// <summary>
        /// 骨量，单位：kg
        /// </summary>
        public float BoneMass { get; set; }
        /// <summary>
        /// 去脂体重，单位：kg
        /// </summary>
        public float FatFreeBodyWeight { get; set; }
        /// <summary>
        /// 蛋白质，%
        /// </summary>
        public float Protein { get; set; }
        /// <summary>
        /// 皮下脂肪，%
        /// </summary>
        public float SubcutaneousFat { get; set; }
        /// <summary>
        /// 内脏脂肪等级
        /// </summary>
        public int VisceralFatGrade { get; set; }
        /// <summary>
        /// 体年龄，单位：岁/year
        /// </summary>
        public float BodyAge { get; set; }
        /// <summary>
        /// 基础代谢，单位：kcal
        /// </summary>
        public float BasalMetabolism { get; set; }
    }
}
