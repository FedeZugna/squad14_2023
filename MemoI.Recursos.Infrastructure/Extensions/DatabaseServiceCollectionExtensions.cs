using MemoI.Recursos.Application.Contracts.Repositories;
using MemoI.Recursos.Infrastructure.Persistence;
using MemoI.Recursos.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MemoI.Recursos.Infrastructure.Extensions;

public static class DatabaseServiceCollectionExtensions
{
    public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Postgres");

        services.AddDbContext<RecursosDbContext>(
            options => options.UseNpgsql(connectionString));
        
            
        // Repositories
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICargaHorariaRepository, CargaHorariaRepository>();
        // services.AddScoped<ICommentRepository, CommentRepository>();
        
        return services;
    }
}