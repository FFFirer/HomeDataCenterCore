using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDataCenterCore.Domain.ViewModels
{
    public class IndexViewModel
    {
        public PagingInfo paginginfo { get; set; }
        public List<BodyDataViewModel> BodyData { get; set; }
    }
}
