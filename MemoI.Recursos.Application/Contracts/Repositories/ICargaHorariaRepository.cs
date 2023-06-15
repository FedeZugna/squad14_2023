using MemoI.Recursos.Domain;

namespace MemoI.Recursos.Application.Contracts.Repositories;

public interface ICargaHorariaRepository
{
    Task Add(CargaHoraria cargaHoraria);
    Task Delete(string id);
}