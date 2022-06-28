using System.Collections.Generic;
using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;
using MongoDB.Driver;

namespace Felipe.Backend.Locsonging.Infrastructure.Repository
{
    public class SongRepository : ISongRepository
    {
        private readonly IMongoCollection<Song> _songs;

        public SongRepository(IMongoContext ctx)
        {
            _songs = ctx.GetCollection<Song>();
        }

        public async Task<IEnumerable<Song>> FindAll()
        {
            return await _songs.Find(_ => true).ToListAsync();
        }
    }
}