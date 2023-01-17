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
    public class ProductoLogic : ICRUDLO<ProductoModel>
    {
        ProductoRepository _productoRepository = new ProductoRepository();

        public ProductoModel ActualizarRegistro(ProductoModel input)
        {
            input = _productoRepository.ActualizarRegistro(input);
            return input;
        }

        public ProductoModel CrearRegistro(ProductoModel input)
        {
            input = _productoRepository.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = _productoRepository.EliminarRegistro(id);
            return id;
        }

        public List<ProductoModel> ListarTodo()
        {
            List<ProductoModel> lista = _productoRepository.ListarTodo();
            return lista;
        }

        public ProductoModel ObtenerPorId(int id)
        {
            ProductoModel resultado = _productoRepository.ObtenerPorID(id);
            return resultado;
        }
    }
}
