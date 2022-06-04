﻿using AutoRento.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    internal class AutoRentoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculo { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<TipoCombustible> TiposCombustible { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Renta> Rentas { get; set; }
        public DbSet<Inspeccion> Inspecciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=PUENTESANTO;Initial Catalog=TipoCombustibleDB;Integrated Security=True");
        }
    }
}
