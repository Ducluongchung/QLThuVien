using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;

namespace WebMVC.Service
{
    public interface IDocGiaService : IService<DocGia>
    {

    }
    public class DocGiaService : IDocGiaService
    {
        public int Add(DocGia item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<DocGia> GetAll()
        {
            throw new NotImplementedException();
        }

        public DocGia GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(DocGia item)
        {
            throw new NotImplementedException();
        }
    }
}
