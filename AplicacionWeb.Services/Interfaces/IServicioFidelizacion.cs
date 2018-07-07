using System.Collections.Generic;

namespace AplicacionWeb.Services
{
    /// <summary>
    /// This interface represents the local instance for the ServicioFidelizacion
    /// </summary>
	public interface IServicioFidelizacion <Cliente>
	{
		/// <summary>
		/// This method executes the proper actions for inscribirCliente
		/// </summary>
		/// <param name="obj"></param>
		string InscribirCliente(Cliente obj);
		
		/// <summary>
		/// This method executes the proper actions for generarNotificacionCliente
		/// </summary>
		/// <param name="obj"></param>
		bool GenerarNotificacionCliente(Cliente obj);
		
		/// <summary>
		/// This method executes the proper actions for eliminarCliente
		/// </summary>
		/// <param name="id"></param>
		bool EliminarCliente(string id);
		
		/// <summary>
		/// This method executes the proper actions for consultarPuntosDisponibles
		/// </summary>
		/// <param name="obj"></param>
		string ConsultarPuntosDisponibles(Cliente obj);
		
		/// <summary>
		/// This method executes the proper actions for consultarReporteClientesInscritos
		/// </summary>
		List<Cliente> ConsultarReporteClientesInscritos();
		
		/// <summary>
		/// This method executes the proper actions for imprimirCarnetCliente
		/// </summary>
		string ImprimirCarnetCliente();
		
		/// <summary>
		/// This method executes the proper actions for actualizarDatosCliente
		/// </summary>
		/// <param name="obj"></param>
		bool ActualizarDatosCliente(Cliente obj);
		
		/// <summary>
		/// This method executes the proper actions for validarCarnetCliente
		/// </summary>
		/// <param name="obj"></param>
		bool ValidarCarnetCliente(Cliente obj);
		
		/// <summary>
		/// This method executes the proper actions for enviarMailCliente
		/// </summary>
		/// <param name="obj"></param>
		bool EnviarMailCliente(string obj);
		
	}
}
