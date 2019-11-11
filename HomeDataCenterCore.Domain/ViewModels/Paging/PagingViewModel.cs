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
        public string controller { get; set; }
        public string action { get; set; }
        public int FirstIndex { get; set; }
        public int PreIndex { get; set; }
        public int NextIndex { get; set; }
        public int LastIndex { get; set; }
        public Dictionary<int, string> PageLinks { get; set; } = new Dictionary<int, string>();
        public string Summary { get; set; }
    }
}
