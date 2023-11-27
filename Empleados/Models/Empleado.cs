using System.ComponentModel.DataAnnotations;

namespace Empleados.Models
{
	public class Empleado
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "El nombre del empleado es obligatorio")]
		[StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1}", MinimumLength = 2)]
		public string Nombre { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Fecha de Nacimiento")]
		public DateTime? FechaNacimiento { get; set; }

		[Required(ErrorMessage = "El email del es obligatorio")]
		[DataType(DataType.EmailAddress)]
		[EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido")]
		public string CorreoElectronico { get; set; }

		[Required(ErrorMessage = "El numero es obligatorio")]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"^\d{10}$", ErrorMessage = "El número de teléfono debe tener 10 dígitos")]
		public string Celular { get; set; }

		[Required(ErrorMessage = "La dirección del empleado es obligatoria")]
		[StringLength(100, ErrorMessage = "{0} la dirección debe tener entre {2} y {1}", MinimumLength = 5)]
		public string Direccion { get; set; }

		[Required]
		public int DepartamentoId { get; set; }
		public Departamento Departamento { get; set; }

	}
}
