using Microsoft.AspNetCore.Mvc;
using TesteDotNetInfinity.Models;

public class FreteController : Controller
{
    private readonly FreteRepo _freteRepository;

    public FreteController(FreteRepo freteRepository)
    {
        _freteRepository = freteRepository ?? throw new ArgumentNullException(nameof(freteRepository));
    }

    [HttpGet]
    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar(CadastroFrete model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        try
        {
            await _freteRepository.AddFreteAsync(model);
            return RedirectToAction(nameof(Sucesso));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return View(model);
        }
    }

    public IActionResult Sucesso()
    {
        return View();
    }
}
