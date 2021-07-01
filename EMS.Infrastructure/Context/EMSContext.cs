using EMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure.Context
{
    public class EMSContext : DbContext
    {
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("DataSource=EMS.db");
    }
}
