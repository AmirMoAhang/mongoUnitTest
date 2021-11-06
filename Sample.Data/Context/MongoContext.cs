using MongoDB.Driver;

namespace Sample.Data.Context
{
    public class MongoContext : IMongoContext
    {
        private IMongoDatabase _db { get; set; }
        private IMongoClient _client { get; set; }
        private IClientSessionHandle session { get; set; }

        public MongoContext()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _db = _client.GetDatabase("Test");
        }


        public IMongoCollection<T> GetCollection<T>()
        {
            return _db.GetCollection<T>(typeof(T).Name);
        }
    }
}