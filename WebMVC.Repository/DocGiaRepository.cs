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
    public interface IDocGiaRepository: IRepository<DocGia>
    {

    }
    public class DocGiaRepository : IDocGiaRepository
    {
        private readonly TestMVCDbContext _context;

        public DocGiaRepository(TestMVCDbContext context)
        {
            _context = context;
        }
        public int Add(DocGia item)
        {
            _context.DocGias.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public bool Delete(DocGia entity)
        {
            var model = _context.DocGias.Find(entity.Id);
            _context.DocGias.Remove(model);
            _context.SaveChanges();
            return true;
        }

        public List<DocGia> GetAll()
        {
            var list = _context.DocGias.ToList();
            return list;
        }

        public DocGia GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DocGia Search(string SearchString)
        {
            throw new NotImplementedException();
        }

        public bool Update(DocGia item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
