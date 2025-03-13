using CodeFirstWebAPI.Entities;

namespace CodeFirstWebAPI.Services
{
    public interface ICartRepositoryService : IRepositoryService<Cart>
    {
        List<Cart> GetAllCartsByUserID(int userId);
    }
}
