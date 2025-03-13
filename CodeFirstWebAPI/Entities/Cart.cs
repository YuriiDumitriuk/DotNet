using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstWebAPI.Entities
{
    [PrimaryKey("Id")]
    public class Cart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Primary Key
        [ForeignKey("User")]
        public int UserId { get; set; }  // Foreign Key

        public List<CartGood> CartGoods { get; set; } = new();
        public virtual User User { get; set; }
        public virtual List<CartGood> Goods { get; set; } = new List<CartGood>();

    }
}
