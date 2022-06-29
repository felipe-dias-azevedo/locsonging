using Felipe.Backend.Locsonging.DTO.Request;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;
using Felipe.Backend.Locsonging.Service.Domain.Interface;
using System.Threading.Tasks;

namespace Felipe.Backend.Locsonging.Service.Domain
{
    public class OnboardingService : IOnboardingService
    {
        private readonly IUserRepository _userRepository;

        public OnboardingService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<string> Create(CreateUserViewModel user)
        {
            throw new System.NotImplementedException();
        }
    }
}
