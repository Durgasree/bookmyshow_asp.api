using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace bookmyshow_api.Models
{
    public class BookmyshowContext : DbContext
    {
        public BookmyshowContext(DbContextOptions<BookmyshowContext> options)
            : base(options)
        {
        }

        public DbSet<Theatre> Theatres { get; set; } = null!;
    }
}
