using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeDataCenterCore.Services;
using HomeDataCenterCore.Models;
using HomeDataCenterCore.Domain;

namespace HomeDataCenterCore.Controllers
{
    public class BodyDataController : Controller
    {
        private readonly IBodyDataDAL _dal;
        public BodyDataController(IBodyDataDAL dal)
        {
            _dal = dal;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "身体数据 - 主页";
            Tuple<IEnumerable<BodyDataViewModel>, int> viewmodel = await _dal.GetAllBodyData();
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
                await _dal.AddBodyData(model);
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
