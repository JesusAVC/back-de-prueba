using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class VentaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idventa { get; set; } = 0;



        [Required]
        public DateTime hora { get; set; } 

        [MaxLength(20)]
        [Required]
        public string tipo_comprobante { get; set; } = "";

        [MaxLength(7)]
        [Required]
        public string serie_comprobante { get; set; } = "";

        [MaxLength(10)]
        [Required]
        public string num_comprobante { get; set; } = "";

        [Required]
        public DateTime fecha_hora { get; set; } 

        [Required]
        public decimal impuesto { get; set; } = 0;

        [Required]
        public decimal total { get; set; } = 0;

        [MaxLength(20)]
        [Required]
        public string estado { get; set; } = "";


        [MaxLength(4)]
        [Required]
        public int idcliente { get; set; } = 0;

        [MaxLength(4)]
        [Required]
        public int idusuario { get; set; } = 0;

        [ForeignKey("idcliente")]
        public virtual ClienteModel cliente { get; set; }

        [ForeignKey("idusuario")]
        public virtual UsuarioModel usuario { get; set; }
    }
}
