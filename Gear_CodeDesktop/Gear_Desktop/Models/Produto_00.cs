using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gear_Desktop.Models
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
        public double Pro_Medida { get; set; }

        [Required]
        [DefaultValue(0)]
        public double Pro_Grupo { get; set; }
    }
}
