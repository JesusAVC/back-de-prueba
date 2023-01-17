using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoController : ControllerBase
    {
        IngresoLogic _ingresologic = new IngresoLogic();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<IngresoModel> lista = new List<IngresoModel>();
            lista = _ingresologic.ListarTodo();
            return Ok(lista);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            IngresoModel lista = new IngresoModel();
            lista = _ingresologic.ObtenerPorId(id);
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult create(IngresoModel request)
        {
            IngresoModel resultado = _ingresologic.CrearRegistro(request);
            return Ok(resultado);
        }

        [HttpPut]
        public IActionResult update(IngresoModel request)
        {
            IngresoModel resultado = _ingresologic.ActualizarRegistro(request);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = _ingresologic.EliminarRegistro(id);
            return Ok(borrar);

        }
    }
}
