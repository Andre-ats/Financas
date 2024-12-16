﻿// <auto-generated />
using System;
using Financas.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Financas.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Financas.Entity.Financas.Gasto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataGasto")
                        .HasColumnType("timestamptz");

                    b.Property<string>("DescricaoGasto")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Estabelecimento")
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<long>("GastoDinheiro")
                        .HasColumnType("bigint");

                    b.Property<string>("TituloGasto")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Gasto", (string)null);
                });

            modelBuilder.Entity("Financas.Entity.Financas.Receita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataReceita")
                        .HasColumnType("timestamptz");

                    b.Property<string>("DescricaoReceita")
                        .HasColumnType("text");

                    b.Property<string>("Estabelecimento")
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<long>("ReceitaDinheiro")
                        .HasColumnType("bigint");

                    b.Property<string>("TituloReceita")
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Receita", (string)null);
                });

            modelBuilder.Entity("Financas.Entity.Usuario.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("timestamptz");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("VARCHAR");

                    b.Property<long>("ReceitaAtual")
                        .HasColumnType("bigint");

                    b.Property<long>("ReceitaInicial")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Usuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
