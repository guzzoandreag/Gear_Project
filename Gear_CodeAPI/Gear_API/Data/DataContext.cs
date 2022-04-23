using Microsoft.EntityFrameworkCore;
using Gear_API.Models;

namespace Gear_API.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=172.17.0.3,1433;Database=dbGear;User Id=sa;Password=Gear5038;");
        }

        public DbSet<User> Users { get; set; }
    }
}
