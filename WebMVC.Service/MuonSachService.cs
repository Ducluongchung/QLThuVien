using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;
using WebMVC.Repository;

namespace WebMVC.Service
{
    public interface IMuonSachService : IService<MuonSach>
    {

    }
    public class MuonSachService : IMuonSachService
    {
        private readonly IMuonSachRepository _repository;
        public MuonSachService(IMuonSachRepository repository)
        {
            _repository = repository;
        }
        public int Add(MuonSach item)
        {
            return _repository.Add(item);
        }

        public bool Delete(MuonSach entity)
        {
            return _repository.Delete(entity);
        }

        public List<MuonSach> GetAll()
        {
            return _repository.GetAll();
        }

        public MuonSach GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Update(MuonSach item)
        {
            return _repository.Update(item);
        }
    }
}
