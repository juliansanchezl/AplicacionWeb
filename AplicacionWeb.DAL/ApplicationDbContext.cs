using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using AplicacionWeb.Models;

namespace AplicacionWeb.DAL
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Ciudad> Ciudad { get; set; }
		public DbSet<Genero> Genero { get; set; }
		public DbSet<Cliente> Cliente { get; set; }
		public DbSet<Departamento> Departamento { get; set; }
		public DbSet<Pais> Pais { get; set; }
		public DbSet<RegistroPago> RegistroPago { get; set; }
		public DbSet<Producto> Producto { get; set; }
		public DbSet<Tipo_Producto> Tipo_Producto { get; set; }
		public DbSet<Venta> Venta { get; set; }
		public DbSet<VentaArticulos> VentaArticulos { get; set; }
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Entity<Ciudad>().ToTable("Ciudad");
			modelBuilder.Entity<Genero>().ToTable("Genero");
			modelBuilder.Entity<Cliente>().ToTable("Cliente");
			modelBuilder.Entity<Departamento>().ToTable("Departamento");
			modelBuilder.Entity<Pais>().ToTable("Pais");
			modelBuilder.Entity<RegistroPago>().ToTable("RegistroPago");
			modelBuilder.Entity<Producto>().ToTable("Producto");
			modelBuilder.Entity<Tipo_Producto>().ToTable("Tipo_Producto");
			modelBuilder.Entity<Venta>().ToTable("Venta");
			modelBuilder.Entity<VentaArticulos>().ToTable("VentaArticulos");
			
			//Fluent API relationships
			//ManyToOne
			modelBuilder.Entity<Ciudad>()
			.HasRequired<Departamento>(p => p.Departamento); 
			
			//OneToMany mappedBy "Ciudad"
			modelBuilder.Entity<Ciudad>()
			.HasMany<Cliente>(p => p.Clientes)
			.WithRequired(p => p.Ciudad)
			.HasForeignKey<int>(p => p.Ciudadid)
			.WillCascadeOnDelete(false);
			
			//OneToMany mappedBy "Genero"
			modelBuilder.Entity<Genero>()
			.HasMany<Cliente>(p => p.Clientesgenero)
			.WithRequired(p => p.Genero)
			.HasForeignKey<int>(p => p.Generoid)
			.WillCascadeOnDelete(false);
			
			//ManyToOne
			modelBuilder.Entity<Cliente>()
			.HasRequired<Ciudad>(p => p.Ciudad); 
			
			//ManyToOne
			modelBuilder.Entity<Cliente>()
			.HasRequired<Genero>(p => p.Genero); 
			
			//OneToMany mappedBy "Cliente"
			modelBuilder.Entity<Cliente>()
			.HasMany<Venta>(p => p.Ventas)
			.WithRequired(p => p.Cliente)
			.HasForeignKey<int>(p => p.Clienteid)
			.WillCascadeOnDelete(false);
			
			//ManyToOne
			modelBuilder.Entity<Departamento>()
			.HasRequired<Pais>(p => p.Pais); 
			
			//OneToMany mappedBy "Departamento"
			modelBuilder.Entity<Departamento>()
			.HasMany<Ciudad>(p => p.Ciudades)
			.WithRequired(p => p.Departamento)
			.HasForeignKey<int>(p => p.Departamentoid)
			.WillCascadeOnDelete(false);
			
			//OneToMany mappedBy "Pais"
			modelBuilder.Entity<Pais>()
			.HasMany<Departamento>(p => p.Departamentos)
			.WithRequired(p => p.Pais)
			.HasForeignKey<int>(p => p.Paisid)
			.WillCascadeOnDelete(false);
			
			//ManyToOne
			modelBuilder.Entity<RegistroPago>()
			.HasRequired<Venta>(p => p.Venta); 
			
			//ManyToOne
			modelBuilder.Entity<Producto>()
			.HasRequired<Tipo_Producto>(p => p.Tipo_producto); 
			
			//OneToMany mappedBy "Producto"
			modelBuilder.Entity<Producto>()
			.HasMany<VentaArticulos>(p => p.Ventaarticulos)
			.WithRequired(p => p.Producto)
			.HasForeignKey<int>(p => p.Productoid)
			.WillCascadeOnDelete(false);
			
			//OneToMany mappedBy "Tipo_producto"
			modelBuilder.Entity<Tipo_Producto>()
			.HasMany<Producto>(p => p.Productos)
			.WithRequired(p => p.Tipo_producto)
			.HasForeignKey<int>(p => p.Tipo_productoid)
			.WillCascadeOnDelete(false);
			
			//ManyToOne
			modelBuilder.Entity<Venta>()
			.HasRequired<Cliente>(p => p.Cliente); 
			
			//OneToMany mappedBy "Venta"
			modelBuilder.Entity<Venta>()
			.HasMany<VentaArticulos>(p => p.Articulos)
			.WithRequired(p => p.Venta)
			.HasForeignKey<int>(p => p.Ventaid)
			.WillCascadeOnDelete(false);
			
			//OneToMany mappedBy "Venta"
			modelBuilder.Entity<Venta>()
			.HasMany<RegistroPago>(p => p.Pagos)
			.WithRequired(p => p.Venta)
			.HasForeignKey<int>(p => p.Ventaid)
			.WillCascadeOnDelete(false);
			
			//ManyToOne
			modelBuilder.Entity<VentaArticulos>()
			.HasRequired<Venta>(p => p.Venta); 
			
			//ManyToOne
			modelBuilder.Entity<VentaArticulos>()
			.HasRequired<Producto>(p => p.Producto); 
			
			
		}
	}
}
