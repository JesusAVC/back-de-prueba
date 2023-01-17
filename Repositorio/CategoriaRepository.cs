using Modelos;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class CategoriaRepository : ICRUD<CategoriaModel>
    {
        _dbContext db = new _dbContext();

        public CategoriaModel ActualizarRegistro(CategoriaModel input)
        {
            db.categoria.Update(input);
            db.SaveChanges();
            return input;
        }

        public CategoriaModel CrearRegistro(CategoriaModel input)
        {
            db.categoria.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            CategoriaModel borrar = db.categoria.Find(id);
            db.categoria.Remove(borrar);
            return db.SaveChanges();
        }

        public List<CategoriaModel> ListarTodo()
        {
            List<CategoriaModel> lista = db.categoria.ToList();
            return lista;
        }

        public CategoriaModel ObtenerPorID(int id)
        {
            CategoriaModel listaId = db.categoria.Find(id);
            return listaId;
        }
    }
}
