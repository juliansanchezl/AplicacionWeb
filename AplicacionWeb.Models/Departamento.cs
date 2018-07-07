using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class Departamento : Entity
	{
		
		public string Nombre { get; set; }
		
		public int Paisid { get; set; }
		
		public virtual Pais Pais { get; set; }
		
		public virtual List<Ciudad> Ciudades { get; set; }
		
	}
}
