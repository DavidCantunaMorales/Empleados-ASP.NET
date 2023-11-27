using Empleados.Data;
using Empleados.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Empleados.Pages.Departamentos
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Departamento> Departamentos { get; set; }

        public async Task OnGet()
        {
            Departamentos = await _context.Departamento.ToListAsync();
        }
    }
}
