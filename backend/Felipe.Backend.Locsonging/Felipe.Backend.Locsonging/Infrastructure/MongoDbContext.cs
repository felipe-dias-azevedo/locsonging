using Felipe.Backend.Locsonging.Helper;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Felipe.Backend.Locsonging.Infrastructure
{
    public class MongoDbContext : IMongoContext
    {
        private readonly IMongoDatabase _ctx;
        
        public MongoDbContext(IOptions<MongoSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            _ctx = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<T> GetCollection<T>()
        {
            var collection = (MongoCollectionAttribute) Attributes.Get<MongoCollectionAttribute>(typeof(T));
            
            return _ctx.GetCollection<T>(collection?.Name);
        }
    }
}