using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DAVITCP\\SQLEXPRESS;Database=FinalProjectDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
