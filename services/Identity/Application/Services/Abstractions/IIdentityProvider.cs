namespace Application.Services.Abstractions;

using Requests.User;
using Models.Identity;

public interface IIdentityProvider
{
    Task<RegisteResponse> RegisterUser(CreateUserRequest request);
}