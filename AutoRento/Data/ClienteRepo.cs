using AutoRento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    public class ClienteRepo : IRecordRepo<Cliente>
    {
        public Cliente Create(Cliente t)
        {
            t.Id = null;
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Add(t);
            db.SaveChanges();
            return data.Entity;
        }

        public void Delete(Cliente t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public Cliente Update(Cliente t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<Cliente> View()
        {
            using AutoRentoContext db = new AutoRentoContext();
            return db.Clientes.ToList();
        }
    }
}
