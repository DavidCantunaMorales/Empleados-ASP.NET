using Empleados.Data;
using Empleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empleados.Pages.Departamentos
{
    public class EditarModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditarModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Departamento Departamento { get; set; }

        public async void OnGet(int id)
        {
            Departamento = await _context.Departamento.FindAsync(id);
        }

		public async Task<IActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				var DepartamentoDB = await _context.Departamento.FindAsync(Departamento.Id);
				DepartamentoDB.NombreDepartamento = Departamento.NombreDepartamento;
				DepartamentoDB.Descripcion = Departamento.Descripcion;
				DepartamentoDB.FechaCreacion = Departamento.FechaCreacion;

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
