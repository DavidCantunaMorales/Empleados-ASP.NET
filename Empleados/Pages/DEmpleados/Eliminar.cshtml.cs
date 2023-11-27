using Empleados.Data;
using Empleados.Models;
using Empleados.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Pages.DEmpleados
{
    public class EliminarModel : PageModel
    {
		private readonly AppDbContext _context;

		public EliminarModel(AppDbContext context)
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

		public async Task<IActionResult> OnPost()
		{

			var EmpleadoDB = await _context.Empleado.FindAsync(EmpleadoVm.Empleado.Id);

			if (EmpleadoDB == null)
			{
				return NotFound();
			}

			_context.Empleado.Remove(EmpleadoDB);
			await _context.SaveChangesAsync();
			return RedirectToPage("Index");

		}
	}
}
