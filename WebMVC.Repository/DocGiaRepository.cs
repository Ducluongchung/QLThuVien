using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;

namespace WebMVC.Repository
{
    public interface IDocGiaRepository: IRepository<DocGia>
    {

    }
    public class DocGiaRepository : IDocGiaRepository
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
