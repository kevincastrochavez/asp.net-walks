using Microsoft.AspNetCore.Identity;

namespace Walks.Repositories;

public interface ITokenRepository
{
    string CreateJWTToken(IdentityUser user, List<string> roles);
}