using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class PaisController : Controller
	{
		private IPersistence<Pais> persistence;
		
		public PaisController(IPersistence<Pais> _persistence)
		{
			persistence = _persistence;
		}
		
		public ActionResult ConsultarPais()
		{
			return View(persistence.FindAll()); 
		}
		
		public ActionResult CrearPais()
		{
			Pais pais= new Pais(); 
			return View(pais); 
		}
		
		[HttpPost]
		public ActionResult CrearPais(Pais pais)
		{
			persistence.Create(pais); 
			return RedirectToAction("ConsultarPais"); 
		}
		
		public ActionResult EliminarPais(int id)
		{
			return View(persistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarPais(Pais pais)
		{
			persistence.Remove(pais); 
			return RedirectToAction("ConsultarPais"); 
		}
		
		
	}
}
