using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class Tipo_Producto : Entity
	{
		
		[Required]
		public string Nombre { get; set; }
		
		public string Descripcion { get; set; }
		
		public virtual List<Producto> Productos { get; set; }
		
	}
}
