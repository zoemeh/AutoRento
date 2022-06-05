﻿// <auto-generated />
using System;
using AutoRento.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoRento.Migrations
{
    [DbContext(typeof(AutoRentoContext))]
    partial class AutoRentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutoRento.Models.Cliente", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<double>("LimiteCredito")
                        .HasColumnType("float");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaCredito")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AutoRento.Models.Empleado", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PorcienteComision")
                        .HasColumnType("float");

                    b.Property<string>("TandaLabor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("AutoRento.Models.Inspeccion", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<bool>("CheckGomaDerD")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckGomaDerT")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckGomaIzqD")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckGomaIzqT")
                        .HasColumnType("bit");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<double>("Combustible")
                        .HasColumnType("float");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TieneGato")
                        .HasColumnType("bit");

                    b.Property<bool>("TieneGomaRespuesta")
                        .HasColumnType("bit");

                    b.Property<bool>("TieneRoturaCristal")
                        .HasColumnType("bit");

                    b.Property<int?>("VehiculoId")
                        .HasColumnType("int");

                    b.Property<bool>("tieneRalladuras")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Inspecciones");
                });

            modelBuilder.Entity("AutoRento.Models.Marca", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("AutoRento.Models.Modelo", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int?>("MarcaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("AutoRento.Models.Renta", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Devuelto")
                        .HasColumnType("bit");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRenta")
                        .HasColumnType("datetime2");

                    b.Property<double>("MontoDia")
                        .HasColumnType("float");

                    b.Property<int?>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Rentas");
                });

            modelBuilder.Entity("AutoRento.Models.TipoCombustible", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TiposCombustible");
                });

            modelBuilder.Entity("AutoRento.Models.TipoVehiculo", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TiposVehiculo");
                });

            modelBuilder.Entity("AutoRento.Models.Usuario", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AutoRento.Models.Vehiculo", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int?>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroChasis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroMotor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroPlaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoCombustibleId")
                        .HasColumnType("int");

                    b.Property<int>("TipoVehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ModeloId");

                    b.HasIndex("TipoCombustibleId");

                    b.HasIndex("TipoVehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("AutoRento.Models.Inspeccion", b =>
                {
                    b.HasOne("AutoRento.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("AutoRento.Models.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoRento.Models.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId");

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("AutoRento.Models.Modelo", b =>
                {
                    b.HasOne("AutoRento.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("AutoRento.Models.Renta", b =>
                {
                    b.HasOne("AutoRento.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("AutoRento.Models.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId");

                    b.HasOne("AutoRento.Models.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId");

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("AutoRento.Models.Vehiculo", b =>
                {
                    b.HasOne("AutoRento.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.HasOne("AutoRento.Models.Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId");

                    b.HasOne("AutoRento.Models.TipoCombustible", "TipoCombustible")
                        .WithMany()
                        .HasForeignKey("TipoCombustibleId");

                    b.HasOne("AutoRento.Models.TipoVehiculo", "TipoVehiculo")
                        .WithMany()
                        .HasForeignKey("TipoVehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marca");

                    b.Navigation("Modelo");

                    b.Navigation("TipoCombustible");

                    b.Navigation("TipoVehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
