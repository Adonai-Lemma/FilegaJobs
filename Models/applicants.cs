using System.ComponentModel.DataAnnotations;

namespace FilegaJobs.Models
{
    public class applicants
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int profileID { get; set; }
        [Required]
        public int jobID { get; set; }

    }
}
