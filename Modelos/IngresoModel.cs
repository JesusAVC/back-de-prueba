using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class IngresoModel
    {
        [Key]
        public int idingreso { get; set; } = 0;

        [MaxLength(40)]
        [Required]
        public string tipo_comprobante { get; set; } = "";

        [MaxLength(40)]
        [Required]
        public string serie_comprobante { get; set; } = "";

        [MaxLength(40)]
        [Required]
        public string num_comprobante { get; set; } = "";

        [Required]
        public DateTime fecha { get; set; }

        [MaxLength(9)]
        [Required]
        public decimal impuesto { get; set; }

        [MaxLength(9)]
        [Required]
        public decimal total { get; set; }

        [MaxLength(40)]
        [Required]
        public string estado { get; set; } = "";

        [MaxLength(4)]
        [Required]
        public int idproveedor { get; set; } = 0;

        [MaxLength(4)]
        [Required]
        public int idusuario { get; set; } = 0;

        [ForeignKey("idproveedor")]
        public virtual ProveedorModel proveedor { get; set; }

        [ForeignKey("idusuario")]
        public virtual UsuarioModel usuario { get; set; }


    }
}
