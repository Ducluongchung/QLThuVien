using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        int Add(T item);
        T GetById(int id);
        bool Update(T item);
        bool Delete(T entity);

        List<T> Search(string SearchString);
    }
}
