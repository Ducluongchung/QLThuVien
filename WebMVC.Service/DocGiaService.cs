using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;
using WebMVC.Repository;

namespace WebMVC.Service
{
    public interface IDocGiaService : IService<DocGia>
    {

    }
    public class DocGiaService : IDocGiaService
    {
        private readonly IDocGiaRepository _repository;

        public DocGiaService(IDocGiaRepository repository)
        {
            _repository = repository;
        }
        public int Add(DocGia item)
        {
          return  _repository.Add(item);
        }

        public bool Delete(DocGia entity)
        {
           return  _repository.Delete(entity);
        }

        public List<DocGia> GetAll()
        {
            return _repository.GetAll();
        }

        public DocGia GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Update(DocGia item)
        {
            return _repository.Update(item);
        }
    }
}
