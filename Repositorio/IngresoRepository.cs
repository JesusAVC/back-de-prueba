using Modelos;
using Repositorio.Interfaz;

namespace Repositorio
{
    public class IngresoRepository : ICRUD<IngresoModel>
    {
        _dbContext db = new _dbContext();

        public IngresoModel ActualizarRegistro(IngresoModel input)
        {
            db.ingreso.Update(input);
            db.SaveChanges();
            return input;
        }

        public IngresoModel CrearRegistro(IngresoModel input)
        {
            db.ingreso.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            IngresoModel borrar = db.ingreso.Find(id);
            db.ingreso.Remove(borrar);
            return db.SaveChanges();
        }

        public List<IngresoModel> ListarTodo()
        {
            List<IngresoModel> lista = db.ingreso.ToList();
            return lista;
        }

        public IngresoModel ObtenerPorID(int id)
        {
            IngresoModel listaId = db.ingreso.Find(id);
            return listaId;
        }
    }
}
