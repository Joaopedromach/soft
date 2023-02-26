﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Soft.Models;

#nullable disable

namespace Soft.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {

            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Soft.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Documento");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Endereco");

                    b.Property<string>("Fantasia")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Fantasia");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Soft.Models.Login", b =>
                {
                    b.Property<string>("Usuario")
                        .HasColumnType("text")
                        .HasColumnName("Usuario");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Senha");

                    b.HasKey("Usuario");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("Soft.Models.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Codigo");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Descricao");

                    b.Property<double>("PesoBruto")
                        .HasColumnType("double precision")
                        .HasColumnName("PesoBruto");

                    b.Property<double>("PesoLiquido")
                        .HasColumnType("double precision")
                        .HasColumnName("PesoLiquido");

                    b.Property<double>("Venda")
                        .HasColumnType("double precision")
                        .HasColumnName("Venda");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

        }
    }
}
