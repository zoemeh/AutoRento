using AutoRento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    internal class TipoVehiculoRepo : IRecordRepo<TipoVehiculo>
    {
        public TipoVehiculo Create(TipoVehiculo t)
        {
            t.Id = null;
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Add(t);
            db.SaveChanges();
            return data.Entity;
        }

        public void Delete(TipoVehiculo t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public TipoVehiculo Update(TipoVehiculo t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<TipoVehiculo> View(bool all = true)
        {
            using AutoRentoContext db = new AutoRentoContext();
            if (all)
            {
                return db.TiposVehiculo.ToList();

            }
            else
            {
                return db.TiposVehiculo.Where(x => x.Estado == true).ToList();

            }
        }
    }
}
