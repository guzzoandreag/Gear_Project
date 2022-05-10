using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Gear_API.Models
{
    public class Estoque_00
    {
        [Key]
        public int Etq_code { get; set; }

        [Required]
        [DefaultValue(0)]
        public string Etq_quantity { get; set; }

        [ForeignKey("Deposito_00")]
        public int Dep_code { get; set; }
        //public Deposito_00 Deposito_00 { get; set; }
    }
}
