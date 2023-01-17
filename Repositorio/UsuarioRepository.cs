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
    public class UsuarioRepository : ICRUD<UsuarioModel>
    {
        _dbContext db = new _dbContext();
        public UsuarioModel ActualizarRegistro(UsuarioModel input)
        {
            db.usuario.Update(input);
            db.SaveChanges();
            return input;
        }

        public UsuarioModel CrearRegistro(UsuarioModel input)
        {
            db.usuario.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            UsuarioModel clie = db.usuario.Find(id);
            db.usuario.Remove(clie);
            return db.SaveChanges();
        }

        public List<UsuarioModel> ListarTodo()
        {
            List<UsuarioModel> clie = db.usuario.ToList();
            return clie;
        }

        public UsuarioModel ObtenerPorID(int id)
        {
            UsuarioModel clie = db.usuario.Find(id);
            return clie;
        }
        public UsuarioModel ObtenerUsuarioPorUserrName(string numusuario)
        {
            // sintaxis lambda
            UsuarioModel user = db.usuario.Where(x => x.num_documento == numusuario).FirstOrDefault();
            return user;
        }
    }
}
