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
    public class CategoriaLogic : ICRUDLO<CategoriaModel>
    {
        CategoriaRepository _categoriaRepository = new CategoriaRepository();

        public CategoriaModel ActualizarRegistro(CategoriaModel input)
        {
            input = _categoriaRepository.ActualizarRegistro(input);
            return input;
        }

        public CategoriaModel CrearRegistro(CategoriaModel input)
        {
            input = _categoriaRepository.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = _categoriaRepository.EliminarRegistro(id);
            return id;
        }

        public List<CategoriaModel> ListarTodo()
        {
            List<CategoriaModel> lista = _categoriaRepository.ListarTodo();
            return lista;
        }

        public CategoriaModel ObtenerPorId(int id)
        {
            CategoriaModel resultado = _categoriaRepository.ObtenerPorID(id);
            return resultado;
        }
    }
}
