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
    public interface IMuonSachRepository : IRepository<MuonSach>
    {

    }
    public class MuonSachRepository : IMuonSachRepository
    {
        private readonly TestMVCDbContext _context;

        public MuonSachRepository(TestMVCDbContext context)
        {
            _context=context;
        }
        public int Add(MuonSach item)
        {
            _context.MuonSaches.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public bool Delete(MuonSach entity)
        {
            var model = _context.MuonSaches.Find(entity.Id);
            _context.MuonSaches.Remove(model);
            _context.SaveChanges();
            return true;
        }

        public List<MuonSach> GetAll()
        {
            var list = _context.MuonSaches.ToList();
            return list;
        }

        public MuonSach GetById(int id)
        {
            return _context.MuonSaches.Find(id);
        }

        public List<MuonSach> Search(string SearchString)
        {
            if (SearchString == null)
            {
                return GetAll();
            }
            else
                return _context.MuonSaches.Where(x => x.DocGia.Name.Contains(SearchString)|| x.NhanVien.Name.Contains(SearchString)).ToList();
        }

        public bool Update(MuonSach item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
