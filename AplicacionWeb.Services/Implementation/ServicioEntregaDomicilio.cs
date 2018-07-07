using System;
using System.Collections.Generic;

namespace AplicacionWeb.Services
{
    /// <summary>
    /// This interface represents the local instance for the ServicioEntregaDomicilio
    /// </summary>
	public class ServicioEntregaDomicilio<RegistroPago>  : IServicioEntregaDomicilio<RegistroPago>
	{
		/// <summary>
		/// This method executes the proper actions for enviarPedido
		/// </summary>
		/// <param name="obj"></param>
		public string EnviarPedido(RegistroPago obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarEstadoPedido
		/// </summary>
		/// <param name="obj"></param>
		public string ConsultarEstadoPedido(RegistroPago obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for anularPedido
		/// </summary>
		/// <param name="id"></param>
		public string AnularPedido(string id)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarDisponibilidadMensajero
		/// </summary>
		/// <param name="obj"></param>
		public bool ConsultarDisponibilidadMensajero(RegistroPago obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarReportePedidos
		/// </summary>
		public List<RegistroPago> ConsultarReportePedidos()
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
	}
}
