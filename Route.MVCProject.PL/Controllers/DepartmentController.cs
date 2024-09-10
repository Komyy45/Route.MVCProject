using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Route.MVCProject.BLL.Interfaces;
using Route.MVCProject.DAL.Models;

namespace Route.MVCProject.PL.Controllers
{
    // Inheritance: DepartmentController is a Controller
    // Composition: DepartmentController has an object from class Implementing IDepartmentRepository
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository departmentRepo;

        public DepartmentController(IDepartmentRepository _departmentRepo) // ASK CLR For an object Implementing IDepartmentReopsitory Interafce
        {
            departmentRepo = _departmentRepo;
        }

        [HttpGet]// "BaseUrl/Department/Index"
        public IActionResult Index()
        {
            var Departments = departmentRepo.GetAll();
            return View(Departments);
        }

        [HttpGet] // GET : "BaseUrl/Department/Create"
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // POST : "BaseUrl/Department/Create"
        public IActionResult Create(Department departament)
        {
            if(ModelState.IsValid)
            {
               var count = departmentRepo.Add(departament);

                if(count > 0)
               return RedirectToAction(nameof(Index));
            }
            return View(departament);
        }
    }
}
