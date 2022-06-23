using _22._06._2022_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _22._06._2022_MVC.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Book> Genres { get; set; }
        public DbSet<Book> BookGenres { get; set; }


    }
}
