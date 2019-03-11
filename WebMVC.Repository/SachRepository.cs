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
    public interface ISachRepository : IRepository<Sach>
    {

    }
    public class SachRepository : ISachRepository
    {
        private readonly TestMVCDbContext _context;
        public SachRepository(TestMVCDbContext context)
        {
            _context = context;
        }
        public int Add(Sach item)
        {
            _context.Saches.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public bool Delete(Sach entity)
        {
            var model = _context.Saches.Find(entity.Id);
            _context.Saches.Remove(model);
            _context.SaveChanges();
            return true;
        }

        public List<Sach> GetAll()
        {
            var list = _context.Saches.ToList();
            return list;
        }

        public Sach GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Sach Search(string SearchString)
        {
            throw new NotImplementedException();
        }

        public bool Update(Sach item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
