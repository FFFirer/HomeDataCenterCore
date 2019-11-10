using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeDataCenterCore.Domain;
using HomeDataCenterCore.Domain.ViewModels;

namespace HomeDataCenterCore.ViewComponents
{
    public class PagingViewComponent : ViewComponent
    {
        public PagingViewComponent(PagingInfo paging)
        {
            
        }

        public async Task<IViewComponentResult> InvokeAsync(Func<int, string> paging, PagingInfo pagingInfo)
        {
            PagingViewModel viewmodel = new PagingViewModel();
            if(pagingInfo.CurrentPage == 1)
            {
                viewmodel.FirstUrl = string.Empty;
            }
            else
            {
                viewmodel.FirstUrl = paging(1);
            }
            viewmodel.FirstUrl = pagingInfo.CurrentPage == 1 ? string.Empty : paging(1);
            viewmodel.PreLink = pagingInfo.CurrentPage <= 1 ? string.Empty : paging(pagingInfo.CurrentPage-1);
            viewmodel.NextLink = pagingInfo.CurrentPage >= pagingInfo.PageCount ? string.Empty : paging(pagingInfo.CurrentPage + 1);
            viewmodel.LastLink = pagingInfo.CurrentPage >= pagingInfo.PageCount ? string.Empty : paging(pagingInfo.PageCount);
            viewmodel.Summary = $"共{pagingInfo.TotalCount}条记录,第{pagingInfo.CurrentPage}/{pagingInfo.PageCount}页";

            

            return View(viewmodel);
        }
    }
}
