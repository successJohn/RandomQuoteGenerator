using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuoteGenerator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteGenerator.Controllers
{
    public class HomeController : Controller
    {
        List<Quote> QuoteList = new List<Quote>()
     {
         new Quote(){Id = 1, Author = "Gandhis", Quotes = "Live Foe what's worth dying for, and leverage technology to create the world you wish to see", Time = DateTime.Now},
         new Quote(){Id = 2, Author = "Albert Einstein", Quotes = "Everybody is a genius.But if you judge a fish by its ability to climb a tree. It will live its whole life beliving it is not", Time = DateTime.Now},
         new Quote(){Id = 3, Author = "success dara", Quotes = "I am me", Time = DateTime.Now},
     };

        public IActionResult Index(string author, string quotes, DateTime time)
        {
            var totalQuotes = QuoteList.OrderBy(q => q.Author);



            foreach(var x in totalQuotes)
            {
               author = x.Author;
                quotes = x.Quotes;
                time = x.Time;
            }

           
            return View(new Quote { Author = author, Quotes = quotes, Time = time } );
        }

       public ViewResult QuoteResponse()
        {
            return View();
        }

       

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
