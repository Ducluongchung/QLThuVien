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
    public interface INhaXuatBanRepository : IRepository<NhaXuatBan>
    {

    }
    public class NhaXuatBanRepository : INhaXuatBanRepository
    {
        private readonly TestMVCDbContext _context;

        public NhaXuatBanRepository(TestMVCDbContext context)
        {
            _context = context;
        }
        public int Add(NhaXuatBan item)
        {
            _context.NhaXuatBans.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public bool Delete(NhaXuatBan entity)
        {
            var model = _context.NhaXuatBans.Find(entity.Id);
            _context.NhaXuatBans.Remove(model);
            _context.SaveChanges();
            return true;
        }

        public List<NhaXuatBan> GetAll()
        {
            var list = _context.NhaXuatBans.ToList();
            return list;
        }

        public NhaXuatBan GetById(int id)
        {
            return _context.NhaXuatBans.Find(id);
        }

        public List<NhaXuatBan> Search(string SearchString)
        {
            if (SearchString == null)
            {
                return GetAll();
            }
            else
                return _context.NhaXuatBans.Where(x => x.Name.Contains(SearchString)).ToList();
        }

        public bool Update(NhaXuatBan item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
