using CurdProject.Model;
using Microsoft.EntityFrameworkCore;

namespace CurdProject.Db
{
    public class ApplicationDbContext :DbContext//ctor tab
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
