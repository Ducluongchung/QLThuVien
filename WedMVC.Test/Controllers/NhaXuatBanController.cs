using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMVC.Data;
using WebMVC.Model;
using WebMVC.Service;

namespace WedMVC.Test.Controllers
{
    public class NhaXuatBanController : Controller
    {
        TestMVCDbContext db = new TestMVCDbContext();
        private readonly INhaXuatBanService _NhaXuatBanService;
        private readonly IHopDongService _hopDongService;
        public NhaXuatBanController(INhaXuatBanService NhaXuatBanService, IHopDongService hopDongService)
        {
            _NhaXuatBanService = NhaXuatBanService;
            _hopDongService = hopDongService;
        }
        /// <summary>
        /// Action Index
        /// </summary>
        /// <param name="SearchString"></param>
        /// <returns></returns>
        public ActionResult Index(string SearchString)
        {
            var model = _NhaXuatBanService.Search(SearchString);
            ViewBag.SearchString = SearchString;
            return View(model);
        }
        /// <summary>
        /// Action Add
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(NhaXuatBan NhaXuatBan)
        {
            if (ModelState.IsValid)
            {
                if (_NhaXuatBanService.Add(NhaXuatBan) > 0)
                    return RedirectToAction("Index", "NhaXuatBan");
            }
            return View();
        }

        /// <summary>
        /// Action Edit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaXuatBan NhaXuatBan = db.NhaXuatBans.Find(id);
            if (NhaXuatBan == null)
            {
                return HttpNotFound();
            }
            return View(NhaXuatBan);
        }
        [HttpPost]
        public ActionResult Edit(NhaXuatBan NhaXuatBan)
        {
            if (ModelState.IsValid)
            {
                if (_NhaXuatBanService.Update(NhaXuatBan) == true)
                {
                    return RedirectToAction("Index", "NhaXuatBan");
                }
            }

            return View(NhaXuatBan);
        }
        /// <summary>
        /// Action Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Delete(NhaXuatBan NhaXuatBan)
        {
            var model = _NhaXuatBanService.Delete(NhaXuatBan);
            if (model)
                return RedirectToAction("Index");
            else
                return View("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _NhaXuatBanService.GetById(id);
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = _NhaXuatBanService.GetById(id);
            return View(model);
        }
    }
}