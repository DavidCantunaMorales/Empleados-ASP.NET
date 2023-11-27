using Empleados.Data;
using Empleados.Models;
using Empleados.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Pages.DEmpleados
{
    public class EditarModel : PageModel
    {
		private readonly AppDbContext _context;

		public EditarModel(AppDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public CrearEmpleadoVM EmpleadoVm { get; set; }
		public async Task<IActionResult> OnGet(int id)
		{
			EmpleadoVm = new CrearEmpleadoVM()
			{
				ListaDepartamentos = await _context.Departamento.ToListAsync(),
				Empleado = await _context.Empleado.FindAsync(id),
			};
			return Page();
		}

		// Con esto editamos el empleado
		public async Task<IActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				var EmpleadoDB = await _context.Empleado.FindAsync(EmpleadoVm.Empleado.Id);
				EmpleadoDB.Nombre = EmpleadoVm.Empleado.Nombre;
				EmpleadoDB.FechaNacimiento = EmpleadoVm.Empleado.FechaNacimiento;
				EmpleadoDB.CorreoElectronico = EmpleadoVm.Empleado.CorreoElectronico;
				EmpleadoDB.Celular = EmpleadoVm.Empleado.Celular;
				EmpleadoDB.Direccion = EmpleadoVm.Empleado.Direccion;
				EmpleadoDB.DepartamentoId = EmpleadoVm.Empleado.DepartamentoId;

				await _context.SaveChangesAsync();
				return RedirectToPage("Index");
			}
			else
			{
				return RedirectToPage();
			}
		}
	}
}
