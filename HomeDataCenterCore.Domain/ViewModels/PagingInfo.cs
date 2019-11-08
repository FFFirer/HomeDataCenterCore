using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDataCenterCore.Domain
{
    /// <summary>
    /// 分页信息
    /// </summary>
    public class PagingInfo
    {
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        
    }

    public class PageLink
    {
        public string url { get; set; }
        public bool Disable { get; set; }
    }
}
