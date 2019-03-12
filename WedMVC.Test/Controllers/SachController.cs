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
    public class SachController : Controller
    {
        TestMVCDbContext db = new TestMVCDbContext();
        private readonly ISachService _sachService;

        private readonly IChuDeService _chuDeService;

        private readonly ITacGiaService _tacGiaService;

        private readonly INhaXuatBanService _nhaXuatBanService;
        public SachController(ISachService sachService, IChuDeService chuDeService, ITacGiaService tacGiaService, INhaXuatBanService nhaXuatBanService)
        {
            _sachService = sachService;
            _tacGiaService = tacGiaService;
            _sachService = sachService;
            _nhaXuatBanService = nhaXuatBanService;
        }
        /// <summary>
        /// Action Index
        /// </summary>
        /// <param name="SearchString"></param>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = _sachService.GetAll();
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
        public ActionResult Add(Sach sach)
        {
            if (ModelState.IsValid)
            {
                if (_sachService.Add(sach) > 0)
                    return RedirectToAction("Index", "Sach");
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
            Sach sach = db.Saches.Find(id);
            if (sach == null)
            {
                return HttpNotFound();
            }
            return View(sach);
        }
        [HttpPost]
        public ActionResult Edit(Sach sach)
        {
            if (ModelState.IsValid)
            {
                if (_sachService.Update(sach) == true)
                {
                    return RedirectToAction("Index", "Sach");
                }
            }

            return View(sach);
        }
        /// <summary>
        /// Action Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Delete(Sach sach)
        {
            var model = _sachService.Delete(sach);
            if (model)
                return RedirectToAction("Index");
            else
                return View("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _sachService.GetById(id);
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = _sachService.GetById(id);
            return View(model);
        }
    }
}