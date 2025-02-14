using System.ComponentModel.DataAnnotations;

namespace sagarchand_dot_net_assignment.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }

        public string GraduationYear { get; set; }

        public string AlumniStatus { get; set; }  // Example: "Active", "Inactive"

        public string Role { get; set; }
    }
}
