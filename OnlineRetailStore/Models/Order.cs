using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineRetailStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
        public int OrderQuantity { get; set; }
        public int OrderAmount { get; set; }
    }
}
