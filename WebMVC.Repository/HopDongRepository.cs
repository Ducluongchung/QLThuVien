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
    public interface IHopDongRepository:IRepository<HopDong>
    {

    }
    public class HopDongRepository : IHopDongRepository
    {
        private readonly TestMVCDbContext _context;
        public HopDongRepository(TestMVCDbContext context)
        {
            _context = context;
        }
        public int Add(HopDong item)
        {
            _context.HopDongs.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public bool Delete(HopDong entity)
        {
            var model = _context.HopDongs.Find(entity.Id);
            _context.HopDongs.Remove(model);
            _context.SaveChanges();
            return true;
        }

        public List<HopDong> GetAll()
        {
            var list = _context.HopDongs.ToList();
            return list;
        }

        public HopDong GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<HopDong> Search(string SearchString)
        {
            throw new NotImplementedException();
        }

        public bool Update(HopDong item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
