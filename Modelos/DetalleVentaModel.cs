using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleVentaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int iddetalle_venta { get; set; } = 0;

        [Required]
        public int cantidad { get; set; } = 0;

        [Required]
        public decimal precio { get; set; } = 0;

        [Required]
        public decimal descuento { get; set; } = 0;

        [MaxLength(4)]
        [Required]
        public int idventa { get; set; } = 0;

        [MaxLength(4)]
        [Required]
        public int idproducto { get; set; } = 0;

        [ForeignKey("idventa")]
        public virtual VentaModel venta { get; set; }

        [ForeignKey("idproducto")]
        public virtual ProductoModel producto { get; set; }
    }
}
