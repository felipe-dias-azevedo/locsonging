using Felipe.Backend.Locsonging.DTO.Request;

namespace Felipe.Backend.Locsonging.Service.Domain.Interface
{
    public interface IAuthService
    {

        public bool LoginUser(LoginViewModel loginView);

        public bool LoginSpotify(LoginViewModel loginView);

    }
}
