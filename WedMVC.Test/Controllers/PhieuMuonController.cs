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
    public class PhieuMuonController : Controller
    {
        TestMVCDbContext db = new TestMVCDbContext();
        private readonly IMuonSachService _MuonSachService;
        private readonly IDocGiaService _docGiaService;
        private readonly ISachService _SachService;
        private readonly INhanVienService _nhanVienService;
        public PhieuMuonController(IMuonSachService MuonSachService, IDocGiaService docGiaService, ISachService SachService, INhanVienService nhanVienService)
        {
            _MuonSachService = MuonSachService;
            _docGiaService = docGiaService;
            _nhanVienService = nhanVienService;
            _SachService = SachService;
        }
        /// <summary>
        /// Action Index
        /// </summary>
        /// <param name="SearchString"></param>
        /// <returns></returns>
        public ActionResult Index(string SearchString)
        {
            var model = _MuonSachService.Search(SearchString);
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
            var listSach = _SachService.GetAll();
            var listNhanVien = _nhanVienService.GetAll();
            var listDocGia = _docGiaService.GetAll();
            ViewBag.SachId = new SelectList(listSach, "Id", "Name");
            ViewBag.NhanVienId = new SelectList(listNhanVien, "Id", "Name");
            ViewBag.DocGiaId = new SelectList(listDocGia, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Add(MuonSach MuonSach)
        {
            if (ModelState.IsValid)
            {
                if (_MuonSachService.Add(MuonSach) > 0)
                    return RedirectToAction("Index", "PhieuMuon");
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
            var listSach = _SachService.GetAll();
            var listNhanVien = _nhanVienService.GetAll();
            var listDocGia = _docGiaService.GetAll();
            ViewBag.SachId = new SelectList(listSach, "Id", "Name", id);
            ViewBag.NhanVienId = new SelectList(listNhanVien, "Id", "Name", id);
            ViewBag.DocGiaId = new SelectList(listDocGia, "Id", "Name", id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MuonSach MuonSach = db.MuonSaches.Find(id);
            if (MuonSach == null)
            {
                return HttpNotFound();
            }
            return View(MuonSach);
        }
        [HttpPost]
        public ActionResult Edit(MuonSach MuonSach)
        {
            if (ModelState.IsValid)
            {
                if (_MuonSachService.Update(MuonSach) == true)
                {
                    return RedirectToAction("Index", "PhieuMuon");
                }
            }

            return View(MuonSach);
        }
        /// <summary>
        /// Action Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Delete(MuonSach MuonSach)
        {
            var model = _MuonSachService.Delete(MuonSach);
            if (model)
                return RedirectToAction("Index");
            else
                return View("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _MuonSachService.GetById(id);
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            var model = _MuonSachService.GetById(id);
            return View(model);
        }

    }
}