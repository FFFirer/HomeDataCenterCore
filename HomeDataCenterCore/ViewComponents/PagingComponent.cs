using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeDataCenterCore.Domain;

namespace HomeDataCenterCore.ViewComponents
{
    public class PagingViewComponent : ViewComponent
    {
        public PagingViewComponent(PagingInfo paging)
        {
            
        }

        public async Task<IViewComponentResult> InvokeAsync(Func<int, string> paging, PagingInfo pagingInfo)
        {
            List<PageLink> urls = new List<PageLink>();
            PageLink FirstLink = new PageLink()
            {
                url = paging(1),
                Disable = pagingInfo.CurrentPage > 1 ? false : true
            };
            PageLink PreLink = new PageLink()
            {
                url = (pagingInfo.CurrentPage - 1) < 1 ? "javascript(0);" : paging(pagingInfo.CurrentPage),
                Disable = (pagingInfo.CurrentPage - 1) > 1 ? false : true
            };
            PageLink NextLink = new PageLink()
            {
                url = (pagingInfo.CurrentPage + 1) > pagingInfo.PageCount ? "javascript(0);" : paging(pagingInfo.CurrentPage + 1),
                Disable = (pagingInfo.CurrentPage + 1) > pagingInfo.PageCount
            };
            PageLink LastLink = new PageLink()
            {
                url = pagingInfo.CurrentPage > pagingInfo.PageCount ? "javascript(0);" : paging(pagingInfo.PageCount),
                Disable = (pagingInfo.CurrentPage + 1) > pagingInfo.PageCount
            };
            urls.Add(FirstLink);
            urls.Add(PreLink);
            urls.Add(NextLink);
            urls.Add(LastLink);
            return View(urls);
        }
    }
}
