﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gear_API.Models
{
    public class Produto_00
    {
        [Key]
        public int Pro_codigo { get; set; }

        [Required]
        [StringLength(200)]
        public string Pro_nome { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 10)")]
        [DefaultValue(0)]
        public decimal Pro_valorcusto { get; set; }

        [Required]
        [DefaultValue(0)]
        public double Pro_Medida { get; set; }

        [Required]
        [DefaultValue(0)]
        public double Pro_Grupo { get; set; }
    }
}
