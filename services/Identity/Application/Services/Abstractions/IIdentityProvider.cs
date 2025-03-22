namespace Application.Services.Abstractions;

using Contracts.User;
using Models.Identity;

public interface IIdentityProvider
{
    Task<RegisteResponse> RegisterUser(UserCreateRequest request);
}