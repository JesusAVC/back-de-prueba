using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        MarcaLogic _marcalogic = new MarcaLogic();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<MarcaModel> lista = new List<MarcaModel>();
            lista = _marcalogic.ListarTodo();
            return Ok(lista);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            MarcaModel lista = new MarcaModel();
            lista = _marcalogic.ObtenerPorId(id);
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult create(MarcaModel request)
        {
            MarcaModel resultado = _marcalogic.CrearRegistro(request);
            return Ok(resultado);
        }

        [HttpPut]
        public IActionResult update(MarcaModel request)
        {
            MarcaModel resultado = _marcalogic.ActualizarRegistro(request);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int borrar = _marcalogic.EliminarRegistro(id);
            return Ok(borrar);
        }
    }
}
