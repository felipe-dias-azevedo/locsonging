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
            _users = ctx.GetCollection<User>();
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _users.Find(u => u.Email == email).FirstOrDefaultAsync();
        }

        public async Task Insert(User user)
        {
            await _users.InsertOneAsync(user);
        }

        public async Task<User> GetByUserId(string userId)
        {
            return await _users.Find(x => x.UserId == userId).FirstOrDefaultAsync();
        }
    }
}