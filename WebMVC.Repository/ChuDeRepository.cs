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
    public interface IChuDeRepository : IRepository<ChuDe>
    {

    }
    public class ChuDeRepository : IChuDeRepository
    {
        private readonly TestMVCDbContext _context;

        public ChuDeRepository(TestMVCDbContext context)
        {
            _context = context;
        }
        public int Add(ChuDe item)
        {
            _context.ChuDes.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public bool Delete(ChuDe entity)
        {
            var model = _context.ChuDes.Find(entity.Id);
            _context.ChuDes.Remove(model);
            _context.SaveChanges();
            return true;
        }

        public List<ChuDe> GetAll()
        {
            var list = _context.ChuDes.ToList();
            return list;
        }

        public ChuDe GetById(int id)
        {
            return _context.ChuDes.Find(id);
        }

        public List<ChuDe> Search(string SearchString)
        {
            if (SearchString == null)
            {
                return GetAll();
            }
            else
                return _context.ChuDes.Where(x => x.Name.Contains(SearchString)).ToList();
        }

        public bool Update(ChuDe item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
