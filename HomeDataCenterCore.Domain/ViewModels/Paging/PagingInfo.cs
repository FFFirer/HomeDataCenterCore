using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDataCenterCore.Domain.ViewModels
{
    /// <summary>
    /// 分页信息
    /// </summary>
    public class PagingInfo
    {
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        private int _totalcount { get; set; }
        public int TotalCount
        {
            get
            {
                return _totalcount;
            }
            set
            {
                _totalcount = value;
                PageCount = (int)Math.Ceiling((decimal)TotalCount / (decimal)PageSize);
            }
        }
    }
}
