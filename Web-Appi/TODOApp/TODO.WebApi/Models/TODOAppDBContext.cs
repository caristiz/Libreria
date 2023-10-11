using Microsoft.EntityFrameworkCore;
using TODO.WebApi.Models;

namespace TODO.WebApi.Models
{
    public class TODOAppDBContext : DbContext

    {
        public TODOAppDBContext(DbContextOptions<TODOAppDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TODO.WebApi.Models.Book> Books { get; set; } = default!;
        public DbSet<TODO.WebApi.Models.Reviews> Reviews { get; set; } = default!;
        
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().ToTable("TODOAppUsers");
        //    modelBuilder.Entity<TodoItem>().ToTable("TodoItems");
        //}

    }
}
