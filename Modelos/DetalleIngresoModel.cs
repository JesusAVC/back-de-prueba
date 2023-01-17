using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetalleIngresoModel
    {
        [Key]
        public int iddetalleingreso { get; set; } = 0;

        [MaxLength(4)]
        [Required]
        public int cantidad { get; set; } = 0;

        [MaxLength(9)]
        [Required]
        public double precio { get; set; } = 0;

        [MaxLength(4)]
        [Required]
        public bool estado { get; set; } = true;

        [MaxLength(4)]
        [Required]
        public int idingreso { get; set; } = 0;

        [MaxLength(4)]
        [Required]
        public int idproducto { get; set; } = 0;

       [ForeignKey("idingreso")]
       public virtual IngresoModel ingreso { get; set; }

        [ForeignKey("id_producto")]
        public virtual ProductoModel producto { get; set; }
    }
}
