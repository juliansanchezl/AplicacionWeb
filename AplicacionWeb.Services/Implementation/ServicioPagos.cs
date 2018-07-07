using System;
using System.Collections.Generic;

namespace AplicacionWeb.Services
{
    /// <summary>
    /// This interface represents the local instance for the ServicioPagos
    /// </summary>
	public class ServicioPagos<RegistroPago>  : IServicioPagos<RegistroPago>
	{
		/// <summary>
		/// This method executes the proper actions for obtenerDatosDatafono
		/// </summary>
		/// <param name="obj"></param>
		public string ObtenerDatosDatafono(RegistroPago obj)
		{
            // Implementation code goes here.
            return Guid.NewGuid().ToString().ToUpper();
        }
		
		/// <summary>
		/// This method executes the proper actions for anularTransaccion
		/// </summary>
		/// <param name="obj"></param>
		public bool AnularTransaccion(RegistroPago obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarTransaccion
		/// </summary>
		/// <param name="id"></param>
		public RegistroPago ConsultarTransaccion(string id)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarSaldoTarjeta
		/// </summary>
		/// <param name="obj"></param>
		public long ConsultarSaldoTarjeta(RegistroPago obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarReporteTransaccionesAprobadas
		/// </summary>
		public List<RegistroPago> ConsultarReporteTransaccionesAprobadas()
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarReporteTransaccionesAnuladas
		/// </summary>
		public List<RegistroPago> ConsultarReporteTransaccionesAnuladas()
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for registrarPagoBonosDescuento
		/// </summary>
		/// <param name="obj"></param>
		public string RegistrarPagoBonosDescuento(RegistroPago obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for redimirPuntosCompra
		/// </summary>
		/// <param name="obj"></param>
		public string RedimirPuntosCompra(RegistroPago obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
	}
}
