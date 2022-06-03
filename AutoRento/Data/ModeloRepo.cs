using AutoRento.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    internal class ModeloRepo : IRecordRepo<Modelo>
    {
        public Modelo Create(Modelo t)
        {
            t.Id = null;
            t.Marca = null;
            using AutoRentoContext empContext = new AutoRentoContext();
            var data = empContext.Add(t);
            empContext.SaveChanges();
            return data.Entity;
        }

        public void Delete(Modelo t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public Modelo Update(Modelo t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<Modelo> View()
        {
            using AutoRentoContext db = new AutoRentoContext();
            return db.Modelos.Include(m => m.Marca).ToList();
        }
    }
}
