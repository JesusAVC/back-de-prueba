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
    public class DetalleVentaLogic : ICRUDLO<DetalleVentaModel>
    {
        DetalleVentaRepository repo = new DetalleVentaRepository();
        public DetalleVentaModel ActualizarRegistro(DetalleVentaModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public DetalleVentaModel CrearRegistro(DetalleVentaModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = repo.EliminarRegistro(id);
            return id;
        }

        public List<DetalleVentaModel> ListarTodo()
        {
            List<DetalleVentaModel> lista = repo.ListarTodo();
            return lista;
        }

        public DetalleVentaModel ObtenerPorId(int id)
        {
            DetalleVentaModel resultado = repo.ObtenerPorID(id);
            return resultado;
        }
    }
}
