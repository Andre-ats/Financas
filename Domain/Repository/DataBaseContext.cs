using Financas.Entity.Financas;
using Financas.Entity.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Financas.Repository;

public class DataBaseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder.UseNpgsql("User ID=andre;Host=localhost;Port=5432;DataBase=financasBase;Password=1234;Include Error Detail=True");
        
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>(user =>
        {
            user.ToTable("Usuario");
        });

        modelBuilder.Entity<Gasto>(user =>
        {
            user.ToTable("Gasto");
        });

        modelBuilder.Entity<Receita>(user =>
        {
            user.ToTable("Receita");
        });

        modelBuilder.Entity<Usuario>()
            .Property(x => x.Nome)
            .IsRequired(true)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);
        modelBuilder.Entity<Usuario>()
            .Property(x => x.ReceitaAtual);
        modelBuilder.Entity<Usuario>()
            .Property(x => x.ReceitaInicial)
            .IsRequired(true);
        modelBuilder.Entity<Usuario>()
            .Property(x => x.DataDeCadastro)
            .HasColumnType("DATETIME2");
        
        modelBuilder.Entity<Gasto>()
            .Property(x => x.TituloGasto)
            .IsRequired(true)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);
        modelBuilder.Entity<Gasto>()
            .Property(x => x.DescricaoGasto)
            .IsRequired(false)
            .HasMaxLength(255);
        modelBuilder.Entity<Gasto>()
            .Property(x => x.Estabelecimento)
            .IsRequired(false)
            .HasMaxLength(80);
        modelBuilder.Entity<Gasto>()
            .Property(x => x.DataGasto)
            .HasColumnType("DATETIME2")
            .IsRequired(true);
        modelBuilder.Entity<Gasto>()
            .Property(x => x.GastoDinheiro)
            .IsRequired(true);
        
        modelBuilder.Entity<Receita>()
            .Property(x => x.TituloReceita)
            .IsRequired(true)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);
        modelBuilder.Entity<Receita>()
            .Property(x => x.TituloReceita)
            .IsRequired(false)
            .HasMaxLength(255);
        modelBuilder.Entity<Receita>()
            .Property(x => x.Estabelecimento)
            .IsRequired(false)
            .HasMaxLength(80);
        modelBuilder.Entity<Receita>()
            .Property(x => x.DataReceita)
            .HasColumnType("DATETIME2")
            .IsRequired(true);
        modelBuilder.Entity<Receita>()
            .Property(x => x.ReceitaDinheiro)
            .IsRequired(true); 
    }
    
    public System.Data.Entity.DbSet<Gasto> GastoDB { get; set; }
    public System.Data.Entity.DbSet<Receita> ReceitaDB { get; set; }
    public System.Data.Entity.DbSet<Usuario> UsaurioDB { get; set; }
} 