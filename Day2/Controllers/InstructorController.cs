using Day2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day2.Controllers
{
    public class InstructorController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            List<Instructor> getAllInstructor = context.Instructors.Include(i=>i.Department).Include(i=>i.Course).ToList();
            return View("Index", getAllInstructor);
        }
        public IActionResult Details(int id)
        {
			Instructor getInstructor = context.Instructors.Where(i=>i.ID == id).Include(i => i.Department).Include(i => i.Course).FirstOrDefault();

            if(getInstructor == null)
            {
				return Content("NO Instructor Found");
            }
			return View(getInstructor);
        }

		public IActionResult Add()
		{
			List<Department> departments = context.Departments.ToList();
			List<Course> courses = context.Courses.ToList();

			ViewBag.dept = departments;
			ViewBag.crs = courses;
			return View();
		}
		[HttpPost]
		public IActionResult AddSave(Instructor INs)
		{
			if(ModelState.IsValid == true)
			{
				context.Instructors.Add(INs);
				context.SaveChanges();

				return RedirectToAction("Index");
			}
			List<Department> departments = context.Departments.ToList();
			List<Course> courses = context.Courses.ToList();

			ViewBag.dept = departments;
			ViewBag.crs = courses;
			return View("Add",INs);
		}

		public IActionResult Edit(int id)
		{
			List<Course> courses = context.Courses.ToList();
			List<Department> departments = context.Departments.ToList();

			ViewData["Crs"] = courses;
			ViewData["dept"] = departments;

			Instructor selectedInstructor = context.Instructors.FirstOrDefault(i => i.ID == id);
			return View(selectedInstructor);
		}

        [HttpPost]
		public IActionResult EditSave(int id, Instructor INs)
        {
			if(ModelState.IsValid)
			{
				Instructor selectedInstructor = context.Instructors.FirstOrDefault(i => i.ID == id);
				selectedInstructor.Name = INs.Name;
				selectedInstructor.Adress = INs.Adress;
				selectedInstructor.Salary = INs.Salary;
				selectedInstructor.Image = INs.Image;
				selectedInstructor.DeptID = INs.DeptID;
				selectedInstructor.CrsID = INs.CrsID;

				context.SaveChanges();

				return RedirectToAction("Index");
			}
			List<Course> courses = context.Courses.ToList();
			List<Department> departments = context.Departments.ToList();

			ViewData["Crs"] = courses;
			ViewData["dept"] = departments;

			return View("Edit",INs);
        }
		
		public IActionResult NameValidation(string Name, int id)
		{
			Instructor Ins = context.Instructors.FirstOrDefault(n => n.Name== Name);
			if(id == 0)
			{
				if (Ins == null)
					return Json(true);
				return Json(false);
			}
			else
			{
				if (Ins == null)
					return Json(true);
				else
				{
					if (Ins.ID == id)
						return Json(true);
					return Json(false);
				}
			}
		}

		public IActionResult GetInstructor(int deptId)
		{

			return View();
		}

	}
}
