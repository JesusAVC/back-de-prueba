using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ClienteModel
    {
        [Key]
        public int idcliente { get; set; } = 0;

        [Required]
        [MaxLength(40)]
        public string tipo_cliente { get; set; } = "";

        [Required]
        [MaxLength(200)]
        public string nombres { get; set; } = "";

        [Required]
        [MaxLength(40)]
        public string tipo_documento { get; set; } = "";

        [Required]
        [MaxLength(40)]
        public string num_documento { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string direccion { get; set; } = "";

        [Required]
        [MaxLength(9)]
        public string celular { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string email { get; set; } = "";

    }
}
