using System.ComponentModel.DataAnnotations;

namespace FilegaJobs.Models
{
    public class Jobs
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int salary { get; set; }


    }
}
