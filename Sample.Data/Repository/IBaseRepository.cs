using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Data.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task Create(T entity);
    }
}