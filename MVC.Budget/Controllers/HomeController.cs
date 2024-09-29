using Microsoft.AspNetCore.Mvc;
using MVC.Budget.Models;
using System.Diagnostics;

namespace MVC.Budget.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private List<Transaction> _transactions;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            //_transactions = new List<Transaction>
            //{
            //    new Transaction
            //    {
            //        Id = 1,
            //        Name = "Test",
            //        Category = null,
            //        Amount = 1.1,
            //        Date = DateTime.Now
            //    }
            //};
        }

        public IActionResult Index()
        {
            
            var transactions = GetData();

            return View(transactions);
        }

        public List<Transaction> GetData()
        {
            



            return new List<Transaction>();
        }

        public IActionResult Privacy()
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
