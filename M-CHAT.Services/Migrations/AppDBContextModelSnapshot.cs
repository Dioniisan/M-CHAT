﻿// <auto-generated />
using System;
using M_CHAT.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace M_CHAT.Services.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("M_CHAT.Models.CentroE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentroEID")
                        .HasColumnType("int");

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NinioID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NinioID");

                    b.ToTable("CentrosE");
                });

            modelBuilder.Entity("M_CHAT.Models.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("CuentaID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("M_CHAT.Models.Ninio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CURP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Fecha_nac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NinioID")
                        .HasColumnType("int");

                    b.Property<string>("Nom_Comp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ninios");
                });

            modelBuilder.Entity("M_CHAT.Models.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NinioID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TutorID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NinioID");

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("M_CHAT.Models.CentroE", b =>
                {
                    b.HasOne("M_CHAT.Models.Ninio", "Ninio")
                        .WithMany("CentrosE")
                        .HasForeignKey("NinioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("M_CHAT.Models.Tutor", b =>
                {
                    b.HasOne("M_CHAT.Models.Ninio", "Ninio")
                        .WithMany("Tutors")
                        .HasForeignKey("NinioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
