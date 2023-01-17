using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class RolModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idrol { get; set; } = 0;


        [MaxLength(30)]
        [Required]
        public string nombre { get; set; } = "";

        [MaxLength(100)]
        [Required]
        public string descripcion { get; set; } = "";
    }
}
