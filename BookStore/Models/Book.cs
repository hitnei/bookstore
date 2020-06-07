using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? DiscountedPrice { get; set; }
    }
}
