using System.ComponentModel.DataAnnotations;
namespace BAAS.Models
{
    public class activity_information
    {
        [Key]
        public int? activity_id { get; set; }    
        public int? person { get; set; }
        public int? fitbit { get; set; }
        public string? creationdate { get; set; }
        public int? steps { get; set; }
        public int? calories_burned { get; set; }
        public int? minutes_sedentary { get; set; }
        public int? distance { get; set; }
        public int? floors { get; set; }
        public int? minutes_lightly_active { get; set; }
        public int? minutes_fairly_active { get; set; }
        public int? minutes_very_active { get; set; }
        public int? activity_calories { get; set; }
       // public person Person { get; set; }  

    }
}
    

    
    
