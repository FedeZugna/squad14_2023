﻿using AutoMapper;
using MemoI.Recursos.Application.Contracts.Repositories;
using MemoI.Recursos.Application.Contracts.Services;
using MemoI.Recursos.Application.Dtos.CargaHorarias;
using MemoI.Recursos.Application.Responses;
using MemoI.Recursos.Domain;

namespace MemoI.Recursos.Infrastructure.Services;

public class CargaHorariaService: ICargaHorariaService
{
    private readonly ICargaHorariaRepository _cargaHorariaRepository;
    private readonly IMapper _mapper;
    
    public CargaHorariaService(
        ICargaHorariaRepository cargaHorariaRepository, 
        IMapper mapper)
    {
        _cargaHorariaRepository = cargaHorariaRepository;
        _mapper = mapper;
    }
    
    public async Task<BaseResponse> CreateCargaHoraria(CreateCargaHorariaDto createCargaHorariaDto)
    {
        try
        {
            var cargaHoraria = _mapper.Map<CargaHoraria>(createCargaHorariaDto);
            cargaHoraria.Id = Guid.NewGuid().ToString();
            cargaHoraria.apellido = createCargaHorariaDto.apellido;
            cargaHoraria.nombre = createCargaHorariaDto.nombre;
            cargaHoraria.proyecto = createCargaHorariaDto.proyecto;
            cargaHoraria.tarea = createCargaHorariaDto.tarea;
            cargaHoraria.fecha = createCargaHorariaDto.fecha;
            cargaHoraria.horas = createCargaHorariaDto.horas;
            await _cargaHorariaRepository.Add(cargaHoraria);

            return new BaseResponse(true, cargaHoraria.Id);
        }
        catch (Exception e)
        {
            return new BaseResponse(false, "", e.Message);
        }
    }

    public async Task<BaseResponse> DeleteCargaHoraria(string id)
    {
        try
        {
            
            await _cargaHorariaRepository.Delete(id);

            return new BaseResponse(true, id);
        }
        catch (Exception e)
        {
            return new BaseResponse(false, "", e.Message);
        }
    }
}