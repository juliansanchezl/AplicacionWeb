using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class ClienteController : Controller
	{
		private IPersistence<Cliente> clientepersistence;
		private IPersistence<Ciudad> ciudadpersitence;
		private IPersistence<Genero> generopersitence;
		
		public ClienteController(IPersistence<Cliente> _clientepersistence, IPersistence<Ciudad> _ciudadpersitence, IPersistence<Genero> _generopersitence)
		{
			clientepersistence = _clientepersistence;
			ciudadpersitence = _ciudadpersitence;
			generopersitence = _generopersitence;
		}
		
		public ActionResult ConsultarClientes()
		{
			return View(clientepersistence.FindAll()); 
		}
		
		public ActionResult CrearCliente()
		{
			Cliente cliente= new Cliente(); 
			var listaciudad = ciudadpersitence.FindAll(); 
			var listagenero = generopersitence.FindAll(); 
			ViewBag.listaciudad=listaciudad;ViewBag.listagenero=listagenero;
			return View(cliente); 
		}
		
		[HttpPost]
		public ActionResult CrearCliente(Cliente cliente)
		{
			clientepersistence.Create(cliente); 
			return RedirectToAction("ConsultarClientes"); 
		}
		
		public ActionResult EditarCliente(int id)
		{
			var listaciudad = ciudadpersitence.FindAll(); 
			var listagenero = generopersitence.FindAll(); 
			ViewBag.listaciudad=listaciudad;ViewBag.listagenero=listagenero;
			return View(clientepersistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EditarCliente(Cliente cliente)
		{
			if(clientepersistence.IsPersistent(cliente)){
				clientepersistence.Save(cliente); 
			}
			else{
				clientepersistence.Create(cliente); 
			}
			return RedirectToAction("ConsultarClientes"); 
		}
		
		public ActionResult EliminarCliente(int id)
		{
			return View(clientepersistence.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarCliente(Cliente cliente)
		{
			clientepersistence.Remove(cliente); 
			return RedirectToAction("ConsultarClientes"); 
		}
		
		
	}
}
