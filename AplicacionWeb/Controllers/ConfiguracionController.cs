using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class ConfiguracionController : Controller
	{
		
		public ConfiguracionController()
		{
		}
		
		public ActionResult ConsultarConfiguracion()
		{
			return View(); 
		}
		
		public ActionResult GestionarPais()
		{
			return RedirectToAction("ConsultarPais", "Pais"); 
		}
		
		public ActionResult GestionarDepartamento()
		{
			return RedirectToAction("ConsultarDepartamentos", "Departamento"); 
		}
		
		public ActionResult GestionarCiudad()
		{
			return RedirectToAction("ConsultarCiudades", "Ciudad"); 
		}
		
		public ActionResult GestionarGenero()
		{
			return RedirectToAction("ConsultarGenero", "Genero"); 
		}
		
		
	}
}
