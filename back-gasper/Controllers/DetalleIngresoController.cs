using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleIngresoController : ControllerBase
    {
        DetalleIngresoLogic _detalleingresologic = new DetalleIngresoLogic();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<DetalleIngresoModel> lista = new List<DetalleIngresoModel>();
            lista = _detalleingresologic.ListarTodo();
            return Ok(lista);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            DetalleIngresoModel lista = new DetalleIngresoModel();
            lista = _detalleingresologic.ObtenerPorId(id);
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult create(DetalleIngresoModel request)
        {
            DetalleIngresoModel resultado = _detalleingresologic.CrearRegistro(request);
            return Ok(resultado);
        }

        [HttpPut]
        public IActionResult update(DetalleIngresoModel request)
        {
            DetalleIngresoModel resultado = _detalleingresologic.ActualizarRegistro(request);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = _detalleingresologic.EliminarRegistro(id);
            return Ok(borrar);
        }
    }
}
