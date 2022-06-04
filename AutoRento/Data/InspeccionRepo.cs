using AutoRento.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    internal class InspeccionRepo : IRecordRepo<Inspeccion>
    {
        public Inspeccion Create(Inspeccion t)
        {
            t.Id = null;
            t.Empleado = null;
            t.Cliente = null;
            t.Vehiculo = null;
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Add(t);
            db.SaveChanges();
            return data.Entity;
        }

        public void Delete(Inspeccion t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public Inspeccion Update(Inspeccion t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<Inspeccion> View()
        {
            using AutoRentoContext db = new AutoRentoContext();
            return db.Inspecciones.Include(x => x.Vehiculo).Include(x => x.Cliente).Include(x => x.Empleado).ToList();
        }
    }
}
