using System.Collections.Generic;

namespace TSport.Services
{
    public interface ICRUDService<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Add(T model);
        IEnumerable<T> Update(T model);
        bool Delete(int id);
    }
}
