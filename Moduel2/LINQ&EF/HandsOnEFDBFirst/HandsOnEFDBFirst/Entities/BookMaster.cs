using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFDBFirst.Entities
{
    public partial class BookMaster
    {
        public decimal BookCode { get; set; }
        public string BookName { get; set; }
        public int? PubYear { get; set; }
        public string Author { get; set; }
        public string BookCategory { get; set; }
    }
}
