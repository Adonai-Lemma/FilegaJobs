using System.ComponentModel.DataAnnotations;

namespace FilegaJobs.Models
{
    public class UserProfiles
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string resume { get; set; }

    }
}
