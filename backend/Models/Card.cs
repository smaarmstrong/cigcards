using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int? CardSetId { get; set; } // Nullable to allow cards not associated with any set
        public string Title { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
    }

}