using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;

namespace WebMVC.Service
{
    public interface ISachService : IService<Sach>
    {

    }
    public class SachService : ISachService
    {
        public int Add(Sach item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sach> GetAll()
        {
            throw new NotImplementedException();
        }

        public Sach GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Sach item)
        {
            throw new NotImplementedException();
        }
    }
}
