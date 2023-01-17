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
    public class DetalleVentaRepository : ICRUD<DetalleVentaModel>
    {
        _dbContext db = new _dbContext();
        public DetalleVentaModel ActualizarRegistro(DetalleVentaModel input)
        {
            db.detalleventa.Update(input);
            db.SaveChanges();
            return input;
        }

        public DetalleVentaModel CrearRegistro(DetalleVentaModel input)
        {
            db.detalleventa.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            DetalleVentaModel clie = db.detalleventa.Find(id);
            db.detalleventa.Remove(clie);
            return db.SaveChanges();
        }

        public List<DetalleVentaModel> ListarTodo()
        {
            List<DetalleVentaModel> clie = db.detalleventa.ToList();
            return clie;
        }

        public DetalleVentaModel ObtenerPorID(int id)
        {
            DetalleVentaModel clie = db.detalleventa.Find(id);
            return clie;
        }
    }
}
