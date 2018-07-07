using System.Collections.Generic;

namespace AplicacionWeb.Services
{
    /// <summary>
    /// This interface represents the local instance for the ServicioPagos
    /// </summary>
	public interface IServicioPagos <RegistroPago>
	{
		/// <summary>
		/// This method executes the proper actions for obtenerDatosDatafono
		/// </summary>
		/// <param name="obj"></param>
		string ObtenerDatosDatafono(RegistroPago obj);
		
		/// <summary>
		/// This method executes the proper actions for anularTransaccion
		/// </summary>
		/// <param name="obj"></param>
		bool AnularTransaccion(RegistroPago obj);
		
		/// <summary>
		/// This method executes the proper actions for consultarTransaccion
		/// </summary>
		/// <param name="id"></param>
		RegistroPago ConsultarTransaccion(string id);
		
		/// <summary>
		/// This method executes the proper actions for consultarSaldoTarjeta
		/// </summary>
		/// <param name="obj"></param>
		long ConsultarSaldoTarjeta(RegistroPago obj);
		
		/// <summary>
		/// This method executes the proper actions for consultarReporteTransaccionesAprobadas
		/// </summary>
		List<RegistroPago> ConsultarReporteTransaccionesAprobadas();
		
		/// <summary>
		/// This method executes the proper actions for consultarReporteTransaccionesAnuladas
		/// </summary>
		List<RegistroPago> ConsultarReporteTransaccionesAnuladas();
		
		/// <summary>
		/// This method executes the proper actions for registrarPagoBonosDescuento
		/// </summary>
		/// <param name="obj"></param>
		string RegistrarPagoBonosDescuento(RegistroPago obj);
		
		/// <summary>
		/// This method executes the proper actions for redimirPuntosCompra
		/// </summary>
		/// <param name="obj"></param>
		string RedimirPuntosCompra(RegistroPago obj);
		
	}
}
