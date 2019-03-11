using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;
using WebMVC.Repository;

namespace WebMVC.Service
{
    public interface INhaXuatBanService : IService<NhaXuatBan>
    {

    }
    public class NhaXuatBanService : INhaXuatBanService
    {
        private readonly INhaXuatBanRepository _repository;
        public NhaXuatBanService(INhaXuatBanRepository repository)
        {
            _repository = repository;
        }
        public int Add(NhaXuatBan item)
        {
            return _repository.Add(item);
        }

        public bool Delete(NhaXuatBan entity)
        {
            return _repository.Delete(entity);
        }

        public List<NhaXuatBan> GetAll()
        {
            return _repository.GetAll();
        }

        public NhaXuatBan GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Update(NhaXuatBan item)
        {
            return _repository.Update(item);
        }
    }
}
