using Modelos;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProveedorRespository : ICRUD<ProveedorModel>
    {
        _dbContext db = new _dbContext();

        public ProveedorModel ActualizarRegistro(ProveedorModel input)
        {
            db.proveedor.Update(input);
            db.SaveChanges();
            return input;
        }

        public ProveedorModel CrearRegistro(ProveedorModel input)
        {
            db.proveedor.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            ProveedorModel borrar = db.proveedor.Find(id);
            db.proveedor.Remove(borrar);
            return db.SaveChanges();
        }

        public List<ProveedorModel> ListarTodo()
        {
            List<ProveedorModel> lista = db.proveedor.ToList();
            return lista;
        }

        public ProveedorModel ObtenerPorID(int id)
        {
            ProveedorModel listaId = db.proveedor.Find(id);
            return listaId;
        }
    }
}
