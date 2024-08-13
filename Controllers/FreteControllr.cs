using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteDotNetInfinity.Database; 
using TesteDotNetInfinity.Models; 

namespace MeuProjetoAspNetCore.Controllers
{
    public class FreteController : Controller
    {
        private readonly DbContext _context;

        public FreteController(DbContext context)
        {
            _context = context;
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(CadastroFrete model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                
                _context.SaveChanges();
                
                return RedirectToAction("Sucesso");
            }

            return View(model);
        }

        public IActionResult Sucesso()
        {
            return View();
        }
    }
}
