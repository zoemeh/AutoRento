using AutoRento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    public class EmpleadoRepo : IRecordRepo<Empleado>
    {
        public Empleado Create(Empleado t)
        {
            t.Id = null;
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Add(t);
            db.SaveChanges();
            return data.Entity;
        }

        public void Delete(Empleado t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public Empleado Update(Empleado t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<Empleado> View(bool all=true)
        {
            using AutoRentoContext db = new AutoRentoContext();
            if (all)
            {
                return db.Empleados.ToList();

            }
            else
            {
                return db.Empleados.Where(x => x.Estado == true).ToList();

            }
        }
    }
}
