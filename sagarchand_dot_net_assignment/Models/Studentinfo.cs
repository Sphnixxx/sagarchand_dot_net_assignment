using System.ComponentModel.DataAnnotations;

namespace sagarchand_dot_net_assignment.Models
{
    public class Studentinfo
    {
        // Primary key for the entity
        [Key]
        public int Id { get; set; }

        // Name of the student
        [Required]
        public string Name { get; set; }

        // Name of the college the student graduated from
        [Required]
        public string CollegeName { get; set; }

        // Year of graduation
        [Required]
        public string GraduationYear { get; set; }

        // Job title of the student after graduation
        [Required]
        public string JobTitle { get; set; }

        // Email of the student
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
