using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;

namespace Felipe.Backend.Locsonging.Infrastructure.Repository.Interface
{
    public interface IUserRepository
    {

        public Task<User> Select(string id);
    }
}