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
        [ForeignKey("Good")]
        

        public List<int> Goods { get; set; } = new List<int>();

        public virtual User User { get; set; }
        public virtual List<Good> Good { get; set; }

    }
}
