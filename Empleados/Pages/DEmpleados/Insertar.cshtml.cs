using Empleados.Data;
using Empleados.Models;
using Empleados.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Pages.DEmpleados
{
    public class InsertarModel : PageModel
    {
        private readonly AppDbContext _context;

        public InsertarModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CrearEmpleadoVM EmpleadoVm { get; set; }
        public async Task<IActionResult> OnGet()
        {
            EmpleadoVm = new CrearEmpleadoVM()
            {
                ListaDepartamentos = await _context.Departamento.ToListAsync(),
                Empleado = new Models.Empleado()
            };
            return Page();
        }

		// Con esto guardamos el departamento
		public async Task<IActionResult> OnPost()
		{
			if (ModelState.IsValid)
			{
				await _context.Empleado.AddAsync(EmpleadoVm.Empleado);
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
