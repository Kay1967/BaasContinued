using System.ComponentModel.DataAnnotations;
namespace BAAS.Models
{
    public class exercise_information
    {
        [Key]
        public int? exercise_id { get; set; }   
        public int? person { get; set; }
        public int? fitbit { get; set; }
        public string? exercise_start_time { get; set; }
        public string? exercise_name { get; set; }
        public int? exercise_active_duration { get; set; }
        public int? exercise_average_heartrate { get; set; }
        public int? calories_burned { get; set; }
        public int? distance { get; set; }
        public int? exercise_overall_duration { get; set; }
        public decimal? exercise_pace { get; set; }
        public string? distance_unit { get; set; }
        //public person Person { get; set; }
    }
}
