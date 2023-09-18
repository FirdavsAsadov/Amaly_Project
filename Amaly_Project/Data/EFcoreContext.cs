using Amaly_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Amaly_Project.Data
{
    public class EFcoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Server=localhost;Port=5433;UserName=postgres;Database=postgres;Password=fedya_2006");
        public DbSet<User> Users { get; set; }

    }
}
