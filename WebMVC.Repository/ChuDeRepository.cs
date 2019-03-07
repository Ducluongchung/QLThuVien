using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;

namespace WebMVC.Repository
{
    public interface IChuDeRepository : IRepository<ChuDe>
    {

    }
    public class ChuDeRepository : IChuDeRepository
    {
        public int Add(ChuDe item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ChuDe> GetAll()
        {
            throw new NotImplementedException();
        }

        public ChuDe GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChuDe item)
        {
            throw new NotImplementedException();
        }
    }
}
