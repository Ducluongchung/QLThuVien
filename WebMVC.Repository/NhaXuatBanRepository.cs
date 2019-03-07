using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;

namespace WebMVC.Repository
{
    public interface INhaXuatBanRepository : IRepository<NhaXuatBan>
    {

    }
    public class NhaXuatBanRepository : INhaXuatBanRepository
    {
        public int Add(NhaXuatBan item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<NhaXuatBan> GetAll()
        {
            throw new NotImplementedException();
        }

        public NhaXuatBan GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(NhaXuatBan item)
        {
            throw new NotImplementedException();
        }
    }
}
