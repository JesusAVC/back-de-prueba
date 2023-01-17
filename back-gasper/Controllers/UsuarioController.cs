using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        UsuarioLogic usuariologico = new UsuarioLogic();

        [HttpGet]
        public IActionResult Get()
        {
            List<UsuarioModel> listaresultado = new List<UsuarioModel>();
            listaresultado = usuariologico.ListarTodo();
            return Ok(listaresultado);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            UsuarioModel resultado = new UsuarioModel();
            resultado = usuariologico.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public IActionResult Post(UsuarioModel request)
        {
            UsuarioModel response = usuariologico.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(UsuarioModel Request)
        {
            UsuarioModel resultado = usuariologico.ActualizarRegistro(Request);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = usuariologico.EliminarRegistro(id);
            return Ok(borrar);
        }
    }
}
