using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;
using MongoDB.Driver;

namespace Felipe.Backend.Locsonging.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _users;

        public UserRepository(IMongoContext ctx)
        {
            _users = ctx.GetCollection<User>("");
        }

        public async Task<User> Select(string id)
        {
            return await _users.Find(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}