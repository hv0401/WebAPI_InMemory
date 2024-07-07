using EFCoreInMemoryDbDemo.Models;
using Microsoft.EntityFrameworkCore;
namespace InmemoryDBApp
{
    public class DBContextAPI : DbContext
    {
        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
