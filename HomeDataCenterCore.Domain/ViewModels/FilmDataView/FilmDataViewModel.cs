using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HomeDataCenterCore.Domain.ViewModels
{
    public class FilmDataViewModel
    {
        public int Id { get; set; }
        /// <summary>
        /// 电影名称
        /// </summary>
        [Display(Name="电影名称")]
        public string Name { get; set; }
        /// <summary>
        /// 国别
        /// </summary>
        [Display(Name="国别")]
        public string Country { get; set; }
        /// <summary>
        /// 语言
        /// </summary>
        [Display(Name="语言")]
        public string Language { get; set; }
        /// <summary>
        /// 影片类型
        /// </summary>
        [Display(Name="影片类型")]
        public string FilmType { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        [Display(Name="版本")]
        public string PlayType { get; set; }
        /// <summary>
        /// 评分
        /// </summary>
        [Display(Name="用户评分")]
        public string UserRating { get; set; }
    }
}
