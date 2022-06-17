using System.Collections.Generic;
using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;

namespace Felipe.Backend.Locsonging.Infrastructure.Repository.Interface
{
    public interface ISongRepository
    {
        public Task<IEnumerable<Song>> FindAll();
    }
}