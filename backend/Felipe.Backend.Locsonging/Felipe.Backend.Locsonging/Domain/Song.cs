using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Felipe.Backend.Locsonging.Domain
{
    [BsonIgnoreExtraElements]
    public class Song
    {
        public ObjectId Id { get; set; }
        
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("duration")]
        public int Duration { get; set; }

        public string Storage { get; set; }

        [BsonElement("album")]
        public string Album { get; set; }
    }
}