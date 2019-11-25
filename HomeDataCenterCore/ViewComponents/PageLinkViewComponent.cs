using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeDataCenterCore.Domain;
using HomeDataCenterCore.Domain.ViewModels;

namespace HomeDataCenterCore.ViewComponents
{
    public class PageLinkViewComponent : ViewComponent
    {
        public PageLinkViewComponent()
        {
            
        }

        public async Task<IViewComponentResult> InvokeAsync(string controller, string action, PagingInfo pagingInfo)
        {
            PagingViewModel model = await Task.Factory.StartNew(() =>
            {
                PagingViewModel viewmodel = new PagingViewModel();

                viewmodel.controller = controller;
                viewmodel.action = action;
                viewmodel.FirstIndex = pagingInfo.CurrentPage == 1 ? 0 : 1;
                viewmodel.PreIndex = pagingInfo.CurrentPage <= 1 ? 0 : pagingInfo.CurrentPage - 1;
                viewmodel.NextIndex = pagingInfo.CurrentPage >= pagingInfo.PageCount ? 0 : pagingInfo.CurrentPage + 1;
                viewmodel.LastIndex = pagingInfo.CurrentPage >= pagingInfo.PageCount ? 0 : pagingInfo.PageCount;
                viewmodel.Summary = $"共{pagingInfo.TotalCount}条记录,第{pagingInfo.CurrentPage}/{pagingInfo.PageCount}页";

                int IndexCount = 7;
                int StartIndex = pagingInfo.CurrentPage;
                int EndIndex = pagingInfo.CurrentPage;

                // 确定当前页前面的页数
                if ((StartIndex - IndexCount / 2) <= 0)
                {
                    StartIndex = 1;
                }
                else
                {
                    StartIndex = StartIndex - IndexCount / 2;
                }

                // 确定当前页后面的页数(此时前面的页数小于等于一半)
                int tempIndexCount = IndexCount - (pagingInfo.CurrentPage - StartIndex + 1);
                if (EndIndex + tempIndexCount >= pagingInfo.PageCount)
                {
                    EndIndex = pagingInfo.PageCount;
                }
                else
                {
                    EndIndex = EndIndex + tempIndexCount;
                }

                // 检查页数是否已满，不够的从前面取
                int NeedCount = IndexCount - (EndIndex - StartIndex + 1);
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
                for (int i = StartIndex; i <= EndIndex; i++)
                {
                    if (i == pagingInfo.CurrentPage)
                    {
                        viewmodel.PageLinks.Add(i, string.Empty);
                    }
                    else
                    {
                        viewmodel.PageLinks.Add(i, i.ToString());
                    }
                }

                return viewmodel;
            });
            return View(model);
        }
    }
}