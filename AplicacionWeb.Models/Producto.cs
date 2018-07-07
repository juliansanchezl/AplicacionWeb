using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class Producto : Entity
	{
		
		[Required]
		public string Nombre { get; set; }
		
		public string Descripcion { get; set; }
		
		public string Sitioweb { get; set; }
		
		public string Fotourl { get; set; }
		
		public string Videourl { get; set; }
		
		public int Tipo_productoid { get; set; }
		
		public virtual Tipo_Producto Tipo_producto { get; set; }
		
		public int Precio { get; set; }
		
		public virtual List<VentaArticulos> Ventaarticulos { get; set; }
		
	}
}
