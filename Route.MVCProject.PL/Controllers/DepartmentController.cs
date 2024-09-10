using Microsoft.AspNetCore.Mvc;
using Route.MVCProject.BLL.Interfaces;

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

        // "BaseUrl/Department/Index"
        public IActionResult Index()
        {
            // var Departments = _departmentRepo.
            return View();
        }
    }
}
