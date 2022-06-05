using AutoRento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    internal class MarcaRepo : IRecordRepo<Marca>
    {
        public Marca Create(Marca t)
        {
            t.Id = null;
            using AutoRentoContext empContext = new AutoRentoContext();
            var data = empContext.Add(t);
            empContext.SaveChanges();
            return data.Entity;
        }

        public void Delete(Marca t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public Marca Update(Marca t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<Marca> View(bool all = true)
        {
            using AutoRentoContext db = new AutoRentoContext();
            if (all)
            {
                return db.Marcas.ToList();

            }
            else
            {
                return db.Marcas.Where(x => x.Estado == true).ToList();

            }
        }
    }
}
