using Modelos;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProductoRepository : ICRUD<ProductoModel>
    {
        _dbContext db = new _dbContext();
        public ProductoModel ActualizarRegistro(ProductoModel input)
        {
            db.producto.Update(input);
            db.SaveChanges();
            return input;
        }

        public ProductoModel CrearRegistro(ProductoModel input)
        {
            db.producto.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            ProductoModel borrar = db.producto.Find(id);
            db.producto.Remove(borrar);
            return db.SaveChanges();
        }

        public List<ProductoModel> ListarTodo()
        {
            List<ProductoModel> lista = db.producto.ToList();
            return lista;
        }

        public ProductoModel ObtenerPorID(int id)
        {
            ProductoModel listaId = db.producto.Find(id);
            return listaId;
        }
    }
}
