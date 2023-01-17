using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ProveedorModel
    {
        [Key]
        public int idproveedor { get; set; } = 0;

        [MaxLength(11)]
        [Required]
        public string ruc { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string nombre { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string representante { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string direccion { get; set; } = "";

        [MaxLength(9)]
        [Required]
        public string celular { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string email { get; set; } = "";
    }
}
