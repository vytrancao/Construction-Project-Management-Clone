namespace Application.MapProfiles;

using AutoMapper;
using Requests.User;
using Domain.Entities;
using Models.User;

public class UserMapperProfile : Profile
{
    public UserMapperProfile()
    {
        CreateMap<CreateUserRequest, User>()
            .ForMember(dest => dest.IdentityUserId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ReverseMap();

        CreateMap<User, CreateUserResponse>();
        CreateMap<User, UserModel>();
    }
}