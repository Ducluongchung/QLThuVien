using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;
using WebMVC.Repository;

namespace WebMVC.Service
{
    public interface INhanVienService : IService<NhanVien>
    {
        List<NhanVien> Search(string SearchString);
    }
    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRepository _repository;

        public NhanVienService(INhanVienRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Service Get danh sách
        /// </summary>
        /// <returns></returns>
        public List<NhanVien> GetAll()
        {
            return _repository.GetAll();
        }
        /// <summary>
        /// Service Tim kiem khoa chinh
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public NhanVien GetById(int id)
        {
            return _repository.GetById(id);
        }
        /// <summary>
        /// Service Them nhan vien
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Add(NhanVien item)
        {
            return _repository.Add(item);
        }
        /// <summary>
        /// Service Update nhan vien
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(NhanVien item)
        {
            return _repository.Update(item);
        }

        public bool Delete(NhanVien entity)
        {
            return _repository.Delete(entity);
        }

        public List<NhanVien> Search(string SearchString)
        {
           return  _repository.Search(SearchString);
        }

        /// <summary>
        /// Service Delete Nhan Vien
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>





    }
}
