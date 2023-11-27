using System.ComponentModel.DataAnnotations;

namespace Empleados.Models
{
	public class Departamento
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "El nombre del departamento es obligatorio")]
		[StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1}", MinimumLength = 2)]
		public string NombreDepartamento { get; set; }

		[DataType(DataType.MultilineText)]
		public string Descripcion { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Fecha de Creación")]
		public DateTime? FechaCreacion { get; set; }

	}
}
