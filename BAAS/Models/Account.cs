using System.ComponentModel.DataAnnotations;
namespace BAAS.Models
{
    public class Account
    {
        
        public int Id { get; set; }

        public string Email { get; set; }
        
        public string? Name { get; set; }
        [Required]
        public string password { get; set; }

    }
}
