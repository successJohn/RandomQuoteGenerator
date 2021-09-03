using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteGenerator.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Quotes { get; set; }
        public string Author { get; set; }

        public DateTime Time { get; set; }
    }
}
