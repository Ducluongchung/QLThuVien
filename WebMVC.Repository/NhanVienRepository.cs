using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Data;
using WebMVC.Model;

namespace WebMVC.Repository
{
    public interface INhanVienRepository : IRepository<NhanVien>
    {
        int SearchSex();
    }
    public class NhanVienRepository : INhanVienRepository
    {
        private readonly TestMVCDbContext _context;

        public NhanVienRepository(TestMVCDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Them nhan vien
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Add(NhanVien item)
        {
            _context.NhanViens.Add(item);
            _context.SaveChanges();
            return item.Id;
        }
        /// <summary>
        /// Xoa Nhan Vien
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            if (_context.SaveChanges() > 0)
            {
                var nhanVien = _context.NhanViens.Find(id);
                _context.NhanViens.Remove(nhanVien);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Get danh sach nhan vien
        /// </summary>
        /// <returns></returns>
        public List<NhanVien> GetAll()
        {
            var listBanner = _context.NhanViens.ToList();
            return listBanner;
        }
        /// <summary>
        /// Tim kiem khoa chinh
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public NhanVien GetById(int id)
        {
            return _context.NhanViens.Find(id);
        }
        /// <summary>
        /// Search nhan vien
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public IEnumerable<NhanVien> Seach(string searchString)
        {
            throw new NotImplementedException();
        }

        public int SearchSex()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update Nhan Vien
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(NhanVien item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
