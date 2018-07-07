using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class HomeController : Controller
	{
		
		public HomeController()
		{
		}
		
		public ActionResult Index()
		{
			return View(); 
		}
		
		
	}
}
