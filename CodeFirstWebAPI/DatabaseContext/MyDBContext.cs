using CodeFirstWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstWebAPI.DatabaseContext
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartGood>()
                .HasKey(cg => new { cg.CartId, cg.GoodId }); // Composite Key

            modelBuilder.Entity<CartGood>()
                .HasOne(cg => cg.Cart)
                .WithMany(c => c.CartGoods)
                .HasForeignKey(cg => cg.CartId);

            modelBuilder.Entity<CartGood>()
                .HasOne(cg => cg.Good)
                .WithMany(g => g.CartGoods)
                .HasForeignKey(cg => cg.GoodId);
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}
