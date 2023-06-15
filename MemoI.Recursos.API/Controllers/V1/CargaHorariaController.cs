using MemoI.Recursos.Application.Contracts.Services;
using MemoI.Recursos.Application.Dtos.CargaHorarias;
using MemoI.Recursos.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MemoI.Recursos.API.Controllers.V1;

[Route("api/v1/cargahoraria")]
[ApiController]
public class CargaHorariaController : Controller
{

    private readonly ICargaHorariaService _cargaHorariaService;

    public CargaHorariaController(ICargaHorariaService commentService)
    {
        _cargaHorariaService = commentService;
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BaseResponse>> CreateCargaHoraria([FromBody] CreateCargaHorariaDto createCargaHorariaDto)
    {
        var response = await _cargaHorariaService.CreateCargaHoraria(createCargaHorariaDto);
        return response.Success ? Ok(response) : BadRequest(response);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BaseResponse>> DeleteCargaHoraria(string id)
    {
        var response = await _cargaHorariaService.DeleteCargaHoraria(id);
        return response.Success ? Ok(response) : BadRequest(response);
    }
    

}