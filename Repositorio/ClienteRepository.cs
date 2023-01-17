using Modelos;
using Repositorio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ClienteRepository : ICRUD<ClienteModel>
    {
        _dbContext db=new _dbContext();

        public ClienteModel ActualizarRegistro(ClienteModel input)
        {
            db.cliente.Update(input);
            db.SaveChanges();
            return input;
        }

        public ClienteModel CrearRegistro(ClienteModel input)
        {
            db.cliente.Add(input);
            db.SaveChanges();
            return input;
        }

        public int EliminarRegistro(int id)
        {
            ClienteModel borrar = db.cliente.Find(id);
            db.cliente.Remove(borrar);
            return db.SaveChanges();
        }

        public List<ClienteModel> ListarTodo()
        {
            List<ClienteModel> lista=db.cliente.ToList();
            return lista;
        }

        public ClienteModel ObtenerPorID(int id)
        {
            ClienteModel listaId=db.cliente.Find(id);
            return listaId;
        }
    }
}
