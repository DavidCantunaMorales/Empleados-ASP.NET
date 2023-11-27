using Empleados.Data;
using Empleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empleados.Pages.Departamentos
{
    public class InsertarModel : PageModel
    {
		private readonly AppDbContext _context;

        public InsertarModel(AppDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Departamento Departamento { get; set; }

		public void OnGet()
        {
        }

		// Con esto guardamos el departamento
		public async Task<IActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				await _context.Departamento.AddAsync(Departamento);
				await _context.SaveChangesAsync();
				return RedirectToPage("Index");
			}
			else
			{
				return Page();
			}
		}
	}
}
