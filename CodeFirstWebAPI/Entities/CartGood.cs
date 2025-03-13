using System.Text.Json.Serialization;

namespace CodeFirstWebAPI.Entities
{
    public class CartGood
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        [JsonIgnore]
        public Cart Cart { get; set; }

        public int GoodId { get; set; }
        public Good Good { get; set; }
    }
}
