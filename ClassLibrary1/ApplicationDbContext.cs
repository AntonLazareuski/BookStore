using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=bookstore;Username=postgres;Password=postgres");
        }

    }
}