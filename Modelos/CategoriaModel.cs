﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class CategoriaModel
    {
        [Key]
        public int idcategoria { get; set; } = 0;

        [Required]
        [MaxLength(100)]
        public string nombre { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string descripcion { get; set; } = "";
    }
}
