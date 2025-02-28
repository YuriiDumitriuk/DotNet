using CodeFirstWebAPI.Entities;
using System.Security.Cryptography.X509Certificates;

namespace CodeFirstWebAPI.Services
{
    public class GoodService
    {
        private static List<Good> goods = new List<Good>
        {
            new Good { Id = 1, Name = "Apple" },
            new Good { Id = 2, Name = "Banana" }
        };

        public List<Good> GetAllGoods() => goods;
        public Good GetGoodById(int id) => goods.FirstOrDefault(g => g.Id == id);
        public Good GetGoodByName(string name)=> goods.FirstOrDefault(g => g.Name == name);
    }
}
