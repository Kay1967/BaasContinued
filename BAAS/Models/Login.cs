using System.ComponentModel.DataAnnotations;
namespace BAAS.Models
{
    public class Login
    {
        
        public string? Email { get; set; }
        [Required]
        public string? password { get; set; }
    }
}
