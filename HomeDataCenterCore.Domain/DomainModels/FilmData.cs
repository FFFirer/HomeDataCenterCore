using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HomeDataCenterCore.Domain.DomainModels
{
    public class FilmData
    {
        public int Id { get; set; }
        /// <summary>
        /// 1905网的Id
        /// </summary>
        [Display(Name="1905电影网Id")]
        public int FilmId { get; set; }
        /// <summary>
        /// 电影名称
        /// </summary>
        [Display(Name = "电影名称")]
        public string Name { get; set; }
        /// <summary>
        /// 国别
        /// </summary>
        [Display(Name = "国别")]
        public string Country { get; set; }
        /// <summary>
        /// 语言
        /// </summary>
        [Display(Name = "语言")]
        public string Language { get; set; }
        /// <summary>
        /// 影片类型
        /// </summary>
        [Display(Name = "影片类型")]
        public string FilmType { get; set; }
        /// <summary>
        /// 更多中文名
        /// </summary>
        [Display(Name = "更多中文名")]
        public string OtherCNFilmName { get; set; }
        /// <summary>
        /// 更多英文名
        /// </summary>
        [Display(Name = "更多外文名")]
        public string OtherENFilmName { get; set; }
        /// <summary>
        /// 时长
        /// </summary>
        [Display(Name = "时长")]
        public string PlayTime { get; set; }
        /// <summary>
        /// 色彩
        /// </summary>
        [Display(Name = "色彩")]
        public string Color { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        [Display(Name = "版本")]
        public string PlayType { get; set; }
        /// <summary>
        /// 上映信息
        /// </summary>
        [Display(Name = "上映信息")]
        public string PlayInfo { get; set; }
        /// <summary>
        /// 拍摄时间
        /// </summary>
        [Display(Name = "拍摄时间")]
        public string ShootingTime { get; set; }
        /// <summary>
        /// 拍摄地点
        /// </summary>
        [Display(Name = "拍摄地点")]
        public string FilmingLocation { get; set; }
        /// <summary>
        /// 评分
        /// </summary>
        [Display(Name = "用户评分")]
        public string UserRating { get; set; }
    }
}
