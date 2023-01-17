using Logica.Interfaz;
using Modelos;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioLogic : ICRUDLO<UsuarioModel>
    {
        UsuarioRepository repo = new UsuarioRepository();
        public UsuarioModel ActualizarRegistro(UsuarioModel input)
        {
            input = repo.ActualizarRegistro(input);
            return input;
        }

        public UsuarioModel CrearRegistro(UsuarioModel input)
        {
            input = repo.CrearRegistro(input);
            return input;
        }

        public int EliminarRegistro(int id)
        {
            id = repo.EliminarRegistro(id);
            return id;
        }

        public List<UsuarioModel> ListarTodo()
        {
            List<UsuarioModel> lista = repo.ListarTodo();
            return lista;
        }

        public UsuarioModel ObtenerPorId(int id)
        {
            UsuarioModel resultado = repo.ObtenerPorID(id);
            return resultado;
        }
        public UsuarioModel ObtenerUsuarioPorUserrName(string numusuario)
        {
            // sintaxis lambda
            UsuarioModel user = repo.ObtenerUsuarioPorUserrName(numusuario);
            return user;
        }
    }
}
