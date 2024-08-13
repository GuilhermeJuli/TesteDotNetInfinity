using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteDotNetInfinity.Database;
using TesteDotNetInfinity.Models;

namespace TesteDotNetInfinity.Controllers
{
    public class ListaController : Controller
    {
        private readonly DbContext _context;

        public ListaController(DbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var fretes = await _context.Set<CadastroFrete>().ToListAsync();
            return View(fretes);
        }
    }
}
