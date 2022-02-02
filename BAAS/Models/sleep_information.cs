using System.ComponentModel.DataAnnotations;
namespace BAAS.Models
{
    public class sleep_information
    {
        [Key]
        public int sleep_id { get; set; } 
        public int? person { get; set; }
        public int? fitbit { get; set; }
        public string? creationdate { get; set; }
        public int? minutes_asleep { get; set; }
        public TimeSpan? start_time { get; set; }
        public TimeSpan? end_time { get; set; }
        public int? minutes_awake { get; set; }
        public int? number_of_awakenings { get; set; }
        public int? minutes_in_bed { get; set; }
       // public person Person { get; set; }

    }

}
