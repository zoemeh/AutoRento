using AutoRento.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    internal class VehiculoRepo : IRecordRepo<Vehiculo>
    {
        public Vehiculo Create(Vehiculo t)
        {
            t.Id = null;
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Add(t);
            db.SaveChanges();
            return data.Entity;
        }

        public void Delete(Vehiculo t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public Vehiculo Update(Vehiculo t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<Vehiculo> View(bool all = true)
        {
            using AutoRentoContext db = new AutoRentoContext();
            if (all)
            {
                return db.Vehiculos.Include(x => x.Modelo).Include(x => x.Marca).Include(x => x.TipoVehiculo).Include(x => x.TipoCombustible).ToList();

            }
            else
            {
                return db.Vehiculos.Include(x => x.Modelo).Include(x => x.Marca).Include(x => x.TipoVehiculo).Include(x => x.TipoCombustible).Where(x => x.Estado == true).ToList();

            }
        }
    }
}
