using Application.Api.Entities.Models;

namespace Application.Api.Services.Interface
{
    public interface ITokenService
    {
        string GenerateToken(User user, IList<string> roles);
    }
}
