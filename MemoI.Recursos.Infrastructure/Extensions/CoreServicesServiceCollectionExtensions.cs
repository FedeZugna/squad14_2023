using MemoI.Recursos.Application.Contracts.Services;
using MemoI.Recursos.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MemoI.Recursos.Infrastructure.Extensions;

public static class CoreServicesServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        // Services
        services.AddScoped<IUserService, UserService>();
        // services.AddScoped<ICommentService, CommentService>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        return services;
    }
}