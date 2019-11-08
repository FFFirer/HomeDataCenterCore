using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HomeDataCenterCore.Domain
{
    /// <summary>
    /// 身体数据视图模型
    /// </summary>
    public class BodyDataViewModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [Display(Name = "记录时间")]
        public DateTime RecordTime { get; set; }

        /// <summary>
        /// 体型
        /// </summary>
        [Display(Name = "体型")]
        public string Shape { get; set; }

        /// <summary>
        /// 体重，单位：kg
        /// </summary>
        [Display(Name = "体重(kg)")]
        public float Weight { get; set; }

        /// <summary>
        /// BMI
        /// </summary>
        [Display(Name = "BMI")]
        public float BMI { get; set; }

        /// <summary>
        /// 体脂率，%
        /// </summary>
        [Display(Name = "体脂率(%)")]
        public float BodyFatPercentage { get; set; }

        /// <summary>
        /// 体水分，%
        /// </summary>
        [Display(Name = "体水分(%)")]
        public float BodyMoisture { get; set; }

        /// <summary>
        /// 骨骼肌率，%
        /// </summary>
        [Display(Name = "骨骼肌率(%)")]
        public float SkeletalMuscleRate { get; set; }

        /// <summary>
        /// 肌肉量，单位：kg
        /// </summary>
        [Display(Name = "肌肉量(kg)")]
        public float MuscleMass { get; set; }

        /// <summary>
        /// 骨量，单位：kg
        /// </summary>
        [Display(Name = "骨量(kg)")]
        public float BoneMass { get; set; }

        /// <summary>
        /// 去脂体重，单位：kg
        /// </summary>
        [Display(Name = "去脂体重(kg)")]
        public float FatFreeBodyWeight { get; set; }

        /// <summary>
        /// 蛋白质，%
        /// </summary>
        [Display(Name = "蛋白质(%)")]
        public float Protein { get; set; }

        /// <summary>
        /// 皮下脂肪，%
        /// </summary>
        [Display(Name = "皮下脂肪(%)")]
        public float SubcutaneousFat { get; set; }

        /// <summary>
        /// 内脏脂肪等级
        /// </summary>
        [Display(Name = "内脏脂肪等级")]
        public int VisceralFatGrade { get; set; }

        /// <summary>
        /// 体年龄，单位：岁/year
        /// </summary>
        [Display(Name = "体年龄(岁)")]
        public float BodyAge { get; set; }

        /// <summary>
        /// 基础代谢，单位：kcal
        /// </summary>
        [Display(Name = "基础代谢(kcal)")]
        public float BasalMetabolism { get; set; }
    }
}
