using Microsoft.EntityFrameworkCore;
using Vesper.DAL;
using Vesper.Models;


namespace Vesper.DAL
{
    public class VesperDbContext:DbContext
    {
        public VesperDbContext(DbContextOptions<VesperDbContext> options) : base(options)
        {

        }

    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Service> Services { get; set; }


    }
}
