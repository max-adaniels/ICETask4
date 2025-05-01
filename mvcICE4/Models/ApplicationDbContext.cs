using Microsoft.EntityFrameworkCore;

namespace mvcICE4.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<PetInformation> PetInformation { get; set; }
    }
}
