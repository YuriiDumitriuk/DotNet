using CodeFirstWebAPI.DatabaseContext;
using CodeFirstWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstWebAPI.Services
{
    public class CartRepositoryService : RepositoryService<Cart>, ICartRepositoryService
    {
        private readonly MyDBContext context;
        private readonly DbSet<Cart> dbSet;
        
        public CartRepositoryService(MyDBContext context) : base(context)
        {
            this.context = context;
            this.dbSet = context.Set<Cart>();

        }

        public List<Cart> GetAllCartsByUserID(int userId)
        {
            return dbSet
                .Where(cart => cart.UserId == userId)
                .Include(cart => cart.CartGoods)
                .ThenInclude(cartGood => cartGood.Good)
                .ToList();
        }
    }
}
