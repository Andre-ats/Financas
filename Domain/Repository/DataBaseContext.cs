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
        
        optionsBuilder.UseNpgsql("User ID=financauser;Host=localhost;Port=5432;DataBase=financasbase;Password=1234;Include Error Detail=True");
        
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
            .HasKey(x => x.Id);
        modelBuilder.Entity<Usuario>()
            .Property(x => x.Nome)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);
        modelBuilder.Entity<Usuario>()
            .Property(x => x.ReceitaAtual);
        modelBuilder.Entity<Usuario>()
            .Property(x => x.ReceitaInicial);
        modelBuilder.Entity<Usuario>()
            .Property(x => x.DataDeCadastro)
            .HasColumnType("timestamptz");
        
        modelBuilder.Entity<Gasto>()
            .Property(x => x.TituloGasto)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
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
            .HasColumnType("timestamptz")
            .IsRequired(true);
        modelBuilder.Entity<Gasto>()
            .Property(x => x.GastoDinheiro)
            .IsRequired(true);
        
        modelBuilder.Entity<Receita>()
            .Property(x => x.TituloReceita)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
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
            .HasColumnType("timestamptz")
            .IsRequired(true);
        modelBuilder.Entity<Receita>()
            .Property(x => x.ReceitaDinheiro)
            .IsRequired(true); 
    }
    
    public DbSet<Gasto> GastoDB { get; set; }
    public DbSet<Receita> ReceitaDB { get; set; }
    public DbSet<Usuario> UsuarioDB { get; set; }
} 