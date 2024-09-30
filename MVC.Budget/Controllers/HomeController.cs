using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Budget.Context;
using MVC.Budget.Models;
using System.Diagnostics;

namespace MVC.Budget.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BudgetContext _dbContext;
        //private List<Transaction> _transactions;

        public HomeController(ILogger<HomeController> logger, BudgetContext context)
        {
            _logger = logger;
            _dbContext = context;
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

            var transationList = _dbContext.Transactions.ToList();


            return transationList;
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
