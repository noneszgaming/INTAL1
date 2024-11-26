using Microsoft.EntityFrameworkCore;
using PlanningProject.Models;

namespace PlanningProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbTask> Tasks { get; set; }
        public DbSet<DbSprint> Sprints { get; set; }
    }
}
