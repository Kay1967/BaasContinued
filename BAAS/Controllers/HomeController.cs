using BAAS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BAAS.Data;


namespace BAAS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        //public HomeController(ILogger<HomeController> logger)
        // {
        // _logger = logger;
        //}    
        public HomeController(ApplicationDbContext context)
        {

            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(Login login)
        {
            var account = _context.Accounts.FirstOrDefault(n => n.Email == login.Email);
            if (account == null)
            {
                return BadRequest();
            }
            if (account.password == login.password)
            {
                return RedirectToAction("Index", "person", account.Id);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return base.View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}