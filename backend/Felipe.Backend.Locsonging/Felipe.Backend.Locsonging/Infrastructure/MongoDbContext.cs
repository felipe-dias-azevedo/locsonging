using Felipe.Backend.Locsonging.Domain;
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

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _ctx.GetCollection<T>(name);
        }
    }
}