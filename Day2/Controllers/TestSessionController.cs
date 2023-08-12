using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
	public class TestSessionController : Controller
	{
		//public IActionResult set()
		//{
		//	TempData["name"] = "ganna";
		//	return Content("session crested");
		//}
		//public IActionResult get1()
		//{
		//	string name = TempData["name"].ToString();
			
		//	return Content($"get1 called and tempdata = {name}");
		//}
		//public IActionResult get2()
		//{
		//	string name = TempData["name"].ToString();

		//	return Content($"get2 called and tempdata = {name}");
		//}

		public IActionResult setState()
		{
			string name = "ganna";
			HttpContext.Session.SetString("name", name);
			return Content("session created");
		}

		public IActionResult getState()
		{
			string Name = HttpContext.Session.GetString("name");
			return Content($"get called set and name = {Name}");
		}
	}
}
