using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;

namespace WebMVC.Service
{
    public interface ITacGiaService : IService<Tacgia>
    {

    }
    public class TacGiaService : ITacGiaService
    {
        public int Add(Tacgia item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tacgia> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tacgia GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Tacgia item)
        {
            throw new NotImplementedException();
        }
    }
}
