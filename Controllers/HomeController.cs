using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using myPet;

namespace myPet2.Controllers
{
    public class HomeController : Controller
    {
        private readonly myPetContext _context;
        public HomeController(myPetContext context)
        {
            _context=context; 
        }

        
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Transactions.ToListAsync());
            ViewData["count"] = _context.Transactions.Count();
            return View();
        }

        public IActionResult TestView()
        {
            return View();
        }
    }
}