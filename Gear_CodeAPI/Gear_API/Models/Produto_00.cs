using System.ComponentModel;
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
        [DefaultValue(0)]
        public double Pro_valorcusto { get; set; }

        [ForeignKey("Estoque_00")]
        public int Etq_codigo { get; set; }
        //public Estoque_00 Estoque_00 { get; set; }
    }
}
