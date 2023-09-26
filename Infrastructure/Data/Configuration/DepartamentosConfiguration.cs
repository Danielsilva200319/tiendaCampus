using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.configuration;
public class DespartamentosConfiguration : IEntityTypeConfiguration<Departamentos>
{
    public void Configure(EntityTypeBuilder<Departamentos> builder)
    {
        builder.ToTable("departamento");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.Paises)
        .WithMany(p => p.Departamentos)
        .HasForeingKey(p => p.IdPaisFk);
    }
}