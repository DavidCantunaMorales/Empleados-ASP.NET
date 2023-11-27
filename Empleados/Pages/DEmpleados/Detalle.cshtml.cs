using Empleados.Data;
using Empleados.Models;
using Empleados.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Pages.DEmpleados
{
    public class DetalleModel : PageModel
    {
		private readonly AppDbContext _context;

		public DetalleModel(AppDbContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Empleado Empleado { get; set; }

		public async Task OnGet(int id)
		{
			Empleado = await _context.Empleado.
				Where(d => d.Id == id).
				Include(d => d.Departamento).
				FirstOrDefaultAsync();
		}
    }
}
