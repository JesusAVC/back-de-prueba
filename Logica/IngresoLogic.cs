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
    public class IngresoLogic:ICRUDLO<IngresoModel>
    {   
        IngresoRepository _ingresoRepository = new IngresoRepository();

        public IngresoModel ActualizarRegistro(IngresoModel input)
        {
            input = _ingresoRepository.ActualizarRegistro(input);
            return input;
        }

        public IngresoModel CrearRegistro(IngresoModel input)
        {
            input = _ingresoRepository.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = _ingresoRepository.EliminarRegistro(id);
            return id;
        }

        public List<IngresoModel> ListarTodo()
        {
            List<IngresoModel> lista = _ingresoRepository.ListarTodo();
            return lista;
        }

        public IngresoModel ObtenerPorId(int id)
        {
            IngresoModel resultado = _ingresoRepository.ObtenerPorID(id);
            return resultado;
        }
    }
}
