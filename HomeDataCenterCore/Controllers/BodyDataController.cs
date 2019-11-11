using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeDataCenterCore.Services;
using HomeDataCenterCore.Domain;
using HomeDataCenterCore.Domain.ViewModels;

namespace HomeDataCenterCore.Controllers
{
    public class BodyDataController : Controller
    {
        private readonly Services.IBodyDataService _service;
        public BodyDataController(IBodyDataService service)
        {
            _service = service;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.Title = "身体数据 - 主页";
            int TotalCount = await _service.GetBodyDataCount();
            IndexViewModel viewModel = new IndexViewModel();
            PagingInfo pagingInfo = new PagingInfo();
            pagingInfo.TotalCount = TotalCount;
            pagingInfo.CurrentPage = page;
            viewModel.paginginfo = pagingInfo;
            //Tuple<IEnumerable<BodyDataViewModel>, int> viewmodel = await _service.GetAllBodyData();
            viewModel.BodyData = await _service.GetAllBodyDataByPage(page, pagingInfo.PageSize);
            return View(viewmodel.Item1.OrderBy(m => m.RecordTime));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Title = "身体数据 - 新增";
            BodyDataViewModel viewmodel = new BodyDataViewModel()
            {
                RecordTime = DateTime.Now
            };
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BodyDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _service.AddBodyData(model);
            }
            else
            {
                ViewBag.Title = "身体数据 - 新增";
                ViewBag.Msg = "数据合法性检测失败";
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
