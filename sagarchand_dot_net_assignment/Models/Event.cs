using System;
using System.ComponentModel.DataAnnotations;

namespace sagarchand_dot_net_assignment.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Event Date is required")]
        public DateTime EventDate { get; set; }

        public string Location { get; set; }

        public string Organizer { get; set; }
    }
}
