using Felipe.Backend.Locsonging.DTO.Request;
using Felipe.Backend.Locsonging.DTO.Response;
using System.Threading.Tasks;

namespace Felipe.Backend.Locsonging.Service.Domain.Interface
{
    public interface IAuthService
    {

        Task<UserTokenViewModel> LoginUser(LoginViewModel loginView);

        Task<bool> LoginSpotify(LoginViewModel loginView);

    }
}
