using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;
using WebMVC.Repository;

namespace WebMVC.Service
{
    public interface ISachService : IService<Sach>
    {
        List<Sach> Search(string SearchString);
    }
    public class SachService : ISachService
    {
        private readonly ISachRepository _repository;
        public SachService(ISachRepository repository)
        {
            _repository = repository;
        }
        public int Add(Sach item)
        {
            return _repository.Add(item);
        }

        public bool Delete(Sach entity)
        {
            return _repository.Delete(entity);
        }

        public List<Sach> GetAll()
        {
            return _repository.GetAll();
        }

        public Sach GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Sach> Search(string SearchString)
        {
            return _repository.Search(SearchString);
        }
        public bool Update(Sach item)
        {
            return _repository.Update(item);
        }
    }
}
