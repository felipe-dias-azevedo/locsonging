using Felipe.Backend.Locsonging.Domain.Exceptions;
using Felipe.Backend.Locsonging.DTO.Request;
using Felipe.Backend.Locsonging.DTO.Response;
using Felipe.Backend.Locsonging.Helper;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;
using Felipe.Backend.Locsonging.Service.Domain.Interface;
using System.Threading.Tasks;

namespace Felipe.Backend.Locsonging.Service.Domain
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserTokenViewModel> LoginUser(LoginViewModel loginData)
        {
            var user = await _userRepository.GetByEmail(loginData.Email);

            if (user == null)
            {
                throw new NotFoundException();
            }

            var passwordValid = Passwords.Validate(loginData.Password, user.Password);

            if (!passwordValid)
            {
                throw new UnauthorizedException();
            }

            // TODO: if not allowed -> forbidden exception

            return new UserTokenViewModel
            {
                Id = user.UserId,
                Email = user.Email
            };
        }
        
        public Task<bool> LoginSpotify(LoginViewModel loginView)
        {
            throw new System.NotImplementedException();
        }
    }
}
