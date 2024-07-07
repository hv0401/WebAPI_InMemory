using InmemoryDBApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InmemoryDBApp
{
    public class DbContextAPI : DbContext 
    {
        public DbContextAPI(DbContextOptions options) : base(options) { 
        
        }
        public DbSet<Book> Books { get; set; }
    }
}
