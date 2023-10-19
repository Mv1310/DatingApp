using API.Entities;

namespace API.Interface
{
    public interface ITokenService
    {
        Task<string> CreateTokenAsync(AppUser user);
    }
}