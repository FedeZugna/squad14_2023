using MemoI.Recursos.Domain;

namespace MemoI.Recursos.Application.Contracts.Repositories;

public interface IUserRepository
{
    Task Add(User ticket);
}