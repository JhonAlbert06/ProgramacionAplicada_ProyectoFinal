﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal_JhonAlbert.DAL;

#nullable disable

namespace ProyectoFinal_JhonAlbert.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220403153620_Septima")]
    partial class Septima
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("ProyectoFinal_JhonAlbert.Entidades.Aseguradora", b =>
                {
                    b.Property<int>("AseguradoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AseguradoraId");

                    b.ToTable("Aseguradora");

                    b.HasData(
                        new
                        {
                            AseguradoraId = 1,
                            Nombre = "Senasa"
                        },
                        new
                        {
                            AseguradoraId = 2,
                            Nombre = "Humano"
                        },
                        new
                        {
                            AseguradoraId = 3,
                            Nombre = "Seguros Universal"
                        },
                        new
                        {
                            AseguradoraId = 4,
                            Nombre = "Reservas"
                        },
                        new
                        {
                            AseguradoraId = 5,
                            Nombre = "Mapfre BHD"
                        },
                        new
                        {
                            AseguradoraId = 6,
                            Nombre = "La Monumental"
                        },
                        new
                        {
                            AseguradoraId = 7,
                            Nombre = "Mapfre BHD"
                        },
                        new
                        {
                            AseguradoraId = 8,
                            Nombre = "La Monumental"
                        });
                });

            modelBuilder.Entity("ProyectoFinal_JhonAlbert.Entidades.Factura", b =>
                {
                    b.Property<int>("FacturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aseguradora")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaFactura")
                        .HasColumnType("TEXT");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FacturaId");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("ProyectoFinal_JhonAlbert.Entidades.FacturaDetalle", b =>
                {
                    b.Property<int>("FacturaDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FacturaId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Procedimiento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProcedimientoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FacturaDetalleId");

                    b.HasIndex("FacturaId");

                    b.ToTable("FacturaDetalle");
                });

            modelBuilder.Entity("ProyectoFinal_JhonAlbert.Entidades.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<char>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("PacienteId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("ProyectoFinal_JhonAlbert.Entidades.Procedimiento", b =>
                {
                    b.Property<int>("ProcedimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("ProcedimientoId");

                    b.ToTable("Procedimiento");
                });

            modelBuilder.Entity("ProyectoFinal_JhonAlbert.Entidades.FacturaDetalle", b =>
                {
                    b.HasOne("ProyectoFinal_JhonAlbert.Entidades.Factura", null)
                        .WithMany("Detalle")
                        .HasForeignKey("FacturaId");
                });

            modelBuilder.Entity("ProyectoFinal_JhonAlbert.Entidades.Factura", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
