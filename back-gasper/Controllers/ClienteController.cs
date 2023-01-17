using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        ClienteLogic _clienteLogic = new ClienteLogic();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            lista = _clienteLogic.ListarTodo();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            ClienteModel lista = new ClienteModel();
            lista = _clienteLogic.ObtenerPorId(id);
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult create(ClienteModel request)
        {
            ClienteModel resultado = _clienteLogic.CrearRegistro(request);
            return Ok(resultado);
        }

        [HttpPut]
        public IActionResult update(ClienteModel request)
        {
            ClienteModel resultado = _clienteLogic.ActualizarRegistro(request);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = _clienteLogic.EliminarRegistro(id);
            return Ok(borrar);

        }

    }
}
