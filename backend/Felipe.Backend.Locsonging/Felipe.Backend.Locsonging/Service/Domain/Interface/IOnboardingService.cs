using Felipe.Backend.Locsonging.DTO.Request;
using System.Threading.Tasks;

namespace Felipe.Backend.Locsonging.Service.Domain.Interface
{
    public interface IOnboardingService
    {
        Task<string> Create(CreateUserViewModel user);
    }
}
