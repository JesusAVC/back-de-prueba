using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        VentaLogic ventalogico = new VentaLogic();

        [HttpGet]
        public IActionResult Get()
        {
            List<VentaModel> listaresultado = new List<VentaModel>();
            listaresultado = ventalogico.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            VentaModel resultado = new VentaModel();
            resultado = ventalogico.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(VentaModel request)
        {
            VentaModel response = ventalogico.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(VentaModel Request)
        {
            VentaModel resultado = ventalogico.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = ventalogico.EliminarRegistro(id);
            return Ok(borrar);
        }
    }
}
