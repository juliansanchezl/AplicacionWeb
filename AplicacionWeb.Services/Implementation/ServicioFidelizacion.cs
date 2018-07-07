using System;
using System.Collections.Generic;

namespace AplicacionWeb.Services
{
    /// <summary>
    /// This interface represents the local instance for the ServicioFidelizacion
    /// </summary>
	public class ServicioFidelizacion<Cliente>  : IServicioFidelizacion<Cliente>
	{
		/// <summary>
		/// This method executes the proper actions for inscribirCliente
		/// </summary>
		/// <param name="obj"></param>
		public string InscribirCliente(Cliente obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for generarNotificacionCliente
		/// </summary>
		/// <param name="obj"></param>
		public bool GenerarNotificacionCliente(Cliente obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for eliminarCliente
		/// </summary>
		/// <param name="id"></param>
		public bool EliminarCliente(string id)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarPuntosDisponibles
		/// </summary>
		/// <param name="obj"></param>
		public string ConsultarPuntosDisponibles(Cliente obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for consultarReporteClientesInscritos
		/// </summary>
		public List<Cliente> ConsultarReporteClientesInscritos()
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for imprimirCarnetCliente
		/// </summary>
		public string ImprimirCarnetCliente()
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for actualizarDatosCliente
		/// </summary>
		/// <param name="obj"></param>
		public bool ActualizarDatosCliente(Cliente obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for validarCarnetCliente
		/// </summary>
		/// <param name="obj"></param>
		public bool ValidarCarnetCliente(Cliente obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// This method executes the proper actions for enviarMailCliente
		/// </summary>
		/// <param name="obj"></param>
		public bool EnviarMailCliente(string obj)
		{
			// Implementation code goes here.
			throw new NotImplementedException();
		}
		
	}
}
