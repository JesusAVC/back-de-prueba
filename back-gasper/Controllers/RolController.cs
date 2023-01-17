using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        RolLogic rollogico = new RolLogic();

        [HttpGet]
        public IActionResult Get()
        {
            List<RolModel> listaresultado = new List<RolModel>();
            listaresultado = rollogico.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            RolModel resultado = new RolModel();
            resultado = rollogico.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(RolModel request)
        {
            RolModel response = rollogico.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(RolModel Request)
        {
            RolModel resultado = rollogico.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = rollogico.EliminarRegistro(id);
            return Ok(borrar);
        }
    }
}
