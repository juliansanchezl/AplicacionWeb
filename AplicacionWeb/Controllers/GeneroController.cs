using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class GeneroController : Controller
	{
		private IPersistence<Genero> persistence;
		
		public GeneroController(IPersistence<Genero> _persistence)
		{
			persistence = _persistence;
		}
		
		public ActionResult ConsultarGenero()
		{
			return View(persistence.FindAll()); 
		}
		
		public ActionResult CrearGenero()
		{
			Genero genero= new Genero(); 
			return View(genero); 
		}
		
		[HttpPost]
		public ActionResult CrearGenero(Genero genero)
		{
			persistence.Create(genero); 
			return RedirectToAction("ConsultarGenero"); 
		}
		
		public ActionResult EliminarGenero(int id)
		{
			return View(persistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarGenero(Genero genero)
		{
			persistence.Remove(genero); 
			return RedirectToAction("ConsultarGenero"); 
		}
		
		public ActionResult EditarGenero(int id)
		{
			return View(persistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EditarGenero(Genero genero)
		{
			if(persistence.IsPersistent(genero)){
				persistence.Save(genero); 
			}
			else{
				persistence.Create(genero); 
			}
			return RedirectToAction("ConsultarGenero"); 
		}
		
		
	}
}
