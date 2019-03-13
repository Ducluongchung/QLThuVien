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
    public interface ITacGiaRepository : IRepository<Tacgia>
    {

    }
    public class TacGiaRepository : ITacGiaRepository
    {
        private readonly TestMVCDbContext _context;

        public TacGiaRepository(TestMVCDbContext context)
        {
            _context = context;
        }
        public int Add(Tacgia item)
        {
            _context.Tacgias.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public bool Delete(Tacgia entity)
        {
            var model = _context.Tacgias.Find(entity.Id);
            _context.Tacgias.Remove(model);
            _context.SaveChanges();
            return true;
        }

        public List<Tacgia> GetAll()
        {
            var list = _context.Tacgias.ToList();
            return list;
        }

        public Tacgia GetById(int id)
        {
            return _context.Tacgias.Find(id);
        }

        public List<Tacgia> Search(string SearchString)
        {
            if (SearchString == null)
            {
                return GetAll();
            }
            else
                return _context.Tacgias.Where(x => x.Name.Contains(SearchString)).ToList();
        }

        public bool Update(Tacgia item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
