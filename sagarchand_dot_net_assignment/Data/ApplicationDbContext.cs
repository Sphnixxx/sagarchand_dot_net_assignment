using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sagarchand_dot_net_assignment.Models;

namespace sagarchand_dot_net_assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<sagarchand_dot_net_assignment.Models.Studentinfo> Studentinfo { get; set; } = default!;
        public DbSet<sagarchand_dot_net_assignment.Models.ApplicationUser> ApplicationUser { get; set; } = default!;
        public DbSet<sagarchand_dot_net_assignment.Models.Event> Event { get; set; } = default!;
    }
}
