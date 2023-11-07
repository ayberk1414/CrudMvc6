using System.ComponentModel.DataAnnotations;

namespace CrudMvc6.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }

    }
}
