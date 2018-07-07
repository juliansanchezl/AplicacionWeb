using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class Tipo_ProductoController : Controller
	{
		private IPersistence<Tipo_Producto> persistence;
		
		public Tipo_ProductoController(IPersistence<Tipo_Producto> _persistence)
		{
			persistence = _persistence;
		}
		
		public ActionResult ConsultarTipo_Producto()
		{
			return View(persistence.FindAll()); 
		}
		
		public ActionResult CrearTipo_Producto()
		{
			Tipo_Producto tipo_producto= new Tipo_Producto(); 
			return View(tipo_producto); 
		}
		
		[HttpPost]
		public ActionResult CrearTipo_Producto(Tipo_Producto tipo_producto)
		{
			persistence.Create(tipo_producto); 
			return RedirectToAction("ConsultarTipo_Producto"); 
		}
		
		public ActionResult EliminarTipo_Producto(int id)
		{
			return View(persistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarTipo_Producto(Tipo_Producto tipo_producto)
		{
			persistence.Remove(tipo_producto); 
			return RedirectToAction("ConsultarTipo_Producto"); 
		}
		
		public ActionResult EditarTipo_Producto(int id)
		{
			return View(persistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EditarTipo_Producto(Tipo_Producto tipo_producto)
		{
			if(persistence.IsPersistent(tipo_producto)){
				persistence.Save(tipo_producto); 
			}
			else{
				persistence.Create(tipo_producto); 
			}
			return RedirectToAction("ConsultarTipo_Producto"); 
		}
		
		
	}
}
