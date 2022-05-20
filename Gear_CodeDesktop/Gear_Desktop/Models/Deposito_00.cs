using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gear_Desktop.Models
{
    public class Deposito_00
    {
        [Key]
        public int Dep_codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Dep_nome { get; set; }

        [Required]
        public int Dep_tipocadastro { get; set; }

        public int? Dep_tipoplantio { get; set; }

        [StringLength(10)]
        public string? Dep_tamanhofazenda { get; set; }
    }
}
