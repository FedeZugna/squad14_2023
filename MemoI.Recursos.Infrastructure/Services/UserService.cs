using AutoMapper;
using MemoI.Recursos.Application.Contracts.Repositories;
using MemoI.Recursos.Application.Contracts.Services;
using MemoI.Recursos.Application.Dtos.Users;
using MemoI.Recursos.Application.Responses;
using MemoI.Recursos.Domain;

namespace MemoI.Recursos.Infrastructure.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    
    public UserService(
        IUserRepository userRepository, 
        IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<BaseResponse> CreateUser(CreateUserDto createUserDto)
    {
        try
        {
            var user = _mapper.Map<User>(createUserDto);
            user.Id = Guid.NewGuid().ToString();
            await _userRepository.Add(user);

            return new BaseResponse(true, user.Id);
        }
        catch (Exception e)
        {
            return new BaseResponse(false, "", e.Message);
        }
    }
        
}