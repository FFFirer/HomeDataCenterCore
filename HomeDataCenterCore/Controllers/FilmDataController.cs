using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeDataCenterCore.Services;
using HomeDataCenterCore.Domain.DomainModels;
using HomeDataCenterCore.Domain.ViewModels;

namespace HomeDataCenterCore.Controllers
{
    public class FilmDataController : Controller
    {
        private readonly IFilmDataService _service;
        public FilmDataController(IFilmDataService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.Title = "电影数据 - 主页";
            int TotalCount = await _service.GetFilmDataCount();

            // 分页
            PagingInfo pagingInfo = new PagingInfo();
            pagingInfo.TotalCount = TotalCount;
            pagingInfo.CurrentPage = page;

            // 获取数据
            var data = await _service.GetFilmDataByPage(page, pagingInfo.PageSize);
            ViewBag.PagingInfo = pagingInfo;
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int Id)
        {
            FilmData data = await _service.GetFilmDetailById(Id);
            ViewBag.Title = $"{data.Name} - 详情";
            return View(data);
        }
    }
}