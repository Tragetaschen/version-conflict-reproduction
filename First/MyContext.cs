using Microsoft.EntityFrameworkCore;

namespace First
{
    public class MyContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; } = null!;
    }
}
