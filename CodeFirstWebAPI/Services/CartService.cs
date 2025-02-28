using CodeFirstWebAPI.Entities;

namespace CodeFirstWebAPI.Services
{
    public class CartService
    {
        private static List<Cart> carts = new List<Cart>
        {
            new Cart { Id = 1,UserId=1,Goods=new List<int>{1}},
            new Cart { Id = 2,UserId=2,Goods=new List<int>{1}},
            new Cart { Id = 3,UserId=1,Goods=new List<int>{1,2}},
            new Cart { Id = 4,UserId=2,Goods=new List <int> { 1, 2 }},
        };
    public List<Cart> GetAllCartsByUserId(int id) => carts.FindAll(c => c.UserId == id);
    }
}
