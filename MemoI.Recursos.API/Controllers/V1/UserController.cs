using MemoI.Recursos.Application.Contracts.Services;
using MemoI.Recursos.Application.Dtos.Users;
using MemoI.Recursos.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MemoI.Recursos.API.Controllers.V1;

[Route("api/v1/users")]
[ApiController]
public class UserController : Controller
{
    private readonly IUserService _userService;

    public UserController(IUserService commentService)
    {
        _userService = commentService;
    }
    

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BaseResponse>> CreateUsers()
    {
        var response = await _userService.CreateUser();
        return response.Success ? Ok(response) : BadRequest(response);
    }
    
}