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
    public class MarcaLogic : ICRUDLO<MarcaModel>
    {
        MarcaRepository _marcaRepository = new MarcaRepository();

        public MarcaModel ActualizarRegistro(MarcaModel input)
        {
            input = _marcaRepository.ActualizarRegistro(input);
            return input;
        }

        public MarcaModel CrearRegistro(MarcaModel input)
        {
            input = _marcaRepository.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = _marcaRepository.EliminarRegistro(id);
            return id;
        }

        public List<MarcaModel> ListarTodo()
        {
            List<MarcaModel> lista = _marcaRepository.ListarTodo();
            return lista;
        }

        public MarcaModel ObtenerPorId(int id)
        {
            MarcaModel resultado = _marcaRepository.ObtenerPorID(id);
            return resultado;
        }
    }
}
