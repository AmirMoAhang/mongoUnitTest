using MongoDB.Driver;

namespace Sample.Data.Context
{
    public interface IMongoContext
    {
        IMongoCollection<T> GetCollection<T>();
    }
}