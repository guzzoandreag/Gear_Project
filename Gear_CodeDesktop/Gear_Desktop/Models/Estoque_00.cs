﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Gear_Desktop.Models
{
    public class Estoque_00
    {
        [Key]
        public int Etq_codigo { get; set; }

        [ForeignKey("Produto_00")]
        public int Pro_codigo { get; set; }
        //public Produto_00 Produto_00 { get; set; }

        [ForeignKey("Deposito_00")]
        public int Dep_codigo { get; set; }
        //public Deposito_00 Deposito_00 { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 10)")]
        [DefaultValue(0)]
        public decimal Etq_quantidade { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 10)")]
        [DefaultValue(0)]
        public decimal Etq_valorcusto { get; set; }

        public DateTime? Etq_validade { get; set; }
    }
}
