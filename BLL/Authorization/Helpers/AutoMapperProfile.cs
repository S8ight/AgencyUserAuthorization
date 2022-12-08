using AutoMapper;
using BLL.DTO.Request;
using DAL.Entities;

namespace BLL.Authorization.Helpers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<RegistrationRequest, User>();
        CreateMap<User, QueueRequest>();
    }
}