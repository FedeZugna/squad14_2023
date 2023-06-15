using MemoI.Recursos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MemoI.Recursos.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("tbl_user").HasKey(x => x.Legajo);
        builder.Property(t => t.Legajo).HasColumnName("legajo");
        builder.Property(t => t.Nombre).HasColumnName("nombre");
        builder.Property(t => t.Apellido).HasColumnName("apellido");
    }
    
}