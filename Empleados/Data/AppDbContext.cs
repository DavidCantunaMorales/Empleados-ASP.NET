using Empleados.Models;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		// Instanciado los Modelos
		public DbSet<Departamento> Departamento { get; set; }
		public DbSet<Empleado> Empleado { get; set; }
	}	
}
