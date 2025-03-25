namespace Application.Services.Abstractions;

using Requests.User;
using Domain.Entities;
using Models.User;

public interface IUserService
{
    Task<SearchUserResponse> Search(SearchUserRequest request);
    IEnumerable<User> GetSyncToIdentityProvider();
    Task<User> CreateAsync(CreateUserRequest request);
    Task<IEnumerable<User>> UpdateRangeAsync(IEnumerable<User> users);
}