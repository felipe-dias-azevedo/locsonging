using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;

namespace Felipe.Backend.Locsonging.Infrastructure.Repository.Interface
{
    public interface IUserRepository
    {

        Task<User> GetByUserId(string id);

        Task<User> GetByEmail(string email);

        Task Insert(User user);
    }
}