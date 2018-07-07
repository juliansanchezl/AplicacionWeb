using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class RegistroPago : Entity
	{
		
		public DateTime Fecha { get; set; }
		
		public string Estadotransaccion { get; set; }
		
		public string Codigoaprobacion { get; set; }
		
		public int Valor { get; set; }
		
		public virtual Venta Venta { get; set; }
		
		public int Ventaid { get; set; }
		
	}
}
