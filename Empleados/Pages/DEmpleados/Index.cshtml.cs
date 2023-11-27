using Empleados.Data;
using Empleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Pages.DEmpleados
{
    public class IndexModel : PageModel
    {
		private readonly AppDbContext _context;

		public IndexModel(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Empleado> Empleados { get; set; }

		public async Task OnGet()
        {
			Empleados = await _context.Empleado.Include(d => d.Departamento).ToListAsync();
        }
    }
}
