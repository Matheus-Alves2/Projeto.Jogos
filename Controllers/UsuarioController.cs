using Microsoft.AspNetCore.Mvc;

namespace Projeto_Jogos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
