using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebMVC.Data;
using WebMVC.Model;
using WebMVC.Service;

namespace WedMVC.Test.Controllers
{
    public class HomeController : Controller
    {
        TestMVCDbContext db = new TestMVCDbContext();
        private readonly INhanVienService _nhanVienService;
        public HomeController(INhanVienService nhanVienService)
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
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        
        /// <summary>
        /// Action Edit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int ?id )
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
                if (_nhanVienService.Update(nhanVien)==true)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(nhanVien);
        }
        /// <summary>
        /// Action Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(int? id)
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
        public ActionResult Delete(int id)
        {
            var mess = _nhanVienService.Delete(id);
            if (mess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Error!!");
                return View();
            }
        }

      

    }
}