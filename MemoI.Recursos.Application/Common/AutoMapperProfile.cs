using AutoMapper;
using MemoI.Recursos.Application.Dtos.Users;
using MemoI.Recursos.Domain;

namespace MemoI.Recursos.Application.Common;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // Tickets
        //CreateMap<TicketDto, User>().ReverseMap();
        CreateMap<CreateUserDto, User>();
    }
    
}