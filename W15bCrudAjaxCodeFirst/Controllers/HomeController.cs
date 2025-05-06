using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using W15bCrudAjaxCodeFirst.AppDbContext;
using W15bCrudAjaxCodeFirst.Models;

namespace W15bCrudAjaxCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _db;

        public HomeController(ILogger<HomeController> logger, DataContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _db.Employees.Add(obj);     
            _db.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult GetEmployeeData()
        {
            var Emp = _db.Employees.ToList();
            return View(Emp);

            //return Json(Emp);
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
