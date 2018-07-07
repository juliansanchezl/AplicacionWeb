using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class Pais : Entity
	{
		
		public string Nombre { get; set; }
		
		public virtual List<Departamento> Departamentos { get; set; }
		
	}
}
