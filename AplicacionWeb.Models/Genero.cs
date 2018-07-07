using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class Genero : Entity
	{
		
		[Required]
		public string Nombre { get; set; }
		
		public virtual List<Cliente> Clientesgenero { get; set; }
		
	}
}
