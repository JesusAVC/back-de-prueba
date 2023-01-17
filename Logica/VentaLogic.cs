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
    public class VentaLogic : ICRUDLO<VentaModel>
    {
        VentaRepository repo = new VentaRepository();
        public VentaModel ActualizarRegistro(VentaModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public VentaModel CrearRegistro(VentaModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = repo.EliminarRegistro(id);
            return id;
        }

        public List<VentaModel> ListarTodo()
        {
            List<VentaModel> lista = repo.ListarTodo();
            return lista;
        }

        public VentaModel ObtenerPorId(int id)
        {
            VentaModel resultado = repo.ObtenerPorID(id);
            return resultado;
        }
    }
}
