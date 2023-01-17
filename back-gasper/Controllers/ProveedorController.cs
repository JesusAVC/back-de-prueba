using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos;
using System.Net;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        ProveedorLogic _proveedorlogic = new ProveedorLogic();

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ProveedorModel> lista= new List<ProveedorModel>();
            lista = _proveedorlogic.ListarTodo();
            return Ok(lista);
        }
        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            ProveedorModel lista = new ProveedorModel();
            lista = _proveedorlogic.ObtenerPorId(id);
            return Ok(lista);
        }

        [HttpPost]
        public IActionResult create(ProveedorModel request) 
        {
            ProveedorModel resultado = _proveedorlogic.CrearRegistro(request);
            return Ok(resultado);
        }

        [HttpPut]
        public IActionResult update(ProveedorModel request)
        {
            ProveedorModel resultado = _proveedorlogic.ActualizarRegistro(request);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {         
                int borrar = _proveedorlogic.EliminarRegistro(id);
                return Ok(borrar);
                  
        }

    }
}
