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
         new Quote(){Id = 1, Author = "Gandhis", Quotes = "Live For what's worth dying for, and leverage technology to create the world you wish to see"},
         new Quote(){Id = 2, Author = "Albert Einstein", Quotes = "Everybody is a genius.But if you judge a fish by its ability to climb a tree. It will live its whole life beliving it is not"},
         new Quote(){Id = 3, Author = " C. JoyBell C.", Quotes = "“I'm unpredictable, I never know where I'm going until I get there, I'm so random, I'm always growing, learning, changing, I'm never the same person twice. But one thing you can be sure of about me; is I will always do exactly what I want to do.”"},
         new Quote(){Id = 3, Author = " C. JoyBell C.", Quotes = "That proves you are unusual, returned the Scarecrow; and I am convinced that the only people worthy of consideration in this world are the unusual ones. For the common folks are like the leaves of a tree, and live and die unnoticed."},
     };

        public IActionResult Index(string author, string quotes, DateTime time)
        {
            var totalQuotes = QuoteList.OrderBy(q => q.Author);



            foreach(var x in totalQuotes)
            {
               author = x.Author;
                quotes = x.Quotes;
                
            }

           
            return View(new Quote { Author = author, Quotes = quotes } );
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
