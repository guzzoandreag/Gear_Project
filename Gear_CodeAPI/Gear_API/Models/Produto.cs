using System.ComponentModel.DataAnnotations;

namespace Gear_API.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Categoria { get; set; }

        public double? Valor { get; set; }
    }
}
