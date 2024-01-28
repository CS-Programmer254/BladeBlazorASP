using BladeBlazorASP.Models;
using Microsoft.EntityFrameworkCore;

namespace BladeBlazorASP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        public DbSet<EmailSubscribers> EmailSubscribers{ get; set; }
        public DbSet<Project> Projects{ get; set; }
        public DbSet<Admin> Admins{ get; set; }


    }
}
