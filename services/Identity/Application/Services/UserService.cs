namespace Application.Services;

using Abstractions;
using Cpm.Common.Query.Extensions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Models.User;
using Persistence.Repositories.Abstractions;
using Requests.User;

public class UserService(
    IUserRepository userRepository
) : IUserService
{
    public async Task<SearchUserResponse> SearchAsync(SearchUserRequest request)
    {
        var query = userRepository.Get();
        var totalPage = query.CalculateTotalPage(request);
        var users = await query.Filter(request).Sort(request).Paginate(request).ToListAsync();
        return new SearchUserResponse
        {
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            TotalPage = totalPage,
            Items = users.Select(UserModel.FromEntity)
        };
    }

    public IEnumerable<User> GetSyncToIdentityProvider()
    {
        return userRepository.Get().Where(x => x.IdentityUserId == null).AsEnumerable();
    }

    public async Task<User> CreateAsync(CreateUserRequest request)
    {
        var newUser = request.ToEntity();
        userRepository.Create(newUser);
        await userRepository.SaveChangesAsync();
        return newUser;
    }

    public async Task<IEnumerable<User>> UpdateRangeAsync(IEnumerable<User> users)
    {
        foreach (var user in users)
        {
            userRepository.Update(user);
        }

        await userRepository.SaveChangesAsync();
        return users;
    }
}