using System;
using System.Collections.Generic;
using Felipe.Backend.Locsonging.Infrastructure;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Felipe.Backend.Locsonging.Domain
{
    [BsonIgnoreExtraElements]
    [MongoCollection("users")]
    public class User
    {
        public ObjectId Id { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("userName")]
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("birthDate")]
        public DateTime BirthDate { get; set; }

        [BsonElement("favoritesSongs")]
        public IEnumerable<Song> FavoritesSongs { get; set; }

        public string SpotifyToken { get; set; }
        
    }
}