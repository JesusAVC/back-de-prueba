using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaz
{
    public interface ICRUDLO<T>
    {

        List<T> ListarTodo();

        T ObtenerPorId(int id);

        T CrearRegistro(T input);

        T ActualizarRegistro(T input);

        int EliminarRegistro(int id);
    }
}
