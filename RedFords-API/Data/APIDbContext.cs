using Microsoft.EntityFrameworkCore;
using RedFords_API.Models;

namespace RedFords_API.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffType> StaffTypes { get; set; }
        public DbSet<Title> Titles { get; set; }

    }
}
