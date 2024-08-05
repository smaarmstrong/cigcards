using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? CardSetId { get; set; } // Nullable to allow for individual card orders
        public int? CardId { get; set; } // Nullable to allow for card set orders
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

}