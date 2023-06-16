using MemoI.Recursos.Application.Dtos.Users;
using MemoI.Recursos.Application.Responses;

namespace MemoI.Recursos.Application.Contracts.Services;

public interface IUserService
{
    Task<List<UserDto>> GetUsers();
}