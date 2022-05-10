using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gear_Desktop.Models
{
    public class Produto_00
    {
        [Key]
        public int Pro_code { get; set; }

        [Required]
        [StringLength(200)]
        public string Pro_name { get; set; }

        [Required]
        [DefaultValue(0)]
        public double Pro_value { get; set; }

        [ForeignKey("Estoque_00")]
        public int Etq_code { get; set; }
        //public Estoque_00 Estoque_00 { get; set; }
    }
}
