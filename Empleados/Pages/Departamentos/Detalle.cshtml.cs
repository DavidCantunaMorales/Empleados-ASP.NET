using Empleados.Data;
using Empleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empleados.Pages.Departamentos
{
    public class DetalleModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetalleModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Departamento Departamento { get; set; }


        public async Task OnGet(int id)
        {
            Departamento = await _context.Departamento.FindAsync(id);
        }
    }
}
