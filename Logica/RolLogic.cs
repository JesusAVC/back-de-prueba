using Logica.Interfaz;
using Modelos;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class RolLogic: ICRUDLO<RolModel>
    {
        RolRepository repo = new RolRepository();
        public RolModel ActualizarRegistro(RolModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public RolModel CrearRegistro(RolModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = repo.EliminarRegistro(id);
            return id;
        }

        public List<RolModel> ListarTodo()
        {
            List<RolModel> lista = repo.ListarTodo();
            return lista;
        }

        public RolModel ObtenerPorId(int id)
        {
            RolModel resultado = repo.ObtenerPorID(id);
            return resultado;
        }
    }
}
