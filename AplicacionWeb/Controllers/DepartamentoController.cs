using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class DepartamentoController : Controller
	{
		private IPersistence<Departamento> persistencedepartamento;
		private IPersistence<Pais> persistencepais;
		
		public DepartamentoController(IPersistence<Departamento> _persistencedepartamento, IPersistence<Pais> _persistencepais)
		{
			persistencedepartamento = _persistencedepartamento;
			persistencepais = _persistencepais;
		}
		
		public ActionResult ConsultarDepartamentos()
		{
			return View(persistencedepartamento.FindAll()); 
		}
		
		public ActionResult CrearDepartamento()
		{
			Departamento departamento= new Departamento(); 
			var listapais = persistencepais.FindAll(); 
			ViewBag.listapais=listapais;
			return View(departamento); 
		}
		
		[HttpPost]
		public ActionResult CrearDepartamento(Departamento departamento)
		{
			persistencedepartamento.Create(departamento); 
			return RedirectToAction("ConsultarDepartamentos"); 
		}
		
		public ActionResult EditarDepartamento(int id)
		{
			var listapais = persistencepais.FindAll(); 
			ViewBag.listapais=listapais;
			return View(persistencedepartamento.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EditarDepartamento(Departamento departamento)
		{
			if(persistencedepartamento.IsPersistent(departamento)){
				persistencedepartamento.Save(departamento); 
			}
			else{
				persistencedepartamento.Create(departamento); 
			}
			return RedirectToAction("ConsultarDepartamentos"); 
		}
		
		public ActionResult EliminarDepartamento(int id)
		{
			return View(persistencedepartamento.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarDepartamento(Departamento departamento)
		{
			persistencedepartamento.Remove(departamento); 
			return RedirectToAction("ConsultarDepartamentos"); 
		}
		
		
	}
}
