using System.Collections.Generic;
using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;

namespace Felipe.Backend.Locsonging.Service.Domain.Interface
{
    public interface ISongService
    {
        public Task<IEnumerable<Song>> Get();
    }
}