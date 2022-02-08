using MongoDB.Driver;

namespace Felipe.Backend.Locsonging.Infrastructure
{
    public interface IMongoContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}