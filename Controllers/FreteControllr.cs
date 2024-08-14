using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteDotNetInfinity.Models;

namespace MeuProjetoAspNetCore.Controllers
{
    public class FreteController : Controller
    {
        private readonly DbContext _context;

        public FreteController(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>
         Create([Bind("Origem,Destino,Distancia,Distancia,Peso,Status,UsuarioId,VeiculoId")]
         CadastroFrete model)
        {   
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Sucesso),"Sucesso");
            }
                return View(model);
            
        }

        public IActionResult Sucesso()
        {
            return View();
        }
    }
}
