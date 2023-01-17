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
    public class ProveedorLogic : ICRUDLO<ProveedorModel>
    {
        ProveedorRespository _proveedorRepository = new ProveedorRespository();
        public ProveedorModel ActualizarRegistro(ProveedorModel input)
        {
            input = _proveedorRepository.ActualizarRegistro(input);
            return input;
        }

        public ProveedorModel CrearRegistro(ProveedorModel input)
        {
           input = _proveedorRepository.CrearRegistro(input);
           return input;
        }

        public int EliminarRegistro(int id)
        {
            id = _proveedorRepository.EliminarRegistro(id);
            return id;
        }

        public List<ProveedorModel> ListarTodo()
        {
            List<ProveedorModel> lista = _proveedorRepository.ListarTodo();
            return lista;
        }

        public ProveedorModel ObtenerPorId(int id)
        {
            ProveedorModel resultado = _proveedorRepository.ObtenerPorID(id);
            return resultado;
        }
    }
}
