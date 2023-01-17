using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.requestResponse
{
    public class LoginResponse
    {
        public string token { get; set; }
        public UsuarioModel user { get; set; }
        public string refreshToken { get; set; }
    }
}
