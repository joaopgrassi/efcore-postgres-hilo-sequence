using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the Hilo Sequence separately for each entity
            modelBuilder.Entity<Book>()
                .Property(x => x.Id)
                .ForNpgsqlUseSequenceHiLo($"Sequence-{nameof(Book)}");

            modelBuilder.Entity<Category>()
                .Property(x => x.Id)
                .ForNpgsqlUseSequenceHiLo($"Sequence-{nameof(Category)}");
        }
    }
}
