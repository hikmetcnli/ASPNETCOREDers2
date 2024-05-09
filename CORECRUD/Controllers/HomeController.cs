using CORECRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CORECRUD.Controllers
{
	public class HomeController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var DepList = c.Department_.ToList();
			return View(DepList);
		}

		[HttpGet]
		public IActionResult New()
		{
			return View();
		}

		[HttpPost]
		public IActionResult New(Department d)
		{
			c.Department_.Add(d);
			c.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult Delete(int ID)
		{

			var d = c.Department_.Find(ID);
			if (d != null)
			{
				c.Department_.Remove(d);
				c.SaveChanges();
			}

			return RedirectToAction("Index");
		}

	}
}
