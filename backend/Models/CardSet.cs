using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class CardSet
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int NumberOfCards { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }

        // Navigation property
        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }

}