using CodeFirstWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstWebAPI.DatabaseContext
{
    public class MyDBContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Good> Goods { get; set; }
    }
}
