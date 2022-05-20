using System.ComponentModel.DataAnnotations;

namespace Gear_API.Models
{
    public class Users
    {
        [Key]
        public int Use_codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Use_nome { get; set; }

        [Required]
        [StringLength(30)]
        public string Use_email { get; set; }

        [Required]
        [StringLength(20)]
        public string Usu_senha { get; set; }
    }
}