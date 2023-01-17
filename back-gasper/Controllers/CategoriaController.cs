using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        CategoriaLogic _categorialogic = new CategoriaLogic();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<CategoriaModel> lista = new List<CategoriaModel>();
            lista = _categorialogic.ListarTodo();
            return Ok(lista);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            CategoriaModel lista = new CategoriaModel();
            lista = _categorialogic.ObtenerPorId(id);
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult create(CategoriaModel request)
        {
            CategoriaModel resultado = _categorialogic.CrearRegistro(request);
            return Ok(resultado);
        }

        [HttpPut]
        public IActionResult update(CategoriaModel request)
        {
            CategoriaModel resultado = _categorialogic.ActualizarRegistro(request);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = _categorialogic.EliminarRegistro(id);
            return Ok(borrar);
        }
    }
}
