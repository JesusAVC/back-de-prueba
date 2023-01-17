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
    public class ClienteLogic:ICRUDLO<ClienteModel>
    {
        ClienteRepository _clienteRepository = new ClienteRepository();

        public ClienteModel ActualizarRegistro(ClienteModel input)
        {
           input = _clienteRepository.ActualizarRegistro(input);
           return input;
        }

        public ClienteModel CrearRegistro(ClienteModel input)
        {
            input = _clienteRepository.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = _clienteRepository.EliminarRegistro(id);
            return id;
        }

        public List<ClienteModel> ListarTodo()
        {
            List<ClienteModel> lista = _clienteRepository.ListarTodo();
            return lista;
        }

        public ClienteModel ObtenerPorId(int id)
        {
            ClienteModel resultado = _clienteRepository.ObtenerPorID(id);
            return resultado;
        }
    }
}
