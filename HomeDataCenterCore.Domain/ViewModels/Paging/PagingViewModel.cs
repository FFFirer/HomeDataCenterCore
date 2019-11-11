using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDataCenterCore.Domain.ViewModels
{
    public class PageLink
    {
        public string url { get; set; }
        public List<string> ClassAttribute { get; set; }
    }

    public class PagingViewModel
    {
        public string FirstUrl { get; set; }
        public string PreLink { get; set; }
        public string NextLink { get; set; }
        public string LastLink { get; set; }
        public Dictionary<int, string> PageLinks { get; set; }
        public string Summary { get; set; }
    }
}
