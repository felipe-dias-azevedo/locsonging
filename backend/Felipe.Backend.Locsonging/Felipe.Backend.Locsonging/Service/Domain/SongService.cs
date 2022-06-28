using System.Collections.Generic;
using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;
using Felipe.Backend.Locsonging.Service.Domain.Interface;

namespace Felipe.Backend.Locsonging.Service.Domain
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public async Task<IEnumerable<Song>> Get() => await _songRepository.FindAll();
    }
}