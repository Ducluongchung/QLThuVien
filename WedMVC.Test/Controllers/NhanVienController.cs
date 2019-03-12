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
    public class NhanVienController : Controller
    {
        TestMVCDbContext db = new TestMVCDbContext();
        private readonly INhanVienService _nhanVienService;
        public NhanVienController(INhanVienService nhanVienService)
        {
            _nhanVienService = nhanVienService;
        }
        /// <summary>
        /// Action Index
        /// </summary>
        /// <param name="SearchString"></param>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = _nhanVienService.GetAll();
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
        public ActionResult Add(NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                if (_nhanVienService.Add(nhanVien) > 0)
                    return RedirectToAction("Index", "NhanVien");
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
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }
        [HttpPost]
        public ActionResult Edit(NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                if (_nhanVienService.Update(nhanVien) == true)
                {
                    return RedirectToAction("Index", "NhanVien");
                }
            }

            return View(nhanVien);
        }
        /// <summary>
        /// Action Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
      
        [HttpPost]
        public ActionResult Delete(NhanVien nhanVien)
        {
            var model = _nhanVienService.Delete(nhanVien);
            if (model)
                return RedirectToAction("Index");
            else
                return View("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _nhanVienService.GetById(id);
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = _nhanVienService.GetById(id);
            return View(model);
        }

    }
}