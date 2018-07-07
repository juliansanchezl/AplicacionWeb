using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class ProductoController : Controller
	{
		private IPersistence<Producto> productopersistence;
		private IPersistence<Tipo_Producto> tipoproductopersistence;
		
		public ProductoController(IPersistence<Producto> _productopersistence, IPersistence<Tipo_Producto> _tipoproductopersistence)
		{
			productopersistence = _productopersistence;
			tipoproductopersistence = _tipoproductopersistence;
		}
		
		public ActionResult ConsultarProducto()
		{
			return View(productopersistence.FindAll()); 
		}
		
		public ActionResult CrearProducto()
		{
			Producto producto= new Producto(); 
			var listatipoproducto = tipoproductopersistence.FindAll(); 
			ViewBag.listatipoproducto=listatipoproducto;
			return View(producto); 
		}
		
		[HttpPost]
		public ActionResult CrearProducto(Producto producto)
		{
			productopersistence.Create(producto); 
			return RedirectToAction("ConsultarProducto"); 
		}
		
		public ActionResult EliminarProducto(int id)
		{
			return View(productopersistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarProducto(Producto producto)
		{
			productopersistence.Remove(producto); 
			return RedirectToAction("ConsultarProducto"); 
		}
		
		public ActionResult EditarProducto(int id)
		{
			var listatipoproducto = tipoproductopersistence.FindAll(); 
			ViewBag.listatipoproducto=listatipoproducto;
			return View(productopersistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EditarProducto(Producto producto)
		{
			if(productopersistence.IsPersistent(producto)){
				productopersistence.Save(producto); 
			}
			else{
				productopersistence.Create(producto); 
			}
			return RedirectToAction("ConsultarProducto"); 
		}
		
		
	}
}
