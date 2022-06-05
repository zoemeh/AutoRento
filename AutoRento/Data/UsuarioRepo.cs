using AutoRento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRento.Data
{
    internal class UsuarioRepo : IRecordRepo<Usuario>
    {
        public Usuario Create(Usuario t)
        {
            t.Id = null;
            using AutoRentoContext empContext = new AutoRentoContext();
            var data = empContext.Add(t);
            empContext.SaveChanges();
            return data.Entity;
        }

        public void Delete(Usuario t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            db.Remove(t);
            db.SaveChanges();
        }
        public Usuario Update(Usuario t)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var data = db.Update(t);
            db.SaveChanges();
            return data.Entity;
        }

        public List<Usuario> View(bool all=true)
        {
            using AutoRentoContext db = new AutoRentoContext();
            return db.Usuarios.ToList();
        }
    }
}
