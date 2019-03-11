using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;
using WebMVC.Repository;

namespace WebMVC.Service
{
    public interface IHopDongService : IService<HopDong>
    {

    }
    public class HopDongService : IHopDongService
    {
        private readonly IHopDongRepository _repository;
        public HopDongService(IHopDongRepository repository)
        {
            _repository = repository;
        }
        public int Add(HopDong item)
        {
            return _repository.Add(item);
        }

        public bool Delete(HopDong entity)
        {
            return _repository.Delete(entity);
        }

        public List<HopDong> GetAll()
        {
            return _repository.GetAll();
        }

        public HopDong GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Update(HopDong item)
        {
            return _repository.Update(item);
        }
    }
}
