namespace Application.Services.Abstractions;

using Contracts.User;
using Domain.Entities;

public interface IUserService
{
    Task<User> CreateAsync(UserCreateRequest request);
}