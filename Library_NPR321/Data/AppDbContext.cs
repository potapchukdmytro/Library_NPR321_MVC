using Microsoft.EntityFrameworkCore;

namespace Library_NPR321.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }
    }
}
