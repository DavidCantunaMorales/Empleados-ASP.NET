using Empleados.Data;
using Empleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empleados.Pages.Departamentos
{
    public class EliminarModel : PageModel
    {
		private readonly AppDbContext _context;

		public EliminarModel(AppDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Departamento Departamento { get; set; }
		public async Task OnGet(int id)
		{
			Departamento = await _context.Departamento.FindAsync(id);
		}

		public async Task<IActionResult> OnPost()
		{

			var DepartamentoDB = await _context.Departamento.FindAsync(Departamento.Id);
			
			if (DepartamentoDB == null) {
				return NotFound();
			}

			_context.Departamento.Remove(DepartamentoDB);
			await _context.SaveChangesAsync();
			return RedirectToPage("Index");

		}
	}
}
