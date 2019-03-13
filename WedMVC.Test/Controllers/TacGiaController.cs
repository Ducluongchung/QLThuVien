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
    public class TacGiaController : Controller
    {
        TestMVCDbContext db = new TestMVCDbContext();
        private readonly ITacGiaService _TacGiaService;
        public TacGiaController(ITacGiaService TacGiaService)
        {
            _TacGiaService = TacGiaService;
        }
        /// <summary>
        /// Action Index
        /// </summary>
        /// <param name="SearchString"></param>
        /// <returns></returns>
        public ActionResult Index(string SearchString)
        {
            var model = _TacGiaService.Search(SearchString);
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
        public ActionResult Add(Tacgia TacGia)
        {
            if (ModelState.IsValid)
            {
                if (_TacGiaService.Add(TacGia) > 0)
                    return RedirectToAction("Index", "TacGia");
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
            Tacgia TacGia = db.Tacgias.Find(id);
            if (TacGia == null)
            {
                return HttpNotFound();
            }
            return View(TacGia);
        }
        [HttpPost]
        public ActionResult Edit(Tacgia TacGia)
        {
            if (ModelState.IsValid)
            {
                if (_TacGiaService.Update(TacGia) == true)
                {
                    return RedirectToAction("Index", "TacGia");
                }
            }

            return View(TacGia);
        }
        /// <summary>
        /// Action Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Delete(Tacgia TacGia)
        {
            var model = _TacGiaService.Delete(TacGia);
            if (model)
                return RedirectToAction("Index");
            else
                return View("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _TacGiaService.GetById(id);
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = _TacGiaService.GetById(id);
            return View(model);
        }
    }
}