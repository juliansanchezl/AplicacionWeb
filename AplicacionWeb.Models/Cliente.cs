using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacionWeb.Models
{
	public class Cliente : Entity
	{
		
		[Required]
		public string Cedula { get; set; }
		
		[MaxLength(100)]
		public string Nombres { get; set; }
		
		public string Apellidos { get; set; }
		
		public DateTime Fechanacimiento { get; set; }
		
		public string Fotourl { get; set; }
		
		public bool Usuarioactivo { get; set; }
		
		public int Ciudadid { get; set; }
		
		public virtual Ciudad Ciudad { get; set; }
		
		public int Generoid { get; set; }
		
		public virtual Genero Genero { get; set; }
		
		public virtual List<Venta> Ventas { get; set; }
		
	}
}
