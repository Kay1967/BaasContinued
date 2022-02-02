using System.ComponentModel.DataAnnotations;
namespace BAAS.Models
{
    public class heartrate_daily
    {
        [Key]
        public int hrd_id { get; set; } 
        public int? person { get; set; }
        public int? fitbit { get; set; }
        public int? resting_heartrate { get; set; }
        public DateTime? timestamp { get; set; }
        public string? creationdate { get; set; }
        //public person Person { get; set; }


    }
}
