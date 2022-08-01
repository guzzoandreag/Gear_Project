using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gear_Desktop.Models
{
    public class Despesa_00
    {
        [Key]
        public int Des_codigo { get; set; }

        public DateTime? Des_datalancamento { get; set; }
        
        [ForeignKey("Deposito_00")]
        public int Dep_codigo { get; set; }
        //public Deposito_00 Deposito_00 { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 10)")]
        [DefaultValue(0)]
        public decimal Des_valor { get; set; }

        [Required]
        public string Des_observacao { get; set; }
    }
}
