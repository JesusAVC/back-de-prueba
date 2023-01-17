using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.requestResponse
{
    public class LoginRequest
    {
        public string num_documento { get; set; }
        public string password { get; set; }
        public string identificador { get; set; } = "";
    }
}
