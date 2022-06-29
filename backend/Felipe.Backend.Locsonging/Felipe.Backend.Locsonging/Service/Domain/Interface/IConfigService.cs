using Felipe.Backend.Locsonging.DTO.Response;
using System.Threading.Tasks;

namespace Felipe.Backend.Locsonging.Service.Domain.Interface
{
    public interface IConfigService
    {
        Task<UserDataViewModel> GetUserDataById(string id);
    }
}
