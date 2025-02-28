using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstWebAPI.Entities
{
        [PrimaryKey("Id")]
        public class User
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }  // Primary Key
            public string Name { get; set; }
        
        }
}
