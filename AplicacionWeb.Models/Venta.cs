using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class Venta : Entity
	{
		
		public DateTime Fecha { get; set; }
		
		public int Clienteid { get; set; }
		
		public virtual Cliente Cliente { get; set; }
		
		public int Total { get; set; }
		
		public virtual List<VentaArticulos> Articulos { get; set; }
		
		public virtual List<RegistroPago> Pagos { get; set; }
		
	}
}
