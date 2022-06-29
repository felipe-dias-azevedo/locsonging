using System;
using Felipe.Backend.Locsonging.DTO.Request;
using Felipe.Backend.Locsonging.Infrastructure.Repository.Interface;
using Felipe.Backend.Locsonging.Service.Domain.Interface;
using System.Threading.Tasks;
using Felipe.Backend.Locsonging.Domain;
using Felipe.Backend.Locsonging.Domain.Exceptions;
using Felipe.Backend.Locsonging.Helper;

namespace Felipe.Backend.Locsonging.Service.Domain
{
    public class OnboardingService : IOnboardingService
    {
        private readonly IUserRepository _userRepository;

        public OnboardingService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<string> Create(CreateUserViewModel createUser)
        {
            await IsEmailUnique(createUser.Email);

            var id = await GenerateNewUserId();

            var user = new User
            {
                UserId = id,
                Name = createUser.Name,
                Email = createUser.Email,
                BirthDate = createUser.BirthDate,
                Password = Passwords.ToPassword(createUser.Password)
            };

            await _userRepository.Insert(user);

            return id;
        }

        private async Task IsEmailUnique(string email)
        {
            var existsByEmail = await _userRepository.GetByEmail(email);

            if (existsByEmail != null)
            {
                throw new BadRequestException($"'{email}' has already been created");
            }
        }

        private async Task<string> GenerateNewUserId()
        {
            var id = Guid.NewGuid().ToString();

            while (await _userRepository.GetByUserId(id) != null)
            {
                id = Guid.NewGuid().ToString();
            }

            return id;
        }
    }
}
