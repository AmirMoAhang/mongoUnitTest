using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using Sample.Data.Context;

namespace Sample.Data.Repository
{
    public class BaseRepository<T>:IBaseRepository<T> where T : class
    {
        private readonly IMongoContext _context;
        private readonly IMongoCollection<T> _db;
        public BaseRepository(IMongoContext context)
        {
            _context = context;
            _db = context.GetCollection<T>();
        }

        public async Task Create(T entity)
        {
            await _db.InsertOneAsync(entity);
        }
    }
}