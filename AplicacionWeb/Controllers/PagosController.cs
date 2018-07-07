using System.Web.Mvc;
using AplicacionWeb.Models;
using AplicacionWeb.DAL;
using AplicacionWeb.Services;

namespace AplicacionWeb.Controllers
{
	public class PagosController : Controller
	{
		private IPersistence<Venta> persistenceventa;
		private IPersistence<RegistroPago> persistenceregistropago;
		private IServicioPagos<RegistroPago> serviciopago;
		
		public PagosController(IPersistence<Venta> _persistenceventa, IPersistence<RegistroPago> _persistenceregistropago, IServicioPagos<RegistroPago> _serviciopago)
		{
			persistenceventa = _persistenceventa;
			persistenceregistropago = _persistenceregistropago;
			serviciopago = _serviciopago;
		}
		
		public ActionResult ConsultarRegistroPago()
		{
			return View(persistenceregistropago.FindAll()); 
		}
		
		public ActionResult EliminarPago(int id)
		{
			persistenceregistropago.Remove(id); 
			return RedirectToAction("ConsultarRegistroPago"); 
		}
		
		public ActionResult RegistrarPago(int idventa,int total)
		{
			Venta venta= persistenceventa.Find(idventa); 
			RegistroPago registropago= new RegistroPago(); 
			registropago.Ventaid = venta.Id; 
			registropago.Fecha = venta.Fecha; 
			registropago.Valor = total; 
			return View(registropago); 
		}
		
		[HttpPost]
		public ActionResult RegistrarPago(RegistroPago registropago)
		{
			string resultado= serviciopago.ObtenerDatosDatafono(registropago); 
			if(resultado != ""){
				registropago.Codigoaprobacion = resultado; 
				registropago.Estadotransaccion = "APROBADA"; 
			}
			else{
				registropago.Codigoaprobacion = "N/A"; 
				registropago.Estadotransaccion = "RECHAZADO"; 
			}
			persistenceregistropago.Create(registropago); 
			return RedirectToAction("ResultadoTransaccion", new { id = registropago.Id }); 
		}
		
		public ActionResult ResultadoTransaccion(int id)
		{
			return View(persistenceregistropago.Find(id)); 
		}
		
		public ActionResult RegresarAVenta(int ventaid)
		{
			return RedirectToAction("EditarVenta", "Venta", new { id = ventaid }); 
		}
		
		public ActionResult CrearNuevaVenta()
		{
			return RedirectToAction("CrearVenta", "Venta"); 
		}
		
		
	}
}
