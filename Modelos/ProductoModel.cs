using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ProductoModel
    {
        [Key]
        public int idproducto { get; set; } = 0;

        [MaxLength(100)]
        [Required]
        public string codigo { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string nombre { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string precio_venta { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string stock { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string descripcion { get; set; } = "";

        [Required]
        public int id_categoria { get; set; } = 0;

        [Required]
        public int id_marca { get; set; } = 0;

        [Required]
        public bool estado { get; set; } = true;

        [ForeignKey("id_categoria")]
        public virtual CategoriaModel categoria { get; set; }

        [ForeignKey("id_marca")]
        public virtual MarcaModel marca { get; set; }

    }
}
