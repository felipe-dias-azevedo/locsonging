namespace Felipe.Backend.Locsonging.Infrastructure
{
    public class MongoSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
    
    public interface IMongoSettings
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}