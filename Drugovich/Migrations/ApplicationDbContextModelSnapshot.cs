﻿// <auto-generated />
using System;
using Drugovich.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Drugovich.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Drugovich.Entities.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Grupoid")
                        .HasColumnType("integer");

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)");

                    b.Property<DateTime>("fundacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.HasKey("id");

                    b.HasIndex("Grupoid");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Grupoid = 1,
                            cnpj = "1234567890",
                            fundacao = new DateTime(2008, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 1"
                        },
                        new
                        {
                            id = 2,
                            Grupoid = 1,
                            cnpj = "1234567891",
                            fundacao = new DateTime(2009, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 2"
                        },
                        new
                        {
                            id = 3,
                            Grupoid = 1,
                            cnpj = "1234567892",
                            fundacao = new DateTime(2010, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 3"
                        },
                        new
                        {
                            id = 4,
                            Grupoid = 1,
                            cnpj = "1234567893",
                            fundacao = new DateTime(2011, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 4"
                        },
                        new
                        {
                            id = 5,
                            Grupoid = 1,
                            cnpj = "1234567894",
                            fundacao = new DateTime(2012, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 5"
                        },
                        new
                        {
                            id = 6,
                            Grupoid = 1,
                            cnpj = "1234567895",
                            fundacao = new DateTime(2013, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 6"
                        },
                        new
                        {
                            id = 7,
                            Grupoid = 1,
                            cnpj = "1234567896",
                            fundacao = new DateTime(2014, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 7"
                        },
                        new
                        {
                            id = 8,
                            Grupoid = 1,
                            cnpj = "1234567897",
                            fundacao = new DateTime(2015, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 8"
                        },
                        new
                        {
                            id = 9,
                            Grupoid = 1,
                            cnpj = "1234567898",
                            fundacao = new DateTime(2016, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 9"
                        },
                        new
                        {
                            id = 10,
                            Grupoid = 1,
                            cnpj = "1234567899",
                            fundacao = new DateTime(2017, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc),
                            nome = "Cliente 10"
                        });
                });

            modelBuilder.Entity("Drugovich.Entities.Gerente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<int>("nivel")
                        .HasColumnType("integer");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("id");

                    b.ToTable("Gerentes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            email = "gerente1@gmail.com",
                            nivel = 1,
                            nome = "Gerente 1"
                        },
                        new
                        {
                            id = 2,
                            email = "gerente2@gmail.com",
                            nivel = 2,
                            nome = "Gerente 2"
                        },
                        new
                        {
                            id = 3,
                            email = "gerente3@gmail.com",
                            nivel = 1,
                            nome = "Gerente 3"
                        },
                        new
                        {
                            id = 4,
                            email = "gerente4@gmail.com",
                            nivel = 2,
                            nome = "Gerente 4"
                        },
                        new
                        {
                            id = 5,
                            email = "gerente5@gmail.com",
                            nivel = 1,
                            nome = "Gerente 5"
                        });
                });

            modelBuilder.Entity("Drugovich.Entities.Grupo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("id");

                    b.ToTable("Grupos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Grupo 1"
                        });
                });

            modelBuilder.Entity("Drugovich.Entities.Cliente", b =>
                {
                    b.HasOne("Drugovich.Entities.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("Grupoid");

                    b.Navigation("Grupo");
                });
#pragma warning restore 612, 618
        }
    }
}
