using Microsoft.AspNetCore.Mvc;

namespace MyCursovProject.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
