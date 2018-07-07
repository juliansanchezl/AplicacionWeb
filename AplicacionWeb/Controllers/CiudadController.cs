using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class CiudadController : Controller
	{
		private IPersistence<Ciudad> persistenceciudad;
		private IPersistence<Departamento> persistencedepartamento;
		
		public CiudadController(IPersistence<Ciudad> _persistenceciudad, IPersistence<Departamento> _persistencedepartamento)
		{
			persistenceciudad = _persistenceciudad;
			persistencedepartamento = _persistencedepartamento;
		}
		
		public ActionResult ConsultarCiudades()
		{
			return View(persistenceciudad.FindAll()); 
		}
		
		public ActionResult CrearCiudad()
		{
			Ciudad ciudad= new Ciudad(); 
			var listadepartamento = persistencedepartamento.FindAll(); 
			ViewBag.listadepartamento=listadepartamento;
			return View(ciudad); 
		}
		
		[HttpPost]
		public ActionResult CrearCiudad(Ciudad ciudad)
		{
			persistenceciudad.Create(ciudad); 
			return RedirectToAction("ConsultarCiudades"); 
		}
		
		public ActionResult EditarCiudad(int id)
		{
			var listadepartamento = persistencedepartamento.FindAll(); 
			ViewBag.listadepartamento=listadepartamento;
			return View(persistenceciudad.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EditarCiudad(Ciudad ciudad)
		{
			if(persistenceciudad.IsPersistent(ciudad)){
				persistenceciudad.Save(ciudad); 
			}
			else{
				persistenceciudad.Create(ciudad); 
			}
			return RedirectToAction("ConsultarCiudades"); 
		}
		
		public ActionResult EliminarCiudad(int id)
		{
			return View(persistenceciudad.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarCiudad(Ciudad ciudad)
		{
			persistenceciudad.Remove(ciudad); 
			return RedirectToAction("ConsultarCiudades"); 
		}
		
		
	}
}
