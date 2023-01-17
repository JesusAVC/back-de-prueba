using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleVentaController : ControllerBase
    {
        DetalleVentaLogic detalleventalogico = new DetalleVentaLogic();

        [HttpGet]
        public IActionResult Get()
        {
            List<DetalleVentaModel> listaresultado = new List<DetalleVentaModel>();
            listaresultado = detalleventalogico.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            DetalleVentaModel resultado = new DetalleVentaModel();
            resultado = detalleventalogico.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(DetalleVentaModel request)
        {
            DetalleVentaModel response = detalleventalogico.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(DetalleVentaModel Request)
        {
            DetalleVentaModel resultado = detalleventalogico.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = detalleventalogico.EliminarRegistro(id);
            return Ok(borrar);
        }
    }
}
