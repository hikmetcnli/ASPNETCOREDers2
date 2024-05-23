
using CORECRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CORECRUD.Controllers
{
    public class PeopleController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var PeopleList = c.People_.Include(x=> x._Depart).ToList();
            return View(PeopleList);
        }

        [HttpGet]
        public IActionResult New()
        {
            var depList = c.Department_.ToList();

            return View();
        }
		[HttpPost]
		public IActionResult New(People people)
		{
			return View();
		}

	}
}
