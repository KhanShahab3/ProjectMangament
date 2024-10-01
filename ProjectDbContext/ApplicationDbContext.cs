using Microsoft.EntityFrameworkCore;
using ProjectMangament.Model;

namespace ProjectMangament.ProjectDbContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Users> Users { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ProjectTeam> ProjectTeam { get; set; }
        public DbSet<TaskAssignees> TaskAssignees { get; set; }
        public DbSet<Tasks> Task { get; set; }
        public DbSet<Teams> Teams { get; set; }
    }
}
