using System.ComponentModel.DataAnnotations;
namespace BAAS.Models
{
    public class heartrate_information
    {
        [Key]
        public int hri_id { get; set; }
        public int? person { get; set; }
        public int? fitbit { get; set; }
        public string? creationdate { get; set; }
        public int? average_resting_heartrate { get; set; }
       // public person Person { get; set; }
    }
}
