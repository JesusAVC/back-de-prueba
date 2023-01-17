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
    public class DetalleIngresoLogic : ICRUDLO<DetalleIngresoModel>
    {
        DetalleIngresoRepository _detalleingresoRepository = new DetalleIngresoRepository();

        public DetalleIngresoModel ActualizarRegistro(DetalleIngresoModel input)
        {
            input = _detalleingresoRepository.ActualizarRegistro(input);
            return input;
        }

        public DetalleIngresoModel CrearRegistro(DetalleIngresoModel input)
        {
            input = _detalleingresoRepository.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = _detalleingresoRepository.EliminarRegistro(id);
            return id;
        }

        public List<DetalleIngresoModel> ListarTodo()
        {
            List<DetalleIngresoModel> lista = _detalleingresoRepository.ListarTodo();
            return lista;
        }

        public DetalleIngresoModel ObtenerPorId(int id)
        {
            DetalleIngresoModel resultado = _detalleingresoRepository.ObtenerPorID(id);
            return resultado;
        }
    }
}
