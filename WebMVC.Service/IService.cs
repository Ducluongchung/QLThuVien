using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Service
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        int Add(T item);
        bool Update(T item);
        bool Delete(T entity);

    }
}
