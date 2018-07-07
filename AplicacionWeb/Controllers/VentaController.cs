using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class VentaController : Controller
	{
		private IPersistence<Venta> persistenceventa;
		private IPersistence<Cliente> persistencecliente;
		private IPersistence<Producto> persistenceproducto;
		private IPersistence<VentaArticulos> persistenceventaarticulo;
		private IPersistence<RegistroPago> persistenceregistropago;
		
		public VentaController(IPersistence<Venta> _persistenceventa, IPersistence<Cliente> _persistencecliente, IPersistence<Producto> _persistenceproducto, IPersistence<VentaArticulos> _persistenceventaarticulo, IPersistence<RegistroPago> _persistenceregistropago)
		{
			persistenceventa = _persistenceventa;
			persistencecliente = _persistencecliente;
			persistenceproducto = _persistenceproducto;
			persistenceventaarticulo = _persistenceventaarticulo;
			persistenceregistropago = _persistenceregistropago;
		}
		
		public ActionResult ConsultarVenta()
		{
			var lista = persistenceventa.FindAll(); 
			foreach(var venta in lista)
			{
				foreach(var vetaarticulo in venta.Articulos)
				{
					venta.Total = venta.Total + vetaarticulo.Total; 
				}
			}
			return View(lista); 
		}
		
		public ActionResult CrearVenta()
		{
			Venta venta= new Venta(); 
			var listaclientes = persistencecliente.FindAll(); 
			foreach(var cliente in listaclientes)
			{
				cliente.Nombres = cliente.Nombres + " " + cliente.Apellidos; 
			}
			ViewBag.listaclientes=listaclientes;
			return View(venta); 
		}
		
		[HttpPost]
		public ActionResult CrearVenta(Venta venta)
		{
			persistenceventa.Create(venta); 
			return RedirectToAction("ConsultarVenta"); 
		}
		
		public ActionResult EliminarVenta(int id)
		{
			return View(persistenceventa.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarVenta(Venta venta)
		{
			Venta ventaart= persistenceventa.Find(venta.Id); 
			foreach(var art in ventaart.Articulos)
			{
				persistenceventaarticulo.Remove(art.Id); 
			}
			foreach(var item in ventaart.Pagos)
			{
				persistenceregistropago.Remove(item.Id); 
			}
			persistenceventa.Remove(venta); 
			return RedirectToAction("ConsultarVenta"); 
		}
		
		public ActionResult EditarVenta(int id)
		{
			Venta venta= persistenceventa.Find(id); 
			Cliente cliente= persistencecliente.Find(venta.Clienteid); 
			string nombrecliente=cliente.Nombres + " " + cliente.Apellidos; 
			int total=0; 
			foreach(var ventart in venta.Articulos)
			{
				total = total + ventart.Total; 
			}
			ViewBag.nombrecliente=nombrecliente;ViewBag.total=total;
			return View(venta); 
		}
		
		[HttpPost]
		public ActionResult EditarVenta(Venta venta)
		{
			Venta infoventa= persistenceventa.Find(venta.Id); 
			foreach(var ventart in infoventa.Articulos)
			{
				venta.Total = venta.Total + ventart.Total; 
			}
			return RedirectToAction("RegistrarPago", "Pagos", new { idventa = venta.Id,total = venta.Total }); 
		}
		
		public ActionResult EliminarVentaArticulo(int id)
		{
			return View(persistenceventaarticulo.Find(id)); 
		}
		
		[HttpPost]
		public ActionResult EliminarVentaArticulo(VentaArticulos ventaarticulos)
		{
			VentaArticulos ventaart= persistenceventaarticulo.Find(ventaarticulos.Id); 
			int ventaid= ventaart.Ventaid; 
			persistenceventaarticulo.Remove(ventaarticulos); 
			return RedirectToAction("EditarVenta", new { id = ventaid }); 
		}
		
		public ActionResult SeleccionarVentaArticulo(int id)
		{
			var listaproductos = persistenceproducto.FindAll(); 
			ViewBag.listaproductos=listaproductos;
			return View(persistenceventa.Find(id)); 
		}
		
		public ActionResult CrearVentaArticulo(int ventaid,int productoid)
		{
			Producto producto= persistenceproducto.Find(productoid); 
			VentaArticulos ventaarticulo= new VentaArticulos(); 
			ventaarticulo.Ventaid = ventaid; 
			ventaarticulo.Productoid = productoid; 
			ventaarticulo.Cantidad = 1; 
			ViewBag.producto=producto;
			return View(ventaarticulo); 
		}
		
		[HttpPost]
		public ActionResult CrearVentaArticulo(VentaArticulos ventaarticulo)
		{
			Producto prod= persistenceproducto.Find(ventaarticulo.Productoid); 
			ventaarticulo.Total = ventaarticulo.Cantidad * prod.Precio; 
			persistenceventaarticulo.Create(ventaarticulo); 
			return RedirectToAction("EditarVenta", new { id = ventaarticulo.Ventaid }); 
		}
		
		
	}
}
