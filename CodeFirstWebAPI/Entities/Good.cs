
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodeFirstWebAPI.Entities
{

    [PrimaryKey("Id")]
    public class Good
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Primary Key
        public string Name { get; set; }

        public virtual List<CartGood> CartGoods { get; set; } = new List<CartGood>();
    }
}
