using DesafioArquiteturalCIT.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DesafioArquiteturalCIT.Infra
{
    public class FinanceiroDbContext : DbContext
    {
        public FinanceiroDbContext(DbContextOptions<FinanceiroDbContext> options)
            : base(options) { }

        public DbSet<LancamentoDiario> LancamentosDiarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LancamentoDiario>(entity =>
            {
                entity.ToTable("LancamentosDiarios");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.TipoLancamento)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(e => e.Valor)
                      .HasColumnType("money");

                entity.Property(e => e.DataLancamento)
                      .HasColumnType("datetime");
            });
        }
    }

}
