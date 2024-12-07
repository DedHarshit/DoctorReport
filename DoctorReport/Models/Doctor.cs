using System.ComponentModel.DataAnnotations;

namespace DoctorReport.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Specialist { get; set; }
    }
}
