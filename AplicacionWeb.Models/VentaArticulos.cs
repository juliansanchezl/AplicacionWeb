using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class VentaArticulos : Entity
	{
		
		public int Ventaid { get; set; }
		
		public virtual Venta Venta { get; set; }
		
		public int Productoid { get; set; }
		
		public virtual Producto Producto { get; set; }
		
		public int Cantidad { get; set; }
		
		public int Total { get; set; }
		
	}
}
