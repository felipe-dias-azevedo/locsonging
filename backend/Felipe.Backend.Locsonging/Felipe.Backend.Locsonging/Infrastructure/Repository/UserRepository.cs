using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;

namespace Felipe.Backend.Locsonging.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoContext _ctx;
        private readonly MongoDbContext _db;

        public UserRepository(IMongoContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<User> Select(string id)
        {
            //return await ((MongoDbContext) _ctx).UserCollection.FindAsync(x => x.);
        }
    }
}