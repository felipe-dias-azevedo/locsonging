using Felipe.Backend.Locsonging.Domain.Exceptions;
using Felipe.Backend.Locsonging.DTO.Response;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;
using Felipe.Backend.Locsonging.Service.Domain.Interface;
using System.Threading.Tasks;

namespace Felipe.Backend.Locsonging.Service.Domain
{
    public class ConfigService : IConfigService
    {
        private readonly IUserRepository _userRepository;

        public ConfigService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDataViewModel> GetUserDataById(string id)
        {
            var user = await _userRepository.GetByUserId(id);

            if (user == null)
            {
                throw new NotFoundException();
            }

            return new UserDataViewModel
            {
                Id = user.UserId,
                Name = user.Name,
                Email = user.Email,
                BirthDate = user.BirthDate,
                SpotifyToken = user.SpotifyToken
            };
        }
    }
}
