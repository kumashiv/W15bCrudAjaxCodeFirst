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
        public IActionResult GetEmployeeData()      //Get Employee View
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetData()  // Get Employee Data
        {
            var Emp = _db.Employees.ToList();

            return Json(Emp);
        }


        [HttpPost]
        public IActionResult DeleteEmployee(Employee obj)
        {
            var Emp = _db.Employees.FirstOrDefault(x => x.Id == obj.Id);
            _db.Employees.Remove(Emp);
            _db.SaveChanges();
            return RedirectToAction("GetData");
        }


        [HttpPost]
        public IActionResult UpdateEmployee(Employee obj)
        {
            //var employees = _db.Employees.FirstOrDefault(x => x.Id == obj.Id);
            _db.Employees.Update(obj);
            _db.SaveChanges();
            return Json(true);
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
