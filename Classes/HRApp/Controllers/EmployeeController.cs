using HRApp.Enums;
using HRApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HrDbContext hrDb;

        public EmployeeController(HrDbContext hrDb)
        {
            this.hrDb = hrDb;
        }
        
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}