namespace Application.Services;

using Abstractions;
using AutoMapper;
using Contracts.User;
using Domain.Entities;
using Persistence.Repositories.Abstractions;

public class UserService(
    IUserRepository userRepository,
    IMapper mapper) : IUserService
{
    public async Task<User> CreateAsync(UserCreateRequest request)
    {
        var newUser = mapper.Map<User>(request);
        userRepository.Create(newUser);
        await userRepository.SaveChangesAsync();
        return newUser;
    }
}