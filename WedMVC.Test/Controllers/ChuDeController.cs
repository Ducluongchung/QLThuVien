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
    public class ChuDeController : Controller
    {
        TestMVCDbContext db = new TestMVCDbContext();
        private readonly IChuDeService _ChuDeService;
        private readonly IHopDongService _hopDongService;
        public ChuDeController(IChuDeService ChuDeService, IHopDongService hopDongService)
        {
            _ChuDeService = ChuDeService;
            _hopDongService = hopDongService;
        }
        /// <summary>
        /// Action Index
        /// </summary>
        /// <param name="SearchString"></param>
        /// <returns></returns>
        public ActionResult Index(string SearchString)
        {
            var model = _ChuDeService.Search(SearchString);
            ViewBag.SearchString = SearchString;
            return View(model);
        }

        public void SetView(int? id = null)
        {
            var model = _hopDongService.GetAll();
            ViewBag.HopDongId = new SelectList(model, "Id", "Id", id);
        }
        /// <summary>
        /// Action Add
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Add()
        {
            SetView();
            return View();
        }
        [HttpPost]
        public ActionResult Add(ChuDe ChuDe)
        {
            if (ModelState.IsValid)
            {
                if (_ChuDeService.Add(ChuDe) > 0)
                    return RedirectToAction("Index", "ChuDe");
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
            SetView(id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChuDe ChuDe = db.ChuDes.Find(id);
            if (ChuDe == null)
            {
                return HttpNotFound();
            }
            return View(ChuDe);
        }
        [HttpPost]
        public ActionResult Edit(ChuDe ChuDe)
        {
            if (ModelState.IsValid)
            {
                if (_ChuDeService.Update(ChuDe) == true)
                {
                    return RedirectToAction("Index", "ChuDe");
                }
            }

            return View(ChuDe);
        }
        /// <summary>
        /// Action Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Delete(ChuDe ChuDe)
        {
            var model = _ChuDeService.Delete(ChuDe);
            if (model)
                return RedirectToAction("Index");
            else
                return View("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _ChuDeService.GetById(id);
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = _ChuDeService.GetById(id);
            return View(model);
        }

    }
}