using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Infrastructure.Data;

public class ManejoDbContext : DbContext
{
    public ManejoDbContext(DbContextOptions<ManejoDbContext> options)
        : base(options) { }

    public DbSet<Animal> Animais => Set<Animal>();
    public DbSet<Pesagem> Pesagens => Set<Pesagem>();
    public DbSet<Manejo> Manejos => Set<Manejo>();
    public DbSet<ManejoAnimal> ManejoAnimais => Set<ManejoAnimal>();
    public DbSet<Lote> Lotes => Set<Lote>();
    public DbSet<HistoricoLote> HistoricoLotes => Set<HistoricoLote>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ANIMAL
        modelBuilder.Entity<Animal>()
            .HasIndex(a => a.Brinco)
            .IsUnique();

        // PESAGEM
        modelBuilder.Entity<Pesagem>()
            .HasIndex(p => new { p.AnimalId, p.Data })
            .IsUnique();

        modelBuilder.Entity<Pesagem>()
            .HasOne(p => p.Animal)
            .WithMany(a => a.Pesagens)
            .HasForeignKey(p => p.AnimalId);

        // MANEJO N:N
        modelBuilder.Entity<ManejoAnimal>()
            .HasOne(ma => ma.Manejo)
            .WithMany(m => m.Animais)
            .HasForeignKey(ma => ma.ManejoId);

        modelBuilder.Entity<ManejoAnimal>()
            .HasOne(ma => ma.Animal)
            .WithMany(a => a.Manejos)
            .HasForeignKey(ma => ma.AnimalId);

        // HISTORICO LOTE
        modelBuilder.Entity<HistoricoLote>()
            .HasOne(h => h.Animal)
            .WithMany(a => a.HistoricoLotes)
            .HasForeignKey(h => h.AnimalId);

        modelBuilder.Entity<HistoricoLote>()
            .HasOne(h => h.Lote)
            .WithMany(l => l.HistoricoLotes)
            .HasForeignKey(h => h.LoteId);
    }
}
