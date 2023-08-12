using Day2.Models;
using Day2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day2.Controllers
{
	public class StudentController : Controller
	{
		ApplicationDbContext Context = new ApplicationDbContext();
		public IActionResult getStudentResult(int id)
		{
			CrsResult StdModel = Context.CrsResults.Where(i=>i.ID == id).Include(s => s.Trainee).Include(s => s.Course).FirstOrDefault();
			
			StudentResult student = new StudentResult();

			student.ID = StdModel.ID;
			student.StudentName = StdModel.Trainee.Name;
			student.StudentCrs = StdModel.Course.Name;
			student.StudentDegree = StdModel.Degree;
			

			return View(student);
		}
	}
}
