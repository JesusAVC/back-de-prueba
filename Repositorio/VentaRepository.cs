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
    public class VentaRepository : ICRUD<VentaModel>
    {
        _dbContext db = new _dbContext();
        public VentaModel ActualizarRegistro(VentaModel input)
        {
            db.venta.Update(input);
            db.SaveChanges();
            return input;
        }

        public VentaModel CrearRegistro(VentaModel input)
        {
            db.venta.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            VentaModel clie = db.venta.Find(id);
            db.venta.Remove(clie);
            return db.SaveChanges();
        }

        public List<VentaModel> ListarTodo()
        {
            List<VentaModel> clie = db.venta.ToList();
            return clie;
        }

        public VentaModel ObtenerPorID(int id)
        {
            VentaModel clie = db.venta.Find(id);
            return clie;
        }
    }
}
