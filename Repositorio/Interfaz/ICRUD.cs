using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interfaz
{
    public interface ICRUD<T>
    {
        List<T> ListarTodo();
        T ObtenerPorID(int id);
        T CrearRegistro(T input);
        T ActualizarRegistro(T input);
        int EliminarRegistro(int id);

    }
}
