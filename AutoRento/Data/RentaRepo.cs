using AutoRento.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    internal class RentaRepo : IRecordRepo<Renta>
    {
        public Renta Create(Renta t)
        {
            t.Id = null;
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Add(t);
            db.SaveChanges();
            return data.Entity;
        }

        public void Delete(Renta t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public Renta Update(Renta t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<Renta> View()
        {
            using AutoRentoContext db = new AutoRentoContext();
            return db.Rentas.Include(x => x.Empleado).Include(x => x.Vehiculo).Include(x => x.Cliente).ToList();
        }
    }
}
