using System.Collections.Generic;

namespace AplicacionWeb.Services
{
    /// <summary>
    /// This interface represents the local instance for the ServicioEntregaDomicilio
    /// </summary>
	public interface IServicioEntregaDomicilio <RegistroPago>
	{
		/// <summary>
		/// This method executes the proper actions for enviarPedido
		/// </summary>
		/// <param name="obj"></param>
		string EnviarPedido(RegistroPago obj);
		
		/// <summary>
		/// This method executes the proper actions for consultarEstadoPedido
		/// </summary>
		/// <param name="obj"></param>
		string ConsultarEstadoPedido(RegistroPago obj);
		
		/// <summary>
		/// This method executes the proper actions for anularPedido
		/// </summary>
		/// <param name="id"></param>
		string AnularPedido(string id);
		
		/// <summary>
		/// This method executes the proper actions for consultarDisponibilidadMensajero
		/// </summary>
		/// <param name="obj"></param>
		bool ConsultarDisponibilidadMensajero(RegistroPago obj);
		
		/// <summary>
		/// This method executes the proper actions for consultarReportePedidos
		/// </summary>
		List<RegistroPago> ConsultarReportePedidos();
		
	}
}
