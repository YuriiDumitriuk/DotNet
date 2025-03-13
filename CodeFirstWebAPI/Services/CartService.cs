using CodeFirstWebAPI.Entities;
using Microsoft.Identity.Client;

namespace CodeFirstWebAPI.Services;

public interface ICartService
{
    List<Cart> GetAllCartsByUserId(int id);
}
public class CartService : ICartService
{
    private readonly ICartRepositoryService cartRepository;

    public CartService(ICartRepositoryService cartRepository)
    {
        this.cartRepository = cartRepository;
    }

    
    public List<Cart> GetAllCartsByUserId(int id) => cartRepository.GetAllCartsByUserID(id);         


}
