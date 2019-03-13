using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;
using WebMVC.Repository;

namespace WebMVC.Service
{
    public interface ITacGiaService : IService<Tacgia>
    {
        List<Tacgia> Search(string SearchString);
    }
    public class TacGiaService : ITacGiaService
    {
        private readonly ITacGiaRepository _repository;
        public TacGiaService(ITacGiaRepository repository)
        {
            _repository = repository;
        }
        public int Add(Tacgia item)
        {
            return _repository.Add(item);
        }

        public bool Delete(Tacgia entity)
        {
            return _repository.Delete(entity);
        }

        public List<Tacgia> GetAll()
        {
            return _repository.GetAll();
        }

        public Tacgia GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Tacgia> Search(string SearchString)
        {
            return _repository.Search(SearchString);
        }

        public bool Update(Tacgia item)
        {
            return _repository.Update(item);
        }
    }
}
