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

            int IndexCount = 7;
            int StartIndex = pagingInfo.CurrentPage;
            int EndIndex = pagingInfo.CurrentPage;
            // 确定当前页前面的页数
            if((StartIndex - IndexCount/2) <= 0)
            {
                StartIndex = 1;
            }
            else
            {
                StartIndex = StartIndex - IndexCount / 2;
            }
            // 确定当前页后面的页数(此时前面的页数小于等于一半)
            int tempIndexCount = IndexCount - (pagingInfo.CurrentPage - StartIndex + 1);
            if(EndIndex + tempIndexCount >= pagingInfo.PageCount)
            {
                EndIndex = pagingInfo.PageCount;
            }
            else
            {
                EndIndex = EndIndex = tempIndexCount;
            }
            // 检查页数是否已满，不够的从前面取
            int NeedCount = IndexCount - (StartIndex - EndIndex + 1);
            if (NeedCount > 0)
            {
                if (StartIndex - NeedCount <= 0)
                {
                    StartIndex = 1;
                }
                else
                {
                    StartIndex = StartIndex - NeedCount;
                }
            }
            // 插入字典
            for(int i = StartIndex; i <= EndIndex; i++)
            {
                if (i == pagingInfo.CurrentPage)
                {
                    viewmodel.PageLinks.Add(i, string.Empty);
                }
                else
                {
                    viewmodel.PageLinks.Add(i, paging(1));
                }
            }

            return View(viewmodel);
        }
    }
}