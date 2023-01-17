using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        ProductoLogic _productologic = new ProductoLogic();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ProductoModel> lista = new List<ProductoModel>();
            lista = _productologic.ListarTodo();
            return Ok(lista);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            ProductoModel lista = new ProductoModel();
            lista = _productologic.ObtenerPorId(id);
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult create(ProductoModel request)
        {
            ProductoModel resultado = _productologic.CrearRegistro(request);
            return Ok(resultado);
        }

        [HttpPut]
        public IActionResult update(ProductoModel request)
        {
            ProductoModel resultado = _productologic.ActualizarRegistro(request);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = _productologic.EliminarRegistro(id);
            return Ok(borrar);
        }
    }
}
