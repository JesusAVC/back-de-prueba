using Microsoft.EntityFrameworkCore;
using Modelos;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RolRepository: ICRUD<RolModel>
    {
        _dbContext db = new _dbContext();
        public RolModel ActualizarRegistro(RolModel input)
        {
            db.rol.Update(input);
            db.SaveChanges();
            return input;
        }
        public RolModel CrearRegistro(RolModel input)
        {
            db.rol.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            RolModel clie = db.rol.Find(id);
            db.rol.Remove(clie);
            return db.SaveChanges();
        }

        public List<RolModel> ListarTodo()
        {
            List<RolModel> clie = db.rol.ToList();
            return clie;
        }
        public RolModel ObtenerPorID(int id)
        {
            RolModel clie = db.rol.Find(id);
            return clie;
        }
    }
}
