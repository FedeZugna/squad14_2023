using MemoI.Recursos.Application.Dtos.CargaHorarias;
using MemoI.Recursos.Application.Responses;

namespace MemoI.Recursos.Application.Contracts.Services;

public interface ICargaHorariaService
{
    Task<BaseResponse> CreateCargaHoraria(CreateCargaHorariaDto createUserDto);
    Task<BaseResponse> DeleteCargaHoraria(string id);
}