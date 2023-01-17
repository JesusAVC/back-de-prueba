using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class UsuarioModel
    {
        [Key]
        public int idusuario { get; set; }

        [MaxLength(100)]
        [Required]
        public string nombres { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string apellidos { get; set; } = "";

        [MaxLength(20)]
        [Required]
        public string tipo_documento { get; set; } = "";

        [MaxLength(20)]
        [Required]
        public string num_documento { get; set; } = "";

        [MaxLength(70)]
        [Required]
        public string direccion { get; set; } = "";

        [MaxLength(9)]
        [Required]
        public string celular { get; set; } = "";

        [MaxLength(50)]
        [Required]
        public string email { get; set; } = "";

        [MaxLength(20)]
        [Required]
        public string password { get; set; } = "";

        [Required]
        public bool estado { get; set; } = true;

        [Required]
        [MaxLength(4)]
        public int idrol { get; set; }

        [ForeignKey("idrol")]
        public virtual RolModel rol { get; set; } 
    }
}
