using DeliveBoo.DB;
using DeliveBoo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace DeliveBoo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private BookContext db;

        public HomeController(ILogger<HomeController> logger,BookContext database)
        {
            _logger = logger;
            db = database;
        }

        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                using(db)
                {
                    List<Book> books = db.Books.ToList();
                    return View(books);
                }
            }
            else
            {
                
                return Redirect("Identity/Account/Login");
            }
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