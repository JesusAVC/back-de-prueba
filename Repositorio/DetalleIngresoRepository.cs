using Modelos;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DetalleIngresoRepository : ICRUD<DetalleIngresoModel>
    {
        _dbContext db = new _dbContext();

        public DetalleIngresoModel ActualizarRegistro(DetalleIngresoModel input)
        {
            db.detalleingreso.Update(input);
            db.SaveChanges();
            return input;
        }

        public DetalleIngresoModel CrearRegistro(DetalleIngresoModel input)
        {
            db.detalleingreso.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            DetalleIngresoModel borrar = db.detalleingreso.Find(id);
            db.detalleingreso.Remove(borrar);
            return db.SaveChanges();
        }

        public List<DetalleIngresoModel> ListarTodo()
        {
            List<DetalleIngresoModel> lista = db.detalleingreso.ToList();
            return lista;
        }

        public DetalleIngresoModel ObtenerPorID(int id)
        {
            DetalleIngresoModel listaId = db.detalleingreso.Find(id);
            return listaId;
        }
    }
}
