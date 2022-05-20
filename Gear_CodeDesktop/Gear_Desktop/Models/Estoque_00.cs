using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Gear_Desktop.Models
{
    public class Estoque_00
    {
        [Key]
        public int Etq_codigo { get; set; }

        [Required]
        [DefaultValue(0)]
        public string Etq_quantidade { get; set; }

        public DateTime? Etq_validade { get; set; }

        [ForeignKey("Deposito_00")]
        public int Dep_codigo { get; set; }
        //public Deposito_00 Deposito_00 { get; set; }
    }
}
