using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Index()
		{
			List<Student> std = StudentList.Students;
			return View(std);
		}

        public IActionResult Details(int id)
        {
            Student std = StudentList.Students.FirstOrDefault(s => s.ID == id);
            return View(std);
        }
    }
}
