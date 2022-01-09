using System.ComponentModel.DataAnnotations;

namespace OnlineRetailStore.Models
{
    public class Product
    {
        [Key]
        public int ItemId { get; set; }

        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public int ItemPrice { get; set; }
    }
}
