namespace Application.MapProfiles;

using AutoMapper;
using Contracts.User;
using Domain.Constants;
using Keycloak.AuthServices.Sdk.Admin.Models;

public class KeycloakUserProfile : Profile
{
    public KeycloakUserProfile()
    {
        CreateMap<UserCreateRequest, UserRepresentation>()
            .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Enabled, opt => opt.MapFrom(src => true))
            .ForMember(dest => dest.Credentials, opt => opt.MapFrom(src => new List<CredentialRepresentation>
                {
                    new()
                    {
                        Type = CredentialType.Password,
                        Value = src.Password,
                        Temporary = false
                    }
                }
            ));
    }
}