using System.ComponentModel.DataAnnotations;
namespace BAAS.Models

{
    public class person
    {
        
        [Key]
        public int person_id { get; set; }
        public string? gender { get; set; }
        public int? age { get; set; }
        public int? height { get; set; }
        public int? weight { get; set; }
        public string? firstname { get; set; }
        public int person1 { get; set; }
        public int? fitbit { get; set; }
        public string? client_id { get; set; }
        public string? client_secret { get; set; }
        /*public List<activity_information>? activity_information { get; set; }  
        public List<exercise_information>? exercise_information { get; set; }  
        public List<heartrate_information>? heartrate_information { get; set; }    
        public List<heartrate_daily>? heartrate_daily { get; set; }
        public List<sleep_information>? sleep_information { get; set; }   */
        
    }
    [MetadataType(typeof(person))]
    public partial class CheckId
    {
        //[Compare("person_id")]
        public int? Check_Id { get; set; }
    }

}
