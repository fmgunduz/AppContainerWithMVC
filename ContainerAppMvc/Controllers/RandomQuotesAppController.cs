using ContainerAppMvc.DataAccess;
using ContainerAppMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContainerAppMvc.Controllers
{
    public class RandomQuotesAppController : Controller
    {
        private readonly IQuotesDal _quotesDal;
        public RandomQuotesAppController(IQuotesDal quotesDal)
        {
            _quotesDal = quotesDal;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IEnumerable<QuoteModel> GetAllQuotes()
        {
            var quotes = _quotesDal.GetAllQuotesAsync().Result;
            return quotes;
        }
        public QuoteModel GetRandomQuote()
        {
            var quotes = GetAllQuotes();
            var quoteCount = quotes.Count();
            Random random = new();

            return quotes.ElementAt(random.Next(0, quoteCount));
        }

    }
}
