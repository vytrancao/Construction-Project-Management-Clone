namespace Application.MapProfiles;

using AutoMapper;
using Contracts.User;
using Domain.Entities;
using Models.User;

public class UserMapperProfile : Profile
{
    public UserMapperProfile()
    {
        CreateMap<UserCreateRequest, User>()
            .ForMember(dest => dest.IdentityUserId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<User, UserCreateResponse>();
    }
}