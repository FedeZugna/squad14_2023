using AutoMapper;
using MemoI.Recursos.Application.Dtos.CargaHorarias;
using MemoI.Recursos.Application.Dtos.Users;
using MemoI.Recursos.Domain;

namespace MemoI.Recursos.Application.Common;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // CargaHorarias
        CreateMap<CreateCargaHorariaDto, CargaHoraria>().ReverseMap();
    }
    
}