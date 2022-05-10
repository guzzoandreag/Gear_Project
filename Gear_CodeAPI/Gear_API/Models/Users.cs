using System.ComponentModel.DataAnnotations;

namespace Gear_API.Models
{
    public class Users
    {
        [Key]
        public int Use_code { get; set; }

        [Required]
        [StringLength(100)]
        public string Use_name { get; set; }

        [Required]
        [StringLength(30)]
        public string Use_email { get; set; }

        [Required]
        [StringLength(20)]
        public string Usu_password { get; set; }
    }
}