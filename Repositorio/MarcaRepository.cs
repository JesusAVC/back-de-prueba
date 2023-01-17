using Modelos;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class MarcaRepository : ICRUD<MarcaModel>
    {
        _dbContext db = new _dbContext();
        public MarcaModel ActualizarRegistro(MarcaModel input)
        {
            db.marca.Update(input);
            db.SaveChanges();
            return input;
        }

        public MarcaModel CrearRegistro(MarcaModel input)
        {
            db.marca.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            MarcaModel borrar = db.marca.Find(id);
            db.marca.Remove(borrar);
            return db.SaveChanges();
        }

        public List<MarcaModel> ListarTodo()
        {
            List<MarcaModel> lista = db.marca.ToList();
            return lista;
        }

        public MarcaModel ObtenerPorID(int id)
        {
            MarcaModel listaId = db.marca.Find(id);
            return listaId;
        }
    }
}
