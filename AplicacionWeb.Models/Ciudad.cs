using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class Ciudad : Entity
	{
		
		public string Nombre { get; set; }
		
		public int Departamentoid { get; set; }
		
		public virtual Departamento Departamento { get; set; }
		
		public virtual List<Cliente> Clientes { get; set; }
		
	}
}
