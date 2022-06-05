using AutoRento.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Models
{
    internal class TipoCombustibleRepo : IRecordRepo<TipoCombustible>
    {
        public TipoCombustible Create(TipoCombustible t)
        {
            t.Id = null;
            using AutoRentoContext empContext = new AutoRentoContext();
            var data = empContext.Add(t);
            empContext.SaveChanges();
            return data.Entity;
        }

        public void Delete(TipoCombustible t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public TipoCombustible Update(TipoCombustible t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<TipoCombustible> View(bool all = true)
        {
            using AutoRentoContext db = new AutoRentoContext();
            if (all)
            {
                return db.TiposCombustible.ToList();

            }
            else
            {
                return db.TiposCombustible.Where(x => x.Estado == true).ToList();

            }
        }
    }
}
