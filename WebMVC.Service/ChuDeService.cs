using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;
using WebMVC.Repository;

namespace WebMVC.Service
{
    public interface IChuDeService : IService<ChuDe>
    {
        List<ChuDe> Search(string SearchString);
    }
    public class ChuDeService : IChuDeService
    {
        private readonly IChuDeRepository _repository;

        public ChuDeService(IChuDeRepository repository)
        {
            _repository = repository;
        }
        public int Add(ChuDe item)
        {
            return _repository.Add(item);
        }

        public bool Delete(ChuDe entity)
        {
           return _repository.Delete(entity);
        }

        public List<ChuDe> GetAll()
        {
            return _repository.GetAll();
        }

        public ChuDe GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<ChuDe> Search(string SearchString)
        {
            return _repository.Search(SearchString);
        }

        public bool Update(ChuDe item)
        {
            return _repository.Update(item);
        }
    }
}
